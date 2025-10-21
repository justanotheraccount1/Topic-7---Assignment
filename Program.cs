namespace Topic_7___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            List<int> nums = new List<int>();

            for (int i = 0; i <= 25; i++)
            {
                nums.Add(generator.Next(10, 21));
            }
            Console.WriteLine("Here is the list of numbers:");
            for (int i = 0; i <= 25; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
