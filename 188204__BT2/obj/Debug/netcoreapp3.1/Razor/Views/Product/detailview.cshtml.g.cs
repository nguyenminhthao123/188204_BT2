#pragma checksum "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f0b72a7acda5ec2a246d28919bc5c2ed10e1ec0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_detailview), @"mvc.1.0.view", @"/Views/Product/detailview.cshtml")]
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
#line 1 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\_ViewImports.cshtml"
using _188204__BT2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\_ViewImports.cshtml"
using _188204__BT2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f0b72a7acda5ec2a246d28919bc5c2ed10e1ec0", @"/Views/Product/detailview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed63747decc922e7798433ee8d5cac91107e419f", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_detailview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_188204__BT2.Models.CollectionDataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Layout/commit.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/slide.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
  
    ViewData["Title"] = "Chi chi???t s???n ph???m";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section>
    <ul class=""breadcrumb"">
        <li><a>????? ch??i</a> </li>
        <li><a>????? ch??i lego </a></li>
    </ul>
    <div class=""detail"">
        <div class=""detail__left"">
            <div class=""box_fotorama"">
                <div class=""main-imgs"">
");
#nullable restore
#line 15 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                     foreach (var i in @Model.ProductDeatail.DetailProduct.Imagethump)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 511, "\"", 523, 1);
#nullable restore
#line 17 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
WriteAttributeValue("", 517, i.Img, 517, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"main-img\" />\r\n");
#nullable restore
#line 18 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"gallery\">\r\n");
#nullable restore
#line 21 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                     foreach (var i in @Model.ProductDeatail.DetailProduct.Imagethump)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 771, "\"", 783, 1);
#nullable restore
#line 23 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
WriteAttributeValue("", 777, i.Img, 777, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 24 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"count\">\r\n                    <span class=\"count-current\"></span>\r\n                    <span class=\"count-total\">");
#nullable restore
#line 29 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                         Write(Model.ProductDeatail.DetailProduct.Imagethump.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div>
                <div class=""prev-next-btn"">
                    <span class=""prev-btn""><i class=""fa-solid fa-angle-left""></i></span>
                    <span class=""next-btn""><i class=""fa-solid fa-angle-right""></i></span>
                </div>
                <div class=""zoom"">
                    <i class=""fa-solid fa-magnifying-glass""></i>
                </div>
            </div>
            <div class=""info__product"">
                <div class=""article__content"">
                    <h2 class=""article__content__title"">th??ng tin s???n ph???m</h2>
                    <h3>?????c ??i???m n???i b???t</h3>
                    <ul>
");
#nullable restore
#line 44 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                         foreach (var i in @Model.ProductDeatail.DetailProduct.ProductFeatures)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a href=\"/home/index\">");
#nullable restore
#line 47 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                                 Write(i.NameFeatureLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> ");
#nullable restore
#line 47 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                                                        Write(i.NameFeature);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 49 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                    <h3>H?????ng d???n s??? d???ng</h3>\r\n                    <ul>\r\n");
#nullable restore
#line 53 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                         foreach (var i in @Model.ProductDeatail.DetailProduct.UseManual)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a href=\"/home/index\">");
#nullable restore
#line 56 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                                 Write(i.ContextLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> ");
#nullable restore
#line 56 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                                                    Write(i.Context);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 58 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"detail__right\">\r\n            <div class=\"box__productInfor\">\r\n                <div class=\"detail-title\">\r\n                    <h3>");
#nullable restore
#line 66 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                   Write(Model.ProductDeatail.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n                <div class=\"detail-top\">\r\n                    <div class=\"detail-price\">\r\n                        <span class=\"price-current\">");
#nullable restore
#line 70 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                               Write(Model.ProductDeatail.Calcula());

#line default
#line hidden
#nullable disable
            WriteLiteral("??</span>\r\n                        <span class=\"price-old\">");
#nullable restore
#line 71 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                           Write(Model.ProductDeatail.FormatPrice());

#line default
#line hidden
#nullable disable
            WriteLiteral("??</span>\r\n                        <span class=\"price-percent\">-");
