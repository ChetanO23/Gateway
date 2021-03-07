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
        private readonly Mock<IPassengerManager> mockDtaRepository = new Mock<IPassengerManager>();
        private readonly PassengerController _passengerController;
        public PassengerUnitTest()
        {
            _passengerController = new PassengerController(mockDtaRepository.Object);
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

        [Fact]
        public void GetAllPassenger1()
        {
            // Arrange
            var resultObj = mockDtaRepository.Setup(x => x.GetAllPassengers()).Returns(GetPassenger());

            // Act
            var response = _passengerController.GetPassengers();

            // Asert
            Assert.Equal(4, response.Count);

        }

        [Fact]
        public void GetAllPassenger2()
        {
            // Arrange
            var resultObj = mockDtaRepository.Setup(x => x.GetAllPassengers()).Returns(GetPassenger());

            // Act
            var response = _passengerController.GetPassengers();

            // Asert
            Assert.NotEqual(2, response.Count);

        }

        [Fact]
        public void GetPassengerById1()
        {
            // Arrange
            var passenger = new PassengerView();
            passenger.PassengerNumber = 1;
            passenger.FirstName = "Anil";
            passenger.LastName = "Ladumore";
            passenger.PhoneNo = "90876534321";

            // Act
            var responseObj = mockDtaRepository.Setup(x => x.GetPassneger(passenger.PassengerNumber)).Returns(passenger);
            var result = _passengerController.GetPassenger(passenger.PassengerNumber);

            // Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void GetPassengerById2()
        {
            // Arrange
            var passenger = new PassengerView();
            // Act
            var responseObj = mockDtaRepository.Setup(x => x.GetPassneger(4)).Returns(passenger);
            var result = _passengerController.GetPassenger(passenger.PassengerNumber);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void AddPassenger1()
        {
            var newPassenger = new PassengerView();
            newPassenger.PassengerNumber = 4;
            newPassenger.FirstName = "Darshan";
            newPassenger.LastName = "Kava";
            newPassenger.PhoneNo = "1254630789";
            // Act
            var response = mockDtaRepository.Setup(x => x.CreateNewPassneger(newPassenger)).Returns("Added succeffuly");
            var result = _passengerController.PostPassenger(newPassenger);

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void AddPassenger2()
        {
            var newPassenger = new PassengerView();

            // Act
            var response = mockDtaRepository.Setup(x => x.CreateNewPassneger(newPassenger)).Returns("Model is null");
            var result = _passengerController.PostPassenger(newPassenger);

            // Assert
            Assert.NotNull(result);
        }
        [Fact]
        public void UpdatePassenger1()
        {
            // Arrange
            var UpdatePassenger = new PassengerView();
            UpdatePassenger.PassengerNumber = 4;
            UpdatePassenger.FirstName = "Rahul";
            UpdatePassenger.LastName = "Bhagat";
            UpdatePassenger.PhoneNo = "8695049752";

            // Act
            var resultObj = mockDtaRepository.Setup(x => x.UpdatePassneger(4, UpdatePassenger)).Returns("Passenger updated");
            var response = _passengerController.PutPassenger(4, UpdatePassenger);
            // Assert
            Assert.Equal("Passenger updated", response);
        }
        [Fact]
        public void UpdatePassenger2()
        {
            // Arrange
            var UpdatePassenger = new PassengerView();

            // Act
            var resultObj = mockDtaRepository.Setup(x => x.UpdatePassneger(5, UpdatePassenger)).Returns("Model is null");
            var response = _passengerController.PutPassenger(5, UpdatePassenger);
            // Assert
            Assert.NotEqual("Passenger updated", response);
        }
        [Fact]
        public void DeletePassenger1()
        {
            var passenger = new PassengerView();
            passenger.PassengerNumber = 1;
            // Arrange
            var resultObj = mockDtaRepository.Setup(x => x.DeletePassneger(passenger.PassengerNumber)).Returns(true);

            // Act
            var response = _passengerController.DeletePassenger(passenger.PassengerNumber);

            //Assert
            Assert.True(response);

        }
        [Fact]
        public void DeletePassenger2()
        {
            var passenger = new PassengerView();
            passenger.PassengerNumber = 4;
            // Arrange
            var resultObj = mockDtaRepository.Setup(x => x.DeletePassneger(passenger.PassengerNumber)).Returns(false);

            // Act
            var response = _passengerController.DeletePassenger(passenger.PassengerNumber);

            //Assert
            Assert.False(response);

        }
    }
}
