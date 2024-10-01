namespace SF.Module12.Unit2
{
    public class User 
    {
        public bool LoggedId;
        public bool HasAccessToSection;
        public bool HasUnseenNews;
        public bool HasAdminRigths;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void GetPageForUser(User user)
        {
            if (!user.LoggedId)
            {
                return;
            }
            Console.WriteLine("User logged in");

            if (!user.HasAccessToSection)
            {
                return;
            }
            Console.WriteLine("User has access to that section");

            if (user.HasUnseenNews)
            {
            }

            if (user.HasAdminRigths)
            {

            }

        }
    }
}
