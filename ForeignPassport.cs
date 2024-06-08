

namespace ConsoleApp32
{
    internal class ForeignPasport
    {
        public string num;
        public string name;
        public string date;

        public void Passport(string pNumber, string fName, string iDate)
        {
            this.num = pNumber;
            this.name = fName;
            this.date = iDate;
        }
        public override string ToString()
        {
            return $"Num: {num}, Name: {name}, Date: {date}";
        }
    }
}
