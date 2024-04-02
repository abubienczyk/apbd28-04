using System.Runtime.InteropServices.JavaScript;
using LegacyApp;

namespace LegacyAppTests;

public class UserServiceTests
{
    [Fact]
    public void AddUser_Should_Return_False_When_Email_Without_At_And_Dot()
    {
        //Arrange
        string firstName = "John";
        string lastName = "Doe";
        DateTime birthDate = new DateTime(1980, 1, 1);
        int clientId = 1;
        string email = "doe";
        var service = new UserService();
        //Act
        bool result = service.AddUser(firstName, lastName, email, birthDate, clientId);

        //Assert
        Assert.Equal(false,result);
    }
    
    [Fact]
    public void AddUser_Should_Return_False_When_Younger_Then_21()
    {
        //Arrange
        string firstName = "John";
        string lastName = "Doe";
        DateTime birthDate = new DateTime(1980, 1, 1);
        int clientId = 1;
        string email = "doe";
        var service = new UserService();
        //Act
        bool result = service.AddUser(firstName, lastName, email, birthDate, clientId);

        //Assert
        Assert.Equal(false,result);
    }
    
    [Fact]
    public void AddUser_Should_Return_False_When_Missing_FirstName()
    {
        //Arrange
        string firstName = null;
        string lastName = null;
        DateTime birthDate = new DateTime(1980, 1, 1);
        int clientId = 1;
        string email = "doe";
        var service = new UserService();
        //Act
        bool result = service.AddUser(firstName, lastName, email, birthDate, clientId);

        //Assert
        Assert.Equal(false,result);
    }
    
    [Fact]
    public void AddUser_Should_Return_False_When_Missing_LastName()
    {
        //Arrange
        string firstName = null;
        string lastName = null;
        DateTime birthDate = new DateTime(1980, 1, 1);
        int clientId = 1;
        string email = "doe";
        var service = new UserService();
        //Act
        bool result = service.AddUser(firstName, lastName, email, birthDate, clientId);

        //Assert
        Assert.Equal(false,result);
    }
    
    [Fact]
    public void AddUser_Should_Return_True_When_Very_Important_Client()
    {
        //Arrange
        DateTime birthDate = new DateTime(1980, 1, 1);
        var service = new UserService();
        //Act
        var result = service.AddUser("John", "Malewski","malewski@gmail.pl",birthDate,2);
        
        //Assert
        Assert.Equal(true,result);
    }
    
    [Fact]
    public void AddUser_Should_Return_True_When_Important_Client()
    {
        //Arrange
        string firstName = "John";
        string lastName = "Smith";
        DateTime birthDate = new DateTime(1980, 1, 1);
        int clientId = 3;
        string email = "smith@gmail.pl";
        var service = new UserService();
        //Act
        var result = service.AddUser(firstName, lastName, email, birthDate, clientId);

        //Assert
        Assert.Equal(true,result);
    }
    
    [Fact]
    public void AddUser_Should_Return_True_When_Normal_Client()
    {
        //Arrange
        string firstName = "John";
        string lastName = "Kwiatkowski";
        DateTime birthDate = new DateTime(1980, 1, 1);
        int clientId = 5;
        string email = "kwiatkowski@wp.pl";
        var service = new UserService();
        //Act
        var result = service.AddUser(firstName, lastName, email, birthDate, clientId);

        //Assert
        Assert.Equal(true,result);
    }
    
    [Fact]
    public void AddUser_Should_Return_False_When_User_Has_CreditLimit_And_CreditLimit_Is_Lower_Than_500()
    {
        //Arrange
        string firstName = "John";
        string lastName = "Kowalski";
        DateTime birthDate = new DateTime(1980, 1, 1);
        int clientId = 1;
        string email = "kowalski@wp.pl";
        var service = new UserService();
        //Act
        var result = service.AddUser(firstName, lastName, email, birthDate, clientId);
        //Assert
        Assert.Equal(false,result);
    }
    
}