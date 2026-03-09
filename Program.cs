namespace Exercise_Ch12_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.Write("請輸入測試整數值=>");
            userInput = Console.ReadLine() ?? "0";
            int value = Convert.ToInt32(userInput);
            try
            {
                Console.WriteLine("例外處理開始");
                // 丟出ArithmeticException例外
                if (value < 10)
                    throw new ArithmeticException("值小於10");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("程式錯誤: " + ex.ToString());
            }
            finally
            {
                Console.WriteLine("例外處理結束:" + value);
            }
            Console.Read();
        }
    }
}
