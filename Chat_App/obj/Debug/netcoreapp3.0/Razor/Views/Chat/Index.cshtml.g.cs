#pragma checksum "D:\IsDB BISEW\Projects\Final_Evidance_SignalR\1261105-SharminBorna\Evidance_SignalR\Chat_App\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7de8f32663d582f4470c7f5d05b3df27503fe06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7de8f32663d582f4470c7f5d05b3df27503fe06", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/libs/signalr/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\IsDB BISEW\Projects\Final_Evidance_SignalR\1261105-SharminBorna\Evidance_SignalR\Chat_App\Views\Chat\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <div class=""row"" id=""ua"" style=""display: none; margin-bottom: 6px;"">
        <div class=""text-center"" style=""width: 800px; margin: 5px auto; background: white; margin-bottom: -20px;"">
            <img style=""width:150px"" src=""/logo/logo.jpg"" alt=""Alternate Text"" />
            <h1>Welcome to ChatApp</h1>
            <h4>Send free messages to your friends<br />and family members and keep connected.</h4>
        </div>
        <div class=""card"" style=""width:800px; margin:20px auto;border:none"">
            <div class=""card-body"">
                <div class=""col-6 offset-3"">
                    <div class=""form-group row"" style=""margin:20px auto"">
                        <label class=""col-form-label col-12"">Username</label>
                        <div class=""col-12"">
                            <div class=""input-group"">
                                <input type=""text"" class=""form-control"" id=""u"">
                            </div>
                        </div>
                   ");
            WriteLiteral(@"     <div class=""col-12 mt-3 mb-4"">
                            <div class=""input-group"">
                                <button type=""button"" id=""c"" class=""btn btn-info m-auto text-white"" style=""margin-left:6px;"">Join Chat</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""row my-2"" id=""ca"" style=""display:none"">
        <div class=""card"" style=""width:800px; margin:10px auto;padding-left:0"">
            <div class=""card-body"" style=""padding:0"">
                <div class=""col-3 float-start text-white"" style=""padding: 20px; background: #0dcaf0; height: 100%; "">
                    <h2>All Users</h2>
                    <ul class=""list-group"" id=""users""></ul>
                </div>
                <div class=""col-9 float-end"" style="" padding: 10px;"">
                    <div class=""row"">
                        <div class=""col-12 mb-2"">
                     ");
            WriteLiteral(@"       <div class=""list-group"" style=""border: solid; min-height: 400px;"" id=""chats""></div>
                        </div>
                    </div>
                    <div class=""form-group row mb-2"">
                        <div class=""input-group"">
                            <input type=""text"" class=""form-control"" id=""chatMessage"" />
                            <button type=""button"" id=""s"" class=""btn btn-info"" style=""margin-left:4px;color:white"">Send</button>
                            <button type=""button"" id=""br"" class=""btn btn-outline-info"">Browse</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<input type=""file"" id=""f"" style=""display:none"" accept="".jpg,.png,.gif,.pdf,.docx"" />

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7de8f32663d582f4470c7f5d05b3df27503fe066890", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7de8f32663d582f4470c7f5d05b3df27503fe067989", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"


    <script type=""text/javascript"">
        var con = new signalR.HubConnectionBuilder().withUrl(""/message"").build();
        con.on('Connected', (m) => {
            $(""#ua"").show();
        });
        con.on('Joined', (m) => {
            $(""#ua"").hide();
            $(""#da"").show();
            $(""#ca"").show();
            $(""#d"").html(displayName);
        });
        con.on('DuplicateUser', (m) => {
            console.log(m);
        });
        con.on('UpdateUsers', (userList) => {
            console.log(userList);
            $(""#users"").empty();
            for (var i = 0; i < userList.length; i++) {
                $(""#users"").append(
                    `<li class='list-group-item text-white' style=""border:none;background: #0dcaf0;"">${userList[i]}</li>`
                );
            }
        });
        con.on(""Message"", (u, m) => {
            if (displayName == u) {
                $(""#chats"").append(`<li class=""list-group-item"" style=""border:none; text-align:en");
                WriteLiteral(@"d; background: #e8fbff; margin: 10px;""><span style=""font-weight:bold;color:blue;"">${u}</span> <br/> ${m}</li>`)
            }
            else {
                $(""#chats"").append(`<li class=""list-group-item"" style=""border:none;""><span style=""font-weight:bold; color:blue;"">${u}</span> <br/> ${m}</li>`)
            }
        });
        var displayName = '';
        con.start().then(() => {
            $(""#ua"").show();
            $(""#c"").click(() => {
                displayName = $(""#u"").val();
                con.invoke(""AddMe"", displayName);
                $(""#u"").val('');
            });
            $(""#s"").click(() => {
                if ($(""#chatMessage"").val() == """") return;
                con.invoke(""Send"", displayName, $(""#chatMessage"").val());
                $(""#chatMessage"").val('');
            });
            $(""#br"").click(() => {
                $(""#f"").click();
            });
            $(""#f"").change(() => {
                var file = document.getElementById(""f"").");
                WriteLiteral(@"files[0];
                console.log(file.name);
                console.log(file.type);
                var reader = new FileReader();
                reader.onloadend = function () {
                    var data = { filename: file.name, image: reader.result };
                    console.log(data);
                    con.invoke(""Upload"", displayName, data);
                }
                reader.readAsDataURL(file);
            })
        })
    </script>
");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
