using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Office
    {

        public delegate void VisitDelegate(Person p);
        public event VisitDelegate Coming;
        public event VisitDelegate Leaving;

        private readonly List<Person> employees = new List<Person>();

        public void NoteComing(Person p)
        {
            SayHi(p);
            employees.Add(p);
        }

        public void NoteLeaving(Person p)
        {
            employees.Remove(p);
            SayBy(p);
        }

        public void SayBy(Person p)
        {
            foreach (Person pers in employees) Leaving += pers.SayBye;
            Console.WriteLine("Ушел " + p.Name);
            Say(p, Leaving);
            Leaving = null;
        }

        public void SayHi(Person p)
        {          
            foreach (Person pers in employees) Coming += pers.SayHi;
            Console.WriteLine("Пришел " + p.Name);
            Say(p, Coming);
            Coming = null;
        }

        public void Say(Person p, VisitDelegate d)
        {
            if (d is null) return;
            Console.WriteLine(new string('-', 20));
            d(p);
            Console.WriteLine(new string('-', 20));
        }
    }
}
