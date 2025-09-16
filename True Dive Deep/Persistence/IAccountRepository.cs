namespace True_Dive_Deep.Persistence;
using True_Dive_Deep.Data;
using True_Dive_Deep.Models;



    public interface IAccountRepository
        {
        void Add(Account account);
        void Delete(int id);
        List<Account> GetAll();
        Account? GetById(int id);
        void Update(Account account);
        }


