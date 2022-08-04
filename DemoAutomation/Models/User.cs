namespace DemoAutomation.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string v1, string v2)
        {
            UserName = v1;
            Password = v2;
        }

        public static User Default() => new User("Admin", "Admin123");
        public static User InvalidPassword() => new User("Admin", "Invalid123");
        public static User InvalidUser() => new User("Invalid", "Admin123");

    }
}
