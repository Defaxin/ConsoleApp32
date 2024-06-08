
namespace ConsoleApp32
{
    class NumberConverter
    {
        public static string DecimalTo(int num)
        {
            return Convert.ToString(num, 2);
        }

        public static int ToDecimal(string num)
        {
            return Convert.ToInt32(num, 2);
        }
    }
}
