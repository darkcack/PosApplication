#pragma checksum "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01b86f3ef0d0c8475bc7444c1165c6ababc852fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\_ViewImports.cshtml"
using pos.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\_ViewImports.cshtml"
using pos.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\_ViewImports.cshtml"
using POS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01b86f3ef0d0c8475bc7444c1165c6ababc852fa", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ee2036b6e208d9994fdf84ce9ce9b355dbe5e66", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ab"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("food"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "food", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("a"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("fiyat"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
  
    ViewData["Title"] = "List";
        Layout = "_Layout";
        string filter1="";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  <link href=""https://fonts.googleapis.com/css?family=DM+Serif+Display&display=swap"" rel=""stylesheet"">
  <link href=""https://fonts.googleapis.com/css?family=Archivo:400i&display=swap"" rel=""stylesheet"">


<style> 
    .right{
         float:right;
    }
    .left{
         float:left;
    }
    .icerik {
display: table-cell;
vertical-align: middle;
    }
    .a{
      width:50px;
    }
    .ab{
      width:170px;
    }

html,body {
	width:100%;
	position:relative;
}

h4, h5{
  font-family: 'Archivo', sans-serif;
}


</style>

<br>
<div class=""dropdown"">
  <button class=""btn btn-danger dropdown-toggle right"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
    Kategori Seç
  </button>
  <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuButton"">
    <button class=""dropdown-item"" href=""#""></button>
    <button class=""dropdown-item"" href=""#"">Et</button>
    <button class=""dropdown-item"" href=""#"">İçecekler</button>
    <button class=""dropdown-item"" href=");
            WriteLiteral("\"#\">Pideler</button>\n    <button class=\"dropdown-item\" href=\"#\">Tatlılar</button>\n  </div>\n</div>\n\n<br>\n<br>\n\n");
#nullable restore
#line 58 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
 foreach (var item in Model)
{
  
  
      

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-row  \">\n\n    <div class=\"col-md-6  \">\n\n        <div class=\"card text-center icerik \" style=\"width: 300px; height:350px \">\n\n            <div class=\"card-header bg-white\"> \n\n            <h4 class=\"card-title  \"> ");
#nullable restore
#line 71 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </h4>\n\n            </div> <!-- CARD HEADER SONU-->\n\n       <div class=\"card-body\">\n    \n        <h5 class=\"card-subtitle mb-2   \">");
#nullable restore
#line 78 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
                                     Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </h5>\n        <h5 class=\"card-text\">");
#nullable restore
#line 80 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
                         Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </h5>\n         <h5 class=\"card-text\">");
#nullable restore
#line 82 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
                          Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" TL\n        </h5>\n    \n\n\n          <hr class=\"bg-danger\">\n\n          <button type=\"button\" class=\"btn btn-outline-danger  btn-lg \" data-target=\"#DeleteModal-");
#nullable restore
#line 89 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
                                                                                             Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\">\n            Sil\n          </button>\n          <button type=\"button\" class=\"btn btn-outline-success btn-lg\" data-toggle=\"modal\" data-target=\"#modal_");
#nullable restore
#line 92 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
                                                                                                          Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n          Sipariş Ver\n          </button>\n\n       \n   \n            </div> <!-- CARD BODY SONU -->  \n\n        </div>  <!--CARD SONU --> \n\n    </div> <!-- DİV CLASS COL-MD-6 SONU --> \n\n            <div class=\"col-md-6 \">\n");
#nullable restore
#line 105 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
               if(item.Image!=null)
              {
              var base64=Convert.ToBase64String(item.Image);
              var imgsrc = string.Format("data:image/jpeg;base64,{0}", base64);

#line default
#line hidden
#nullable disable
            WriteLiteral("              <img");
            BeginWriteAttribute("src", " src=\'", 2602, "\'", 2615, 1);
#nullable restore
#line 109 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
WriteAttributeValue("", 2608, imgsrc, 2608, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img img-thumbnail rounded-circle\" alt=\"Card image cap\" width=\"280px\" height=\"300px\">\n");
#nullable restore
#line 110 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>   <!--DİV CLASS COL-MD-6 SONU -->\n            \n            </div>  <!--FORM ROW SONU-->\n        <br>\n        <br>\n");
            WriteLiteral("<!-- Modal -->\n<div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 2902, "\"", 2928, 2);
            WriteAttributeValue("", 2907, "modal_", 2907, 6, true);
#nullable restore
#line 118 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
WriteAttributeValue("", 2913, item.ProductId, 2913, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""OrderModale"" aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"" id=""exampleModalLongTitle"">Sipariş Ver</h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div id=""app"" class=""modal-body"">
        <div class=""container-fluid"">
          <div class=""row"">
            <div class=""col-md-5"">Yemek<hr>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "01b86f3ef0d0c8475bc7444c1165c6ababc852fa13290", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 131 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n  \n            </div>\n            <div class=\"col-md-3\">Adet<hr>\n            <input id=\"adet\" type=\"number\" min=\"1\" max=\"20\"/>\n            </div>\n\n\n            <div class=\"col-md-4\">Fiyat<hr>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "01b86f3ef0d0c8475bc7444c1165c6ababc852fa15837", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
#nullable restore
#line 140 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Price);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
      
      
      </div>
      <br>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-danger"">Sil</button>
        <button type=""button"" class=""btn btn-success"">Onayla</button>
      </div>
    </div>
  </div>
</div>
</div>
</div>
<!-- MODAL END -->
");
            WriteLiteral("<!-- BU DELETE MODALI -->\n");
            WriteLiteral(" <div class=\"modal fade text-dark\"");
            BeginWriteAttribute("id", " id=\"", 4244, "\"", 4276, 2);
            WriteAttributeValue("", 4249, "DeleteModal-", 4249, 12, true);
#nullable restore
#line 160 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
WriteAttributeValue("", 4261, item.ProductId, 4261, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""DeleteModal"" aria-hidden=""true"">
  <div class=""modal-dialog modal-dialog-centered"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">

        <h5 class=""modal-title"" id=""DeleteTitle"">");
#nullable restore
#line 165 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
                                            Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" numaralı ürün\n\n        </h5>\n        <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\n          <span aria-hidden=\"true\">&times;</span>\n        </button>\n      </div>\n      <div class=\"modal-body\">\n        <p>\n          ");
#nullable restore
#line 174 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n          \"silinsin mi?\"\n\n      </p>\n \n      </div>\n\n      <div class=\"modal-footer\">\n        <button type=\"button\" class=\"btn btn-outline-secondary\" data-dismiss=\"modal\">İptal</button>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01b86f3ef0d0c8475bc7444c1165c6ababc852fa20122", async() => {
                WriteLiteral("\n          Sil");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 183 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"
                                                           WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n      </div>\n    </div>\n  </div>\n</div>\n");
            WriteLiteral("<!-- Delete Modalının sonu -->\n");
#nullable restore
#line 191 "C:\Users\Mert\Downloads\PosApplication-master\PosApplication-master\Views\Product\List.cshtml"


}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\n<script>\n  \n  function filter1() {\n    return filter1;\n  }\n</script>\n");
            }
            );
            WriteLiteral("\n        \n      \n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591