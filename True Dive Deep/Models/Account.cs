

namespace True_Dive_Deep.Models
{
    public class Account
    {
        public int AccountId { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }

        internal static Account? FirstOrDefault(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
