using System;
using System.Text;

namespace Berdik_27._02._2021.Classes
{
    public delegate void Wrt(string text);
    public class Student
    {
        public Student() { }

        public Student(string fio, DateTime dateBerstDay, string groupName, string speacialName, int studTiclet)
        {
            FIO = fio;
            BerstDay = dateBerstDay;
            GroupName = groupName;
            SpeacialName = speacialName;
            StudTiclet = studTiclet;
        }
        public string FIO { get; set; }
        public DateTime BerstDay { get; set; }
        public string GroupName { get; set; }
        public string SpeacialName { get; set; }
        public int StudTiclet { get; set; }

        public static Wrt WriteTerminal;
        public void SetFIO(string fio)
        {
            FIO = fio;
        }

        public void SetBerstDay(DateTime date)
        {
            BerstDay = date;
        }

        public void SetGroupName(string name)
        {
            GroupName = name;
        }

        public void SetSpeacialName(string name)
        {
            SpeacialName = name;
        }

        public void SetStudTiclet(int number)
        {
            StudTiclet = number;
        }

        public string Info()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine("\nИнформация о студенте");
            info.AppendLine($"Имя - {FIO}");
            info.AppendLine($"Группа - {GroupName}");
            info.AppendLine($"Специальность - {SpeacialName}");
            info.AppendLine($"День рождения - {BerstDay}");
            info.AppendLine($"Номер студенческого билета - {StudTiclet}");

            string text = info.ToString();
            if (WriteTerminal != null) WriteTerminal(text);

            return text;
        }

    }
}
