using System.ComponentModel.DataAnnotations;

namespace utilities_for_developers.Services
{
    public class Generators
    {
        public Generators() { }

        public string GeneratePassword(int length = 8)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            string password = "";

            Random rnd = new Random();
            while (0 < length--)
            {
                password += validChars[rnd.Next(validChars.Length)];
            }

            return password;
        }
    }
}
