using Whear.Web.Models;

namespace Whear.Web.Data
{
    public class Initializer
    {
        public static void Seed(Context context)
        {
            // Creates the database if it doesn't exist.
            context.Database.EnsureCreated();
            
            // Test data for development.
            var user = new User
            {
                ID = 1,
                Email = "joeyblankendaal@gmail.com",
                Password = "123"
            };

            context.User.Add(user);

            // Saves changes.
            context.SaveChanges();
        }
    }
}