namespace Lists
{
    public class List
    {
        public static List<int> Random(int n)
        {
            var list = new List<int>();
            Random x = new Random();

            for (int i = 0; i < n; i++)
            {
                list.Add(x.Next(2500));
            }
            
            return list;
        }
        public static void ShowList(List<int> list)
        {
            Console.WriteLine("Os elementos na lista são:");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}