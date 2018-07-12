using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Person
    {
        public Person(string name)
        {
            this.Name = name;
        }

        public void SayHi(Person person)
        {
            string time = RandomTimeUtils.getAsString();
            string welcomeForm = WelcomeFormUtils.GetFormByTime(time);
            Console.WriteLine("{0} сказал в {1}: '{2}, {3}!'", Name, time, welcomeForm, person.Name);
        }

        public void SayBye(Person person)
        {
            Console.WriteLine("{0} сказал: 'До свидания, {1}!'", Name, person.Name);
        }

        public string Name { get; }
    }
}
