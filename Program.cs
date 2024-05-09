namespace learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, -3, 4, -5, 6, 7, -8, 9 };

/*trying to iterate >> even nums "foreach" >> iterate one item for resule then return implement even num for each on it and so on????? */


            IEnumerable<int> result = list.Filter(x => x > 0);      
            IEnumerable<int> evenNumbers = result.Filter(x => x % 2 == 0); 

            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
