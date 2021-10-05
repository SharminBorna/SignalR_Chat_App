using Chat_App.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_App
{
    public class MessageHub:Hub
    {
        private static Dictionary<string, string> users = new Dictionary<string, string>();
        private readonly IWebHostEnvironment env;
        public MessageHub(IWebHostEnvironment env)
        {
            this.env = env;
        }
        public async override Task OnConnectedAsync()
        {
            await Clients.Caller.SendAsync("Connected", "You are connected");
        }
        public async Task AddMe(string username)
        {
            if (users.Values.Contains(username))
            {
                await Clients.Caller.SendAsync("DuplicateUser", "Choose a different name");
            }
            else
            {
                users.Add(Context.ConnectionId, username);
                await Clients.Caller.SendAsync("Joined", "You are joined");
                await Clients.All.SendAsync("UpdateUsers", users.Values.ToArray());
            }
        }
        public async Task Send(string user, string message)
        {
            await Clients.All.SendAsync("Message", user, message);
        }
        public async Task Upload(string user, ImageData data)
        {
            string path = Path.Combine(this.env.WebRootPath, "Images");
            path = Path.Combine(path, data.Filename);
            data.Image = data.Image.Substring(data.Image.LastIndexOf(',') + 1);
            string converted = data.Image.Replace('-', '+');
            converted = converted.Replace('-', '/');

            byte[] buffer = Convert.FromBase64String(converted);
            FileStream fs = new FileStream($"{path}", FileMode.Create);
            fs.Write(buffer, 0, buffer.Length);
            fs.Close();

            if (data.Filename.Contains(".jpg") || data.Filename.Contains(".png") || data.Filename.Contains(".gif"))
            {
                await Clients.All.SendAsync("Message", user, $"<a target='_blank' href='/Images/{data.Filename}' download><img src='/Images/{data.Filename}' width='100px' class='img-thumbnail circle'/></a>");
            }
            else
            {
                await Clients.All.SendAsync("Message", user, $"<a target='_blank' href='/Images/{data.Filename}'><img src='/Images/word-2013.png' width='200px' height='100px' class='img-thumbnail circle'/></a>");
            }
        }
    }
}
