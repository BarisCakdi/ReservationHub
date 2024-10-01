namespace ReservationHub.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PassRepeat { get; set; }
        public Role Role { get; set; } = Role.Customer;

        public ICollection<Reservation> Reservations { get; set; }
    }

    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string CampSite { get; set; }

        public User User { get; set; }
    }

    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImgPath { get; set; }
        public DateTime Date { get; set; }
    }

    public enum Role
    {
        Customer,
        BusinessOwner,
        Admin
    }

}
