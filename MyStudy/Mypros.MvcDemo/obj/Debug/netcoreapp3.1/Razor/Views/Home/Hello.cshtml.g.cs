#pragma checksum "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\Home\Hello.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b4146b8bec43c2791471ab20c53d14af10552bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Hello), @"mvc.1.0.view", @"/Views/Home/Hello.cshtml")]
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
#line 1 "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\_ViewImports.cshtml"
using Mypros.MvcDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\donet\dotnetProj\MyStudy\Mypros.MvcDemo\Views\_ViewImports.cshtml"
using Mypros.MvcDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b4146b8bec43c2791471ab20c53d14af10552bf", @"/Views/Home/Hello.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c389b5336f47102d89677cad65ce9adf6d3f1513", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Hello : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">欢迎您，XXXX</h1>
<script src=""https://cdn.staticfile.org/vue/2.4.2/vue.min.js""></script>
<script src=""https://cdn.staticfile.org/vue-resource/1.5.1/vue-resource.min.js""></script>
<!-- 引入样式 -->
<link rel=""stylesheet"" href=""https://unpkg.com/element-ui/lib/theme-chalk/index.css"">
<!-- 引入组件库 -->
<script src=""https://unpkg.com/element-ui/lib/index.js""></script>
<div id=""app"">
     {{post()}}
       {{msg}}
<template>
  <el-table
    :data=""tableData""
    style=""width: 100%"">
      <el-table-column
      prop=""Title""
      label=""标题""
      width=""180"">
    </el-table-column>
    <el-table-column
      prop=""Url""
      label=""地址"">
    </el-table-column>
    <el-table-column
      label=""操作""
      width=""100""><span>查看</span>
      <template>        
        <el-button v-on:click=""handleClick(scope.row)"" type=""text"" title=""查看"">查看</el-button>
        <el-button type=""text"" >编辑</el-button>
      </template>
    </el-table-column>
  </el-");
            WriteLiteral(@"table>
</template>
</div>
<script  type=""text/javascript"">
    var Main = {
    methods:{
        post: function() {
               //发送 post 请求
	            this.$http.post('https://localhost:5001/Movies/IndexTest',{searchString:""共和""},{emulateJSON:true}).then(function(res){
                    this.tableData=res.body;   
                    this.msg=res.body;
                },function(res){
                    console.log(res.status);
                });
            },
            handleClick(row) {
        console.log(row);
      }
    },
    data() {
      return {
        msg:null,
        tableData: [{
          title: '王小虎',
          url: '上海市普陀区金沙江路 1518 弄'
        }]
      }
    }
  }
var Ctor = Vue.extend(Main)
new Ctor().$mount('#app')

</script>");
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
