using TestNinja.Fundamentals;
using Xunit;

namespace TestNinja.UnitTest.Tests
{
    public class ReservationTest
    {
        [Fact]
        public void CancelledBy_Admin_ReturnTrue()
        {
            var reservation = new Reservation();
            var result= reservation.CanBeCancelledBy(new User() { IsAdmin = true });
            Assert.True(result);
        }

        [Fact]
        public void CancelledBy_Client_ReturnFalse()
        {
            var reservation = new Reservation();
            var result= reservation.CanBeCancelledBy(new User() { Client = false });
            Assert.False(result);
        }
    }
}