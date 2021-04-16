using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berdik_27._02._2021.Classes
{
    public delegate void Print(string text);
    public delegate string Read();
    class Book
    {
        public Book() { }

        public Book(string nameBook, string nameAuthor, 
            string genre, int countPages, 
            string namePublishingHouse, DateTime datePubl, string annotation)
        {
            NameBook = nameBook;
            Author = nameAuthor;
            Genre = genre;
            CountPages = countPages;
            NamePublishingHouse = namePublishingHouse;
            DatePublishing = datePubl;
            Annotation = annotation;
        }
        public static Print PrintInfo;
        public static Read ReadInfo;
        public string NameBook { get; private set; }
        public string Author { get; private set; }
        public string Genre { get; private set; }
        public int CountPages { get; private set; }
        public string NamePublishingHouse { get; private set; }
        public DateTime DatePublishing { get; private set; }
        public string Annotation { get; private set; }

        public void SetNameBook(string name)
        {
            NameBook = name;
        }

        public void SetNameAuthorBook(string name)
        {
            Author = name;
        }

        public void SetGenreBook(string genre)
        {
            Genre = genre;
        }

        public void SetAnnotationBook(string annotation)
        {
            Annotation = annotation;
        }

        public void SetDatePublBook(DateTime date)
        {
            DatePublishing = date;
        }

        public void SetCountPagesBook(int count)
        {
            CountPages = count;
        }

        public void SetNamePublishingHouseBook(string name)
        {
            NamePublishingHouse = name;
        }

        public bool ReadAndSetNameBook()
        {
            if (ReadInfo != null)
            {
                if (PrintInfo != null) PrintInfo("Введите название книги ");

                string text = ReadInfo();
                SetNameBook(text);

                return true;
            } else return false;
        }

        public bool ReadAndSetNameAuthorBook()
        {
            if (ReadInfo != null)
            {
                if (PrintInfo != null) PrintInfo("Введите имя автора книги ");

                string text = ReadInfo();
                SetNameAuthorBook(text);

                return true;
            }
            else return false;
        }

        public bool ReadAndSetGenreBook()
        {
            if (ReadInfo != null)
            {
                if (PrintInfo != null) PrintInfo("Введите жанр книги ");

                string text = ReadInfo();
                SetGenreBook(text);

                return true;
            }
            else return false;
        }

        public bool ReadAndSetAnnotationBook()
        {
            if (ReadInfo != null)
            {
                if (PrintInfo != null) PrintInfo("Напишите аннотацию к книге ");

                string text = ReadInfo();
                SetAnnotationBook(text);

                return true;
            }
            else return false;
        }

        public bool ReadAndSetDatePublBook()
        {
            if (ReadInfo != null)
            {
                if (PrintInfo != null) PrintInfo("Введите дату издания книги ");

                DateTime date = DateTime.Parse(ReadInfo());
                SetDatePublBook(date);

                return true;
            }
            else return false;
        }

        public bool ReadAndSetCountPagesBook()
        {
            if (ReadInfo != null)
            {
                if (PrintInfo != null) PrintInfo("Введите колисчество страниц в книге ");

                int count = Int32.Parse(ReadInfo());
                SetCountPagesBook(count);

                return true;
            }
            else return false;
        }

        public bool ReadAndSetNamePublishingHouseBook()
        {
            if (ReadInfo != null)
            {
                if (PrintInfo != null) PrintInfo("Введите название издателя книги ");

                string text = ReadInfo();
                SetNamePublishingHouseBook(text);

                return true;
            }
            else return false;
        }

        public string InfoBook()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("\nИнформация о данной книге");
            info.AppendLine($"Название книги - {NameBook}");
            info.AppendLine($"Написал эту книгу - {Author}");
            info.AppendLine($"Жанр книги - {Genre}");
            info.AppendLine($"В книги {CountPages} страниц");
            info.AppendLine($"Название издательства - {NamePublishingHouse}");
            info.AppendLine($"Книга была издана {DatePublishing.Day}-го числа в {DatePublishing.ToString("MMMM")} месяца и {DatePublishing.Year} года ");
            info.AppendLine($"Аннотация к книге - {Annotation}");

            string text = info.ToString();
            if (PrintInfo != null) PrintInfo(text);

            return text;
        }
    }
}
