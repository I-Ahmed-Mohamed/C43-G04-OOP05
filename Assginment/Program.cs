namespace Assginment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Assignment OOP 05
            // Question 01
            #region Question_01

public interface IShape
        {
            double Area { get; }
            void DisplayShapeInfo();
        }

        public interface ICircle : IShape
        {
            double Radius { get; set; }
        }

        public interface IRectangle : IShape
        {
            double Length { get; set; }
            double Width { get; set; }
        }

        public class Circle : ICircle
        {
            public double Radius { get; set; }
            public double Area => Math.PI * Radius * Radius;

            public void DisplayShapeInfo()
            {
                Console.WriteLine($"Circle with Radius: {Radius}, Area: {Area}");
            }
        }

        public class Rectangle : IRectangle
        {
            public double Length { get; set; }
            public double Width { get; set; }
            public double Area => Length * Width;

            public void DisplayShapeInfo()
            {
                Console.WriteLine($"Rectangle with Length: {Length}, Width: {Width}, Area: {Area}");
            }
        }

        // Test Implementation
        class Program01
        {
            static void Main(string[] args)
            {
                Circle circle = new Circle { Radius = 5 };
                Rectangle rectangle = new Rectangle { Length = 4, Width = 6 };

                circle.DisplayShapeInfo();
                rectangle.DisplayShapeInfo();
            }
        }

        #endregion 

        // Question 02
        #region Question_02

        public interface IAuthenticationService
        {
            bool AuthenticateUser(string username, string password);
            bool AuthorizeUser(string username, string role);
        }

        public class BasicAuthenticationService : IAuthenticationService
        {
            private readonly Dictionary<string, (string Password, string Role)> users = new()
    {
        { "admin", ("password123", "Administrator") },
        { "user", ("password456", "User") }
    };

            public bool AuthenticateUser(string username, string password)
            {
                return users.TryGetValue(username, out var userData) && userData.Password == password;
            }

            public bool AuthorizeUser(string username, string role)
            {
                return users.TryGetValue(username, out var userData) && userData.Role == role;
            }
        }

        // Test Implementation
        class Program02
        {
            static void Main(string[] args)
            {
                IAuthenticationService authService = new BasicAuthenticationService();

                bool isAuthenticated = authService.AuthenticateUser("admin", "password123");
                bool isAuthorized = authService.AuthorizeUser("admin", "Administrator");

                Console.WriteLine($"Authenticated: {isAuthenticated}");
                Console.WriteLine($"Authorized: {isAuthorized}");
            }
        }

        #endregion

        // Question 03
        #region Question_03

        public interface INotificationService
        {
            void SendNotification(string recipient, string message);
        }

        public class EmailNotificationService : INotificationService
        {
            public void SendNotification(string recipient, string message)
            {
                Console.WriteLine($"Email sent to {recipient}: {message}");
            }
        }

        public class SmsNotificationService : INotificationService
        {
            public void SendNotification(string recipient, string message)
            {
                Console.WriteLine($"SMS sent to {recipient}: {message}");
            }
        }

        public class PushNotificationService : INotificationService
        {
            public void SendNotification(string recipient, string message)
            {
                Console.WriteLine($"Push Notification sent to {recipient}: {message}");
            }
        }

        // Test Implementation
        class Program03
        {
            static void Main(string[] args)
            {
                INotificationService emailService = new EmailNotificationService();
                INotificationService smsService = new SmsNotificationService();
                INotificationService pushService = new PushNotificationService();

                emailService.SendNotification("ahmedcodteng1@gmail.com", "Welcome to our service!");
                smsService.SendNotification("+201094547599", "Your OTP is 123456.");
                pushService.SendNotification("User123", "You have a new message.");
            }
        }

        #endregion

        #endregion
    }
}
}
