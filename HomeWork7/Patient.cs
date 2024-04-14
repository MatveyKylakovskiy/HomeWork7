

namespace HomeWork7
{
    public class Patient
    {
        public string Name;
        public int Age;
        public TypeOfTreatment TypeOfTreatment { get; set; }
        

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");

            var typeOfTreatment = new TypeOfTreatment(TypeOfTreatment.NumberOfTreatment);
            var NumberOfTreatment = typeOfTreatment.NumberOfTreatment;
            var doc = typeOfTreatment.ChoiceOfTreatment(NumberOfTreatment);
            doc.ToHeal(doc);
        }
    }

}