#nullable restore
#line 72 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                                Write(Model.ProductDeatail.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" %</span>
                    </div>
                    <div class=""product-code"">#258922</div>
                </div>
                <div class=""box-promo"">
                    <p class=""box-promo-text"">Khuy????n ma??i (??????n 31/05)</p>
                    <ul class=""box-promo-list"">
                        <li class=""divb"">Nh???p m?? AVAKID gi???m 10% t???i ??a 100.000?? cho ????n h??ng t??? 300.000?? tr??? l??n khi thanh to??n qua V?? Moca tr??n ???ng d???ng Grab <a href=""#"">(click xem chi ti???t)</a></li>
                    </ul>
                </div>
                <div class=""detail-btn"">
                    <a class=""btn btn-addCard"">Th??m v??o gi???</a>
                    <a class=""btn btn-viewStort"">Xem c???a h??ng c??n h??ng</a>
                </div>
            </div>
            <ul class=""policy"">
");
#nullable restore
#line 88 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                 foreach (var i in @Model.ProductDeatail.DetailProduct.Policy)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\r\n                        <i");
            BeginWriteAttribute("class", " class=\"", 4026, "\"", 4041, 1);
#nullable restore
#line 91 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
WriteAttributeValue("", 4034, i.Icon, 4034, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                        <p>");
#nullable restore
#line 92 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                      Write(i.NamePolicy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </li>\r\n");
#nullable restore
#line 94 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n            <div class=\"info__detail\">\r\n                <p class=\"info__title\">Th??ng tin chi ti???t</p>\r\n                <div class=\"info-content\">\r\n                    <ul class=\"info-article\">\r\n");
#nullable restore
#line 100 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                         foreach (var i in Model.ProductDeatail.DetailProduct.InfoTeach)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <p class=\"text1\">");
#nullable restore
#line 103 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                            Write(i.NameInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 104 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                  
                                    if (@i.ValueInfo.Count >= 2)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"text2-group\">\r\n");
#nullable restore
#line 108 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                             foreach (var item in @i.ValueInfo)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p class=\"dot\">");
#nullable restore
#line 110 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                                          Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 111 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </div>\r\n");
#nullable restore
#line 113 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <p class=\"text2\">");
#nullable restore
#line 116 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                                    Write(i.ValueInfo[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 117 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 121 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"detail-product\">\r\n        <p class=\"detail-product-title\">????? ch??i kh??c</p>\r\n        <div class=\"product-Card\">\r\n");
#nullable restore
#line 131 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
             foreach (var product in @Model.ProductList)
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
           Write(await Component.InvokeAsync("ProductItem", product));

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "D:\COMPANY MWG\Tesst\188204__BT2\188204__BT2\Views\Product\detailview.cshtml"
                                                                    
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"comment\">\r\n        <b class=\"cmt-title\">H???i ????p v??? ????? ch??i tr???m c???nh s??t tu???n tra v?? c???u h???a bi???n Lego City 60308 (297 chi ti???t)</b>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0b72a7acda5ec2a246d28919bc5c2ed10e1ec018546", async() => {
                WriteLiteral(@"
            <div class=""cmt-text"">
                <textarea></textarea>
                <div class=""info-container"">
                    <div class=""group-radios"">
                        <div class=""group-radio"">
                            <input type=""radio"" />
                            <label>Anh</label>
                        </div>
                        <div class=""group-radio"">
                            <input type=""radio"" />
                            <label>Ch???</label>
                        </div>
                    </div>
                    <div class=""info-users"">
                        <div class=""info-user"">
                            <input type=""text"" name=""name"" class=""input-info"" />
                            <label class=""lb-name"">H??? v?? t??n</label>
                        </div>
                        <div class=""info-user"">
                            <input type=""number"" name=""number"" class=""input-info"" />
                            <label class=""lb-");
                WriteLiteral(@"name"">S??? ??i???n tho???i</label>
                        </div>
                        <div class=""info-user"">
                            <input type=""email"" name=""Email"" class=""input-info"" />
                            <label class=""lb-name"">Email</label>
                        </div>
                        <div class=""bnt-submit"">
                            <button type=""submit"" class=""bt-submit"">G???i</button>
                        </div>
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</section>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6f0b72a7acda5ec2a246d28919bc5c2ed10e1ec021451", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"/lib/jquery/dist/jquery.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f0b72a7acda5ec2a246d28919bc5c2ed10e1ec022628", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_188204__BT2.Models.CollectionDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
