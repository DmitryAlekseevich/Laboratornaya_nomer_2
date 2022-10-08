using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Person person = new Person();
        }
    }

    class Person
    {
        private

        string _name; //закрытое поле string. имя
        string _lastName; //закрытое поле string. фамилия
        System.DateTime _birhtDate;//закрытое поле System.DateTime. дата рождения

        //конструктор c тремя параметрами типа string, string, DateTime для инициализации всех полей класса
        public Person(string studentName, string studentLastName, DateTime studentBDate)
        {
            _name = studentName;
            _lastName = studentLastName;
            _birhtDate = studentBDate;
        }

        //конструктор без параметров, инициализирующий все поля класса некоторыми значениями по умолчанию.
        public Person() : this("Default_Name", "Default_Sname", new DateTime(2000, 06, 29))
        { }

        //Св-ва get u set
        string FirstName //sv-vo tipa string dla dostupa k poooly s imenami
        {
            get
            {
                return _name;
            }
        }
        string LastName //СВ-ВО ТИПА стринг для доступа к полю с фамилией
        {
            get
            {
                return _lastName;
            }
        }
            DateTime BirthDate //свойство типа дататайме для доступа к полю с моей датой рождения
            {
                get
                {
                   return _birhtDate;
                }
            }
        }
        int intStdBdate //свойство типа int с методами get set для получения информации get и изменения set
                {
                get
                {
                   return Convert.Tolnt32(BDate);
                }
                set
                {
                   BDate = Convert.ToDateTime(value);
                }

    }
    public string ToShortString() // метод который возвращает строку с Именем и Фамилией
    {
        return "n" + "Имя: " + Name + "n" + "Фамилия: " + LastName; // выводим все значения
    }
}
