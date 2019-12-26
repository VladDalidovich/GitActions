using Moq;
using Xunit;

namespace Tests.Service
{
    public class ServicesTests
    {
        [Fact]
        public void IsHelloWorldMessage_WhenMessageCorrect_ReturnTrue()
        {
            //Arrange
            var message = "Hello World!";
            var service = new Mock<GitActions.Services.Service>().Object;

            //Act
            var result = service.IsHelloWorldMessage(message);
            
            //Assert
            Assert.True(result);
        }
        
        [Fact]
        public void IsHelloWorldMessage_WhenMessageCorrect_ReturnFalse()
        {
            //Arrange
            var service = new Mock<GitActions.Services.Service>().Object;

            //Act
            var result = service.IsHelloWorldMessage(It.IsAny<string>());
            
            //Assert
            Assert.False(result);
        }
    }
}