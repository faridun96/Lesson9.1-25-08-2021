using System;

namespace EmployeeApp
{
    enum Position
    {
        Junior, Middle, Senior
    }
    class Employee
    {
        private string name;
        private string surname;
        private Position position;
        private int experience;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public Position Position
        {
            get { return position; }
            set { position = value; }
        }
        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }
        public Employee(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public void CalculateSalary()
        {
            if (position == Position.Junior)
                Console.WriteLine("Зарплата с {0}-летным опытом работы на должности Junior C# разработчик:\n5000 + {1}(от 12 месяцев и до 5 лет включительно надбавка 10% к зарплате) - {2}(13% налог + 1% пенсионный фонд) = {3} сомони",
                    experience, 5000 * experience * 0.05, 5000 * experience/2 * 1.1/100*14, 5500 * experience/2 * 0.86);
            else if (position == Position.Middle)
                Console.WriteLine("Зарплата с {0}-летным опытом работы на должности Middle C# разработчик:\n10000 + {1}(от 5 лет и до 10 лет включительно надбавка 15% к зарплате) - {2}(13% налог + 1% пенсионный фонд) = {3} сомони",
                    experience, 10000 * experience * 0.03, 10000 * experience/2 * 0.46/100*14, 11500 * experience/2 * 0.344);
            else
                Console.WriteLine("Зарплата с {0}-летным опытом работы на должности Senior C# разработчик:\n20000 + {1}(от 10 лет и до 15 лет включительно надбавка 20% к зарплате) - {2}(13% налог + 1% пенсионный фонд) = {3} сомони",
                    experience, 20000 * experience * 0.02, 20000 * experience/2 * 0.24/100*14, 20000 * experience/2 * 0.2064);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee a = new Employee("Фаридун", "Худойкулов");
            a.Position = Position.Junior;
            a.Experience = 2;
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nДолжность: {2} C# разработчик", a.Name, a.Surname, a.Position);
            a.CalculateSalary();
            Employee b = new Employee("Мухаммад", "Давлатов");
            b.Position = Position.Middle;
            b.Experience = 5;
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nДолжность: {2} C# разработчик", b.Name, b.Surname, b.Position);
            b.CalculateSalary();
            Employee c = new Employee("Азизджон", "Муминов");
            c.Position = Position.Senior;
            c.Experience = 10;
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nДолжность: {2} C# разработчик", c.Name, c.Surname, c.Position);
            c.CalculateSalary();
        }
    }
}
