using System.Threading.Tasks;
using FlexiCloudPay.Models.TokenAuth;
using FlexiCloudPay.Web.Controllers;
using Shouldly;
using Xunit;

namespace FlexiCloudPay.Web.Tests.Controllers
{
    public class HomeController_Tests: FlexiCloudPayWebTestBase
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