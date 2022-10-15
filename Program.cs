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
		Console.WriteLine("Кто ушел не выключив компьютер, тот Дмитрий :'( Не делайте так больше");
            Person person = new Person();
            Paper p = new Paper("Влияние войны и мира на...", new Person(), new DateTime(2010, 10, 10));
        }
    }

    class Person
    {
        string _name;
        string _lastName;
        DateTime _birhtDate;

        /// <summary>
        /// конструктор c тремя параметрами типа string, string, DateTime для инициализации всех полей класса
        /// </summary>
        /// <param name="studentName"></param>
        /// <param name="studentLastName"></param>
        /// <param name="studentBDate"></param>
        public Person(string studentName, string studentLastName, DateTime studentBDate)
        {
            _name = studentName;
            _lastName = studentLastName;
            _birhtDate = studentBDate;
        }

        /// <summary>конструктор без параметров, инициализирующий все поля класса некоторыми значениями по умолчанию.</summary>
        public Person() : this("Default_Name", "Default_Sname", new DateTime(2000, 06, 29))
        { }


        string FirstName
        {
            get
            {
                return _name;
            }
        }
        string LastName
        {
            get
            {
                return _lastName;
            }
        }
        DateTime BirthDate
        {
            get
            {
                return _birhtDate;
            }
        }
        int intStdBdate
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

        public string ToShortString()
        {
            return "n" + "Имя: " + Name + "n" + "Фамилия: " + LastName;
        }
    }

    class Paper
    {
        public

        string NamePublic

        { get; set; }

        Person Autor

        { get; set; }

        DateTime Data

        { get; set; }

        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="NamePublic">название публикации</param>
        /// <param name="Autor">автор публикации</param>
        /// <param name="Data">дата чего то</param>
        public Paper(string NamePublic, Person Autor, DateTime Data)
        {
            this.NamePublic = NamePublic;
            this.Autor = Autor;
            this.Data = Data;
        }

        private Paper() : this("что то должно быть", "и еще что то", new DateTime(2000, 06, 29))
        {

        }
        public override string ToFullString()
        {
            return string.Format("Autor {0} Kniga {1}. Data = {2}", NameP, Autor, Data);
        }
    }
    class ResearchTeam
    {
        private string Tema;
        private string NameOrg;
        private int NomerReg;
        private TimeFrame InfaProdIsled;
        private InfaProdIsled<Paper> _publications = new InfaProdIsled<Paper>();

        public ResearchTeam(string Tema, string NameOrg, int NomerReg, TimeFrame InfaProdIsled)
        {
            Tema = Tema;
            NameOrg = nameorg;
            NomerReg = namereg;
            InfaProdIsled = infaprodisled;

        }

        public ResearchTeam()
           : this(new Person("Что то", "Еще что то", 0123456789, new TimeFrame(10), Paper.Spe * *t, 1))
        {

        }

        public string Tema
        {
            get
            {
                return Tema;
            }
        }

        public string nameorg
        {
            get
            {
                return Nameorg;
            }
        }

        public int namereg
        {
            get
            {
                NomerReg;
            }
        }

        public TimeFrame infaprodisled
        {
            get
            {
                return InfaProdIsled;
            }
        }

        public IReadOnlyList<Paper> Publications
        {
            get
            {
                return _publications.AsReadOnly();
            }
        }

        public double ListPublic
        {
            get
            {
                return null;
            }
        }
    }
}
