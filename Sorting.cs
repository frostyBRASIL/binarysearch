namespace Sorting
{
    class Sort
    {
        public static List<int> Bubble(List<int> list)
        {
            bool sorted = false;
            int n = list.Count;

            while (!sorted)
            {
                sorted = true;
                for (int i = 1; i < n; i++)
                {
                    if (list[i - 1] > list[i])
                    {
                        int aux = list[i - 1];
                        list[i - 1] = list[i];
                        list[i] = aux;
                        sorted = false;
                    }
                }
                n--;
            }

            return list;
        }
    }
}