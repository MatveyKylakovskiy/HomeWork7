
namespace HomeWork7
{
    public class TypeOfTreatment
    {
        public int NumberOfTreatment;

        public Doctor ChoiceOfTreatment(int NumberOfTreatment)
        {
          switch(NumberOfTreatment)
            {
                case 1:
                    return new Surgeon();
                case 2:
                    return new Dentist();
                default:
                    return new Therapist();
            }

        }

        public TypeOfTreatment(int NumberOfTreatment)
        {
            this.NumberOfTreatment = NumberOfTreatment;
        }
    }
}
