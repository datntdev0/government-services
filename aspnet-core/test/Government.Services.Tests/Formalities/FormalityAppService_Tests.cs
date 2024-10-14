using Government.Services.Formalities;
using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Government.Services.Tests.Formalities
{
    public class FormalityAppService_Tests : ServicesTestBase
    {
        private readonly IFormalityAppService _appService;

        public FormalityAppService_Tests()
        {
            _appService = Resolve<IFormalityAppService>();
        }

        [Fact]
        public async Task GetAllAsync_Test()
        {
            // Act
            var output = await _appService.GetAllAsync();

            // Assert
            output.TotalCount.ShouldBeGreaterThan(0);
            output.Items.ShouldNotBeEmpty();
            output.Items.ShouldContain(x =>
                x.FormalityType == FormalityType.RegBirthCertificate
                && x.IsActive == true 
                && x.IsDeleted == false);
        }
    }
}
