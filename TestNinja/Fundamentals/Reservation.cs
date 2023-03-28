namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }
        public bool CanBeCancelledBy(User user)
        {
            if (user.IsAdmin || user == MadeBy)
                return true;

            if (user.Client) 
                return false;

            return false;
        }
    }

    public class User
    {
        public bool IsAdmin { get; set; }
        public bool Client { get; set; }
    }
}
    