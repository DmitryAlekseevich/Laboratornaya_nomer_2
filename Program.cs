using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            ResearchTeam std = new ResearchTeam(); //Один объект типа ResearchTeam
            Console.WriteLine(std.ToShortString()); //Преобразовать данные в текстовый вид с помощью метода ToShortString() и вывести данные
        }
    }

    class Person
    {
        private

        string Name; //закрытое поле string. имя
        string LastName; //закрытое поле string. фамилия
        System.DateTime BDate;//закрытое поле System.DateTime. дата рождения


        
    }
}