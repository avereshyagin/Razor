namespace Microsoft.AspNetCore.Razor.Evolution.IntegrationTests.TestFiles
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_TransitionsInTagHelperAttributes_DesignTime
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        ((System.Action)(() => {
System.Object __typeHelper = "*, TestAssembly";
        }
        ))();
        }
        #pragma warning restore 219
        private static System.Object __o = null;
        private global::TestNamespace.PTagHelper __TestNamespace_PTagHelper = null;
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
   
    var @class = "container-fluid";
    var @int = 1;

#line default
#line hidden
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
#line 7 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
__TestNamespace_PTagHelper.Age = 1337;

#line default
#line hidden
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
#line 8 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
      __o = @class;

#line default
#line hidden
#line 8 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
__TestNamespace_PTagHelper.Age = 42;

#line default
#line hidden
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
#line 9 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
__TestNamespace_PTagHelper.Age = 42 + @int;

#line default
#line hidden
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
#line 10 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
__TestNamespace_PTagHelper.Age = int;

#line default
#line hidden
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
#line 11 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
__TestNamespace_PTagHelper.Age = (@int);

#line default
#line hidden
            __TestNamespace_PTagHelper = CreateTagHelper<global::TestNamespace.PTagHelper>();
#line 12 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
             __o = @class;

#line default
#line hidden
#line 12 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/TransitionsInTagHelperAttributes.cshtml"
__TestNamespace_PTagHelper.Age = 4 * @(@int + 2);

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
