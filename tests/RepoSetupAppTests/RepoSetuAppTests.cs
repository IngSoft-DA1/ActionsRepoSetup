namespace RepoSetupAppTests;
using RepoSetupApp.Domain;

[TestClass]
public class RepoSetuAppTests
{
    [TestMethod]
    public void ShouldReturnTrueAfterSetup()
    {
        // Arrange
        var repoSetupApp = new DomainClass();

        // Act
        var result = repoSetupApp.IsWorking();

        // Assert
        Assert.IsTrue(result);
    }
}