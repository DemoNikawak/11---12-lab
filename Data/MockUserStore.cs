using lab9_WebDriver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_WebDriver.Data
{
    public class MockUserStore
    {
        public static UserModel GetDefaultUser()
        {
            var user = new UserModel() { Name = "Никита Врублевский", Phone = "+375298822499", Password = "qwerty12345"};
            return user;
        }

        public static IEnumerable<UserModel> GetAllUsers()
        {
            yield return new UserModel() { Name = "Никита Врублевский", Phone = "+375298822499", Password = "qwerty12345" };
            yield return new UserModel() { Name = "Надежда Бичун", Phone = "+375333257196", Password = "12345" };
            yield return new UserModel() { Name = "Вадим Калистратов", Phone = "+375293399882", Password = "f1dm23mla" };
            yield return new UserModel() { Name = "Алексей Симакин", Phone = "+375297849572", Password = "switch12" };
            yield return new UserModel() { Name = "Данила Радивил", Phone = "+375297465387", Password = "danila88hours" };
        
        }
    }
}
