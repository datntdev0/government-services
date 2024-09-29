using System.Threading.Tasks;
using Government.Services.Models.TokenAuth;
using Government.Services.Web.Controllers;
using Shouldly;
using Xunit;

namespace Government.Services.Web.Tests.Controllers
{
    public class HomeController_Tests: ServicesWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
