

namespace ConsoleApp32
{
    internal class Class1
    {
        public static bool Evaluate(string exp)
        {
            string[] parts = exp.Split(' ');
            if (parts.Length != 3)
            {
                throw new ArgumentException("ERROR");
            }
            int op1 = int.Parse(parts[0]);
            string oper = parts[1];
            int op2 = int.Parse(parts[2]);
            switch (oper)
            {
                case "<":
                    return op1 < op2;
                case ">":
                    return op1 > op2;
                case "<=":
                    return op1 <= op2;
                case ">=":
                    return op1 >= op2;
                case "==":
                    return op1 == op2;
                case "!=":
                    return op1 != op2;
                default:
                    throw new ArgumentException("ERROR");
            }
        }
    }
}
