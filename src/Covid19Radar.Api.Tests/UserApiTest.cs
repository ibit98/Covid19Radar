using Covid19Radar.Api;
using Covid19Radar.DataAccess;
using Covid19Radar.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Covid19Radar.Tests
{
    [TestClass]
    public class UserApiTest
    {
        [TestMethod]
        public void CreateMethod()
        {
            // preparation
            var userRepo = new Mock<IUserRepository>();
            var notification = new Mock.NotificationServiceMock();
            var infection = new Mock.InfectionServiceMock();
            var validation = new Mock.ValidationUserServiceMock();
            var logger = new Mock.LoggerMock<UserApi>();
            var userApi = new UserApi(userRepo.Object, notification, infection, validation, logger);
        }

        [DataTestMethod]
        [DataRow("")]
        public void RunMethod(string userUuid)
        {
            // preparation
            var userRepo = new Mock<IUserRepository>();
            var notification = new Mock.NotificationServiceMock();
            var infection = new Mock.InfectionServiceMock();
            var validation = new Mock.ValidationUserServiceMock();
            var logger = new Mock.LoggerMock<UserApi>();
            var userApi = new UserApi(userRepo.Object, notification, infection, validation, logger);
            var context = new Mock.HttpContextMock();
            // action
            userApi.Run(context.Request, userUuid);
            // assert
        }
    }
}
