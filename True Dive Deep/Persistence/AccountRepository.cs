namespace True_Dive_Deep.Persistence;
using True_Dive_Deep.Models;

    public static class AccountRepository
    {
        private static List<Account> accounts = new List<Account>
        {
            new Account { AccountId = 1, FirstName = "Jens", Email = "Jens@gmail.com", PhoneNumber=1234678, Password = "12345"},
            new Account { AccountId = 2, FirstName = "Henrik", Email = "Henrik@gmail.com", PhoneNumber=1214678, Password = "12345"},
            new Account { AccountId = 3, FirstName = "Hanne", Email = "Hanne@gmail.com", PhoneNumber=1234478, Password = "12345"},
            new Account { AccountId = 4, FirstName = "Khalid", Email = "Khalid@gmail.com", PhoneNumber=3214678, Password = "12345"}
        };
        public static Account? GetById(int id)
        {
            return accounts.FirstOrDefault(x => x.AccountId == id);
        }

        public static List<Account> GetAll()
        {
            return accounts;
        }

        public static void Add(Account account)
        {
            if (account == null) return;

            account.AccountId = accounts.Any() ? accounts.Max(x => x.AccountId) + 1 : 1;

            accounts.Add(account);
        }

        public static void Update(Account account)
        {
            var accountToUpdate = GetById(account.AccountId);
            if (accountToUpdate != null)
            {
                accountToUpdate.FirstName = account.FirstName;
                accountToUpdate.Email = account.Email;
                accountToUpdate.PhoneNumber = account.PhoneNumber;
                accountToUpdate.Password = account.Password;
            }
        }
        public static void Delete(int id)
        {
            accounts.RemoveAll(x => x.AccountId == id);
        }
    }


