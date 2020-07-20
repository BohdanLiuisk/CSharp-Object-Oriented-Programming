using System;

namespace User
{
    class User
    {
        string login, name, familyName;
        int age;
        public readonly DateTime date;

        public string Login
        {
            set { login = value; }
            get
            {
                if (login == null)
                    return "The field is not filled";
                return login;
            }
        }

        public string Name
        {
            set { name = value; }
            get
            {
                if (name == null)
                    return "The field is not filled";
                return name;
            }
        }

        public string FamilyName
        {
            set { familyName = value; }
            get
            {
                if (familyName == null)
                    return "The field is not filled";
                return familyName;
            }
        }

        public int Age
        {
            set { age = value; }
            get
            {
                if (age <= 0)
                    return 25;
                return age;
            }
        }
        public User()
        {
            date = DateTime.Now;
        }

        public User(string login, string name, string familyname, int old)
        {
            this.login = login;
            this.name = name;
            this.familyName = familyname;
            this.age = old;
            date = DateTime.Now;
        }
    }
}
