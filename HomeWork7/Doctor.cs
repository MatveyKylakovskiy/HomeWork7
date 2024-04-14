
namespace HomeWork7
{
    public class Doctor
    {
        public virtual void ToHeal(Doctor doctor)
        {

        }
    }
    public class Surgeon: Doctor
    {
        public override void ToHeal(Doctor doctor)
        {
            Console.WriteLine($"You are being treated by a surgeon.\n");
        }
    }

    public class Therapist: Doctor
    {
        public override void ToHeal(Doctor doctor)
        {
            Console.WriteLine($"You are being treated by a therapist.\n");
        }
    }
    public class Dentist : Doctor
    {
        public override void ToHeal(Doctor doctor)
        {
            Console.WriteLine($"You are being treated by a dentist.\n");
        }
    }

}





/*Создать программу для имитации работы клиники.
Пусть в клинике будет три врача: хирург, терапевт и дантист.
Каждый врач имеет метод «лечить», но каждый врач лечит по-своему. Так же
предусмотреть класс «Пациент» и класс «План лечения». Создать объект класса
«Пациент» и добавить пациенту план лечения. Так же создать метод, который
будет назначать врача пациенту согласно плану лечения.
Если план лечения имеет код 1 – назначить хирурга и выполнить метод лечить.
Если план лечения имеет код 2 – назначить дантиста и выполнить метод лечить.
Если план лечения имеет любой другой код – назначить терапевта и выполнить
метод лечить.*/