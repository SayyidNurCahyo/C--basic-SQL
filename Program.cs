namespace IntegerSequenceFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n <= 0) throw new Exception();
                No1.OKYES(n);
                No2.A(n);
                No2.B(n);
                No2.C(n);
                No2.D(n);
            } catch (Exception ex)
            {
                Console.WriteLine("input tidak valid");
            }

            int[] array = { 12, 9, 13, 6, 10, 4, 7, 2 };
            No3.Array(array);
        }
    }
}
