using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AlternativeStrategy.WIthAbstract;

namespace AlternativeStrategy.TemplatePattern
{
    public abstract class AbstractTemplate
    {
        public void AddNewUser(PPerson person, UserLogin userLogin)
        {
            Validate(person);
            ValidateLogin(userLogin);
            AddUser(person);
            AddUserLogin(userLogin);
            Success(person);
        }
        public void GetFlow()
        {
            PPerson pp = new PPerson(3, "Karl"); 
            Add(pp);
            List<PPerson> persons = GetAllProducts();
            foreach (PPerson person in persons)
            {
                Console.WriteLine(person.Name);
            }

        }
        public abstract PPerson Validate(PPerson person);
        public abstract UserLogin ValidateLogin(UserLogin userLogin);
        public abstract PPerson Add(PPerson person);
        public abstract PPerson AddUser(PPerson person);
        public abstract PPerson AddUserLogin(UserLogin userlogin);
        public abstract List<PPerson> GetAllUsers();
        public abstract List<PPerson> GetAllProducts();
        public virtual void Success(PPerson person)
        {
            Console.WriteLine($"Success {person.Name} is added to database.");
        }
    }
}
