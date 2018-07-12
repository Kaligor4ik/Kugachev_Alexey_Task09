using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task02.Person;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person igor = new Person("Игорь");
            Person vlad = new Person("Влад");
            Person roma = new Person("Рома");

            Office of = new Office();

            of.NoteComing(igor);
            of.NoteComing(vlad);
            of.NoteComing(roma);
            of.NoteComing(vlad);
            of.NoteComing(roma);

            of.NoteLeaving(roma);
            of.NoteLeaving(roma);
            of.NoteLeaving(vlad);
            of.NoteLeaving(vlad);
            of.NoteLeaving(igor);

            Console.ReadKey();
        }
    }
}
