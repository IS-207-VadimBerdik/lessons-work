using System;
using System.IO;
using Berdik_27._02._2021.Classes;

namespace Berdik_27._02._2021

// 27.02.2021
// 10.03.2021
// 11.03.2021
// 12.03.2021
// 17.03.2021
{
    class Program
    {
        public delegate string ReadTerminal();
        public delegate void WriteTerminal(string str);
        static void Main(string[] args)
        {
            StreamWork();
            Console.ReadKey();
        }

        static void StreamWork(string dirName = "", string fileName = "FileProgram.txt")
        {
            WriteTerminal write = new WriteTerminal(Console.WriteLine);

            string str = "С другой стороны постоянный количественный рост и сфера нашей активности способствует повышению актуальности модели развития.\nРазнообразный и богатый опыт повышение...";
            string fullName = dirName + fileName;

            Stream stream = File.Open(fullName, FileMode.OpenOrCreate);

            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine(str);
            writer.Close();

            StreamReader reader = new StreamReader(fullName);
            write(reader.ReadToEnd());
            reader.Close();
        }
        void fun_1()
        {
            ReadTerminal read = new ReadTerminal(Console.ReadLine);

            // Work with student

            Student stud_1 = new Student();
            stud_1.FIO = "Бердик Вадим";
            stud_1.GroupName = "ИС - 207";
            stud_1.SpeacialName = "Специалист по информационной системе";
            stud_1.BerstDay = new DateTime(2003, 7, 21);
            stud_1.StudTiclet = 123;

            Console.WriteLine("Информация о студенте №1");
            Console.WriteLine($"Имя - {stud_1.FIO}");
            Console.WriteLine($"Группа - {stud_1.GroupName}");
            Console.WriteLine($"Специальность - {stud_1.SpeacialName}");
            Console.WriteLine($"День рождения - {stud_1.BerstDay.ToShortDateString()}");
            Console.WriteLine($"Номер студенческого билета - {stud_1.StudTiclet}");

            Student stud_2 = new Student();

            Console.WriteLine("\nВведите информацию о студенте №2");

            Console.Write("Имя студента - ");
            stud_2.FIO = read();

            Console.Write("Название группы - ");
            stud_2.GroupName = read();

            Console.Write("Название специальности - ");
            stud_2.SpeacialName = read();

            Console.Write("День рождения - ");
            stud_2.BerstDay = DateTime.Parse(read());

            Console.Write("Номер студенческого билета - ");
            stud_2.StudTiclet = int.Parse(read());

            Console.WriteLine(stud_2.Info());

            Student.WriteTerminal += Console.WriteLine;

            Student stud_3 = new Student();

            Console.WriteLine("\nВведите информацию о студенте №3");

            Console.Write("Имя студента - ");
            string fio = read();
            stud_3.SetFIO(fio);

            Console.Write("Название группы - ");
            string groupName = read();
            stud_3.SetGroupName(groupName);

            Console.Write("Название специальности - ");
            string speacialName = read();
            stud_3.SetSpeacialName(speacialName);

            Console.Write("День рождения - ");
            DateTime berstDay = DateTime.Parse(read());
            stud_3.SetBerstDay(berstDay);

            Console.Write("Номер студенческого билета - ");
            int studTiclet = int.Parse(read());
            stud_3.SetStudTiclet(studTiclet);

            stud_3.Info();

            // Work with book

            Book.PrintInfo += Console.Write;
            Book.ReadInfo += Console.ReadLine;

            Book book_1 = new Book();
            book_1.SetNameBook("Стратегические игры");
            book_1.SetNameAuthorBook("Сьюзан Скит");
            book_1.SetGenreBook("Психология");
            book_1.SetCountPagesBook(1000);
            book_1.SetNamePublishingHouseBook("W.W.Norton&Company");
            book_1.SetDatePublBook(new DateTime(2017, 01, 01));
            book_1.SetAnnotationBook("Эта книга является логическим продолжением книги 'Теории игр' Авинаша Диксима и Барри Нейлбаффа");

            Book book_2 = new Book("Внутри убийцы", "Майк Омер", "Детектив", 340, "LiveLib", new DateTime(2018, 01, 01),
                "Профайлер... Криминальный психолог, буквально по паре незначительных деталей может воссоздать облик и образ самого хитроумного преступника");

            Book book_3 = new Book();
            book_3.ReadAndSetNameBook();
            book_3.ReadAndSetNameAuthorBook();
            book_3.ReadAndSetGenreBook();
            book_3.ReadAndSetCountPagesBook();
            book_3.ReadAndSetNamePublishingHouseBook();
            book_3.ReadAndSetDatePublBook();
            book_3.ReadAndSetAnnotationBook();

            book_1.InfoBook();
            book_2.InfoBook();
            book_3.InfoBook();

        }
    }
}
