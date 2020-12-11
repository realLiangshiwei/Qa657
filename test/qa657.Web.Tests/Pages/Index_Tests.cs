using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace qa657.Pages
{
    public class Index_Tests : qa657WebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
