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
            ResearchTeam std = new ResearchTeam(); //Создать один объект типа ResearchTeam
            Console.WriteLine(std.ToShortString()); //Преобразовать данные в текстовый вид с помощью метода ToShortString() и вывести данные

            // Присвоил значения всем определенным в типе ResearchTeam
            public string a = Tema { get; set; }
            public string b = nameorg { get; set; }
            public int с = namereg { get; set; }
            public TimeFrame d = infaprodisled { get; set; }

            // Преобразую в текстовый вид, и вывожу
            string str = Convert.ToString(a b c d);
            Console.WriteLine(str);
            Console.ReadLine();

            sms.AddPaper(publication params Paper [a, b, c, d]); //добавил элементы в список публикации

            public Paper(string a, string b, int c, TimeFrame d) //вывод данных объекта ResearchTeam
            {
                this.a = Tema;
                this.b = nameorg;
                this.c = namereg;
                this.d = infaprodisled;
            }
           

            Console.WriteLine("Кто ушел не выключив компьютер, тот Дмитрий :'( Не делайте так больше");
            Person person = new Person();
            Paper p = new Paper("Влияние войны и мира на...", new Person(), new DateTime(2010, 10, 10));
        }
    }

    class Person
    {
    //Значение свойства, которое возвращает ссылку на публикацию с самой поздней датой выхода, если список публикаций пустой
    private Program[] publications;
        public Program LatestPublication
    {
        get
        {
            if (publications == null || publications.Length == 0) return null;

            Program latestPublication = publications[0];
            for (int i = 1; i < publications.Length; i++)
                if (publications[i].PublishDate > latestPublication.PublishDate)
                    latestPublication = publications[i];
            return latestPublication;
        }

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
                return BirthDate.Year;
            }
            set
            {
               /// BDate = Convert.ToDateTime(value);
            }
        }

        public string ToShortString()
        {
            return "n" + "Имя: " + FirstName + "n" + "Фамилия: " + LastName;
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

        private Paper() : this("что то должно быть", new Person(), new DateTime(2000, 06, 29))
        {

        }
        public string ToFullString()
        {
            return string.Format("Autor {0} Kniga {1}. Data = {2}", NamePublic, Autor, Data);
        }
    }

    class ResearchTeam
    {
        private string Tema; //закрытое поле типа string c названием темы исследований
        private string NameOrg; //закрытое поле типа string с названием организации
        private int NomerReg; //закрытое поле типа int - регистрационный номер
        private TimeFrame InfaProdIsled; //закрытое поле типа TimeFrame для информации о продолжительности ис-след
        private InfaProdIsled<Paper> _publications = new InfaProdIsled<Paper>(); //закрытое поле типа Paper[]


        //В классе ResearchTeam определить конструкторы
        //Конструктор c параметрами типа string, string, int, TimeFrame для инициализации соответствующих полей класса

        public ResearchTeam(string Tema, string NameOrg, int NomerReg, TimeFrame InfaProdIsled)
        {
            Tema = Tema;
            NameOrg = nameorg;
            NomerReg = namereg;
            InfaProdIsled = infaprodisled;

        }

        //Конструктор без параметров, инициализирующий поля класса значениями по умолчанию
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

        //Cвойство типа Paper[] для доступа к полю со списком публикаций по те-ме исследований
        public IReadOnlyList<Paper> Publications
        {
            get
            {
                return _publications.AsReadOnly();
            }
        }

        //Cвойство типа Paper ( только с методом get) которое возвращает ссылку на публикацию с самой поздней датой выхода; а если что, null
        public double ListPublic
        {
            get
            {
                return null;
            }
        }

        //Метод void AddPapers ( params Paper[] ) для добавления элементов в список публикаций

        public void AddPapers(params Paper[] p)
        {
            _publications.AddRange();
        }


        //метод string ToFullString() для фор-мирования строки со значениями всех полей класса, включая список пуб-ликаций
        public override string ToFullString()
        {
            return string.Format("\nTheme: {0}\nNameOfOrg: {1}\nNumberOfRed: {2}\nLast: {3}\nPublications: {4} ", Theme, NameOfOrg, NumberOfRed, Last, _publications);
        }

        //Метод string ToShortString(), который формирует строку со значениями всех полей класса без списка публикаций
        public string ToShortString() // виртуальный метод который формирует строку со значениями всех полей класса без списка экзаменов, но со значением среднего балла.
        {
            return string.Format("\nTema: {0}\nNameorg: {1}\nNomerReg: {2}\nInfaProdIsled: {3}\n", Tema, Nameorg, NomerReg, InfaProdIsled);
        }
    }
}
