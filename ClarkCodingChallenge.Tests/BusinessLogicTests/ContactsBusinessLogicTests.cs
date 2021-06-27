using ClarkCodingChallenge.DataAccess;
using ClarkCodingChallenge.BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

// Reference: https://stackoverflow.com/questions/34616149/unit-testing-with-dependency-injection-and-moq
// https://docs.microsoft.com/en-us/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2019

namespace ClarkCodingChallenge.Tests.BusinessLogicTests
{
    [TestClass]
    public class ContactsBusinessLogicTests
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void ContactsServiceCreateFailWithBlank()
        {
            // How do we go about testing our SimpleDataStorage implementation if we're using a mock object here?

            // Arrange
            Mock<IContactsDataAccess> mockDataAccess = new Mock<IContactsDataAccess>();
            ContactsService contactsService = new ContactsService(mockDataAccess.Object);

            // Act
            contactsService.AddContact("", "", "");

            // Assert
            // Nothing to do here because we expect an exception

        }
    }
}
