using System.Collections.Generic;
using Xunit;
using Moq;
using System.Linq;
using BusinessLogic.Interface;
using BusinessEntitites;
using UnitTest_1.Controllers;

namespace UnitTest
{
    public class PassengerUnitTest
    {
        // Mock object for Passenger Repository
        private readonly Mock<IPassengerManager> mockDtaRepository = new Mock<IPassengerManager>();

        // Passenger Controller object
        private readonly PassengerController _passengerController;

        // Constructor
        public PassengerUnitTest()
        {
            _passengerController = new PassengerController(mockDtaRepository.Object);
        }

       

        [Fact]
        public void TestGetAllPassengerEqual()
        {
            // Arrange
            var setup = mockDtaRepository.Setup(x => x.GetAllPassengers()).Returns(GetPassenger());

            // Act
            var result = _passengerController.GetPassengers();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(4, result.Count());

        }

        [Fact]
        public void TestGetAllPassengerNotEqual()
        {
            // Arrange
            var setup = mockDtaRepository.Setup(x => x.GetAllPassengers()).Returns(GetPassenger());

            // Act
            var result = _passengerController.GetPassengers();

            // Assert
            Assert.NotNull(result);
            Assert.NotEqual(2, result.Count);

        }

        [Fact]
        public void TestGetPassengerByIdNotNull()
        {
            // Arrange
            var passenger = new PassengerView();
            passenger.PassengerNumber = 1;
            passenger.FirstName = "Anil";
            passenger.LastName = "Ladumore";
            passenger.PhoneNo = "90876534321";
          
            var setup = mockDtaRepository.Setup(x => x.GetPassneger(passenger.PassengerNumber)).Returns(passenger);

            // Act
            var result = _passengerController.GetPassenger(passenger.PassengerNumber);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void TestGetPassengerByIdNull()
        {
            // Arrange
            var passenger = new PassengerView();
            var setup = mockDtaRepository.Setup(x => x.GetPassneger(4)).Returns(passenger);

            // Act
            var result = _passengerController.GetPassenger(passenger.PassengerNumber);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void TestAddPassengerNotNull()
        {
            // Arrange
            var newPassenger = new PassengerView();
            newPassenger.PassengerNumber = 4;
            newPassenger.FirstName = "Darshan";
            newPassenger.LastName = "Kava";
            newPassenger.PhoneNo = "1254630789";

            var setup = mockDtaRepository.Setup(x => x.CreateNewPassneger(newPassenger)).Returns("Added succeffuly");

            // Act
            var result = _passengerController.PostPassenger(newPassenger);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void TestAddPassengerNull()
        {
            // Arrange
            var newPassenger = new PassengerView();
            var setup = mockDtaRepository.Setup(x => x.CreateNewPassneger(newPassenger)).Returns("Model is null");

            // Act
            var result = _passengerController.PostPassenger(newPassenger);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void TestUpdatePassengerEqual()
        {
            // Arrange
            var UpdatePassenger = new PassengerView();
            UpdatePassenger.PassengerNumber = 4;
            UpdatePassenger.FirstName = "Rahul";
            UpdatePassenger.LastName = "Bhagat";
            UpdatePassenger.PhoneNo = "8695049752";
           
            var setup = mockDtaRepository.Setup(x => x.UpdatePassneger(4, UpdatePassenger)).Returns("Passenger updated");

            // Act
            var result = _passengerController.PutPassenger(4, UpdatePassenger);
            
            // Assert
            Assert.Equal("Passenger updated", result);
        }

        [Fact]
        public void TestUpdatePassengerNotEqual()
        {
            // Arrange
            var UpdatePassenger = new PassengerView();
            var setup = mockDtaRepository.Setup(x => x.UpdatePassneger(5, UpdatePassenger)).Returns("Model is null");

            // Act
            var result = _passengerController.PutPassenger(5, UpdatePassenger);
           
            // Assert
            Assert.NotEqual("Passenger updated", result);
        }

        [Fact]
        public void TestDeletePassengerTrue()
        {
            // Arrange
            var passenger = new PassengerView();
            passenger.PassengerNumber = 1;
           
            var setup = mockDtaRepository.Setup(x => x.DeletePassneger(passenger.PassengerNumber)).Returns(true);

            // Act
            var result = _passengerController.DeletePassenger(passenger.PassengerNumber);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void TestDeletePassengerFalse()
        {
            // Arrange
            var passenger = new PassengerView();
            passenger.PassengerNumber = 4;
            
            var setup = mockDtaRepository.Setup(x => x.DeletePassneger(passenger.PassengerNumber)).Returns(false);

            // Act
            var result = _passengerController.DeletePassenger(passenger.PassengerNumber);

            // Assert
            Assert.False(result);

        }

        private static List<PassengerView> GetPassenger()
        {
            List<PassengerView> users = new List<PassengerView>()
            {
                new PassengerView() {PassengerNumber=1,FirstName="Chetan",LastName="More",PhoneNo="1234567890"},
                new PassengerView() {PassengerNumber=1,FirstName="Devyani",LastName="More",PhoneNo="7980865332"},
                new PassengerView() {PassengerNumber=1,FirstName="Sanjay",LastName="More",PhoneNo="5263065336"},
                new PassengerView() {PassengerNumber=1,FirstName="Vandana",LastName="More",PhoneNo="8542631079"},

            };
            return users;
        }
    }
}
