using RMS.API.Models;
using Xunit;

namespace RMS.Tests
{
    public class RMS_BasicTests
    {
        [Fact]
        public void User_ShouldAssignRoleCorrectly()
        {
            var user = new User
            {
                Username = "KamilTest",
                Role = "Administrator"
            };

            var assignedRole = user.Role;

            Assert.Equal("Administrator", assignedRole);
            Assert.NotNull(user.Username);
        }

        [Fact]
        public void Resource_ShouldStoreDetailsCorrectly()
        {
            var resource = new Resource
            {
                Name = "Laptop Dell",
                Description = "Sprzêt biurowy"
            };

            Assert.Equal("Laptop Dell", resource.Name);
            Assert.Contains("biurowy", resource.Description);
        }
    }
}