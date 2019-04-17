using System;

namespace Lab3_Mysko.Models
{
    class UserInputModel
    {
        public UserInputModel(Storage data)
        {
            Data = data;
        }

        public Storage Data { get; }

        public bool IsBirthDay()
        {
            if (Data.User == null)
                return false;
            return Data.User.IsBirthDay;
        }

        public void SetUser(string name, string surname, string email, DateTime birthday)
        {
            Data.ChangeUser(new Person(name, surname, email, birthday));
        }
    }
}