using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Person
    {
        private

        string Name; //закрытое поле string. имя
        string LastName; //закрытое поле string. фамилия
        System.DateTime BDate;//закрытое поле System.DateTime. дата рождения

        //конструктор c тремя параметрами типа string, string, DateTime для инициализации всех полей класса
        public Person(string studentName, string studentLastName, DateTime studentBDate)
        {
            Name = studentName;
            LastName = studentLastName;
            BDate = studentBDate;
        }

        //конструктор без параметров, инициализирующий все поля класса некоторыми значениями по умолчанию.
        public Person() : this("Default_Name", "Default_Sname", new DateTime(2000, 06, 29))
        { }

        //Св-ва get u set
        string StdName //sv-vo tipa string dla dostupa k poooly s imenami
        {
            get
            {
                return Name;
            }
        }
        string StdLastName //СВ-ВО ТИПА стринг для доступа к полю с фамилией
        {
            get
            {
                return LastName;
            }
        }
            DateTime StdBDate //свойство типа дататайме для доступа к полю с моей датой рождения
            {
                get
                {
                   return BDate;
                }
            }
        }
    }
}