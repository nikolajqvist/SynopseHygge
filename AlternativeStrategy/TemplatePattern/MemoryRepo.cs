using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AlternativeStrategy.WIthAbstract;

namespace AlternativeStrategy.TemplatePattern
{
    public class MemoryRepo : AbstractTemplate
    {
        private List<PPerson> _persons;
        public MemoryRepo()
        {
            _persons = new List<PPerson>() { new PPerson(1, "Mogens"), new PPerson(2, "Jannik") };
        }
        public override PPerson Add(PPerson person)
        {
            _persons.Add(person);
            return person;
        }

        public override PPerson AddUser(PPerson person)
        {
            throw new NotImplementedException();
        }

        public override PPerson AddUserLogin(UserLogin userlogin)
        {
            throw new NotImplementedException();
        }

        public override List<PPerson> GetAllProducts()
        {
            return _persons;
        }

        public override List<PPerson> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public override PPerson Validate(PPerson person)
        {
            if(person.Id != 0 && person.Name != null)
            {
                return person;
            }
            return null;
        }

        public override UserLogin ValidateLogin(UserLogin userLogin)
        {
            throw new NotImplementedException();
        }
    }
}
