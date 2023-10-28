using System.Runtime.CompilerServices;

namespace Searchs
{
    public class Search
    {
        public static int Binary(List<int> list, int target)
        {
            int inicio = 0;
            int final = list.Count - 1;
            int meio = 0;
            
            while (inicio <= final)
            {
                meio = (inicio + final) / 2;

                if (list[meio] == target)
                {
                    return meio;
                }

                if (list[meio] < target)
                {
                    inicio = meio + 1;
                }
                else
                {
                    final = meio - 1;
                }
            }
            

            return -1;
            
        }
        public static int CatchBinaryAttempts(List<int> list, int target)
        {
            int inicio = 0;
            int final = list.Count - 1;
            int meio = 0;
            int contBinary = 0;
        
            while (inicio <= final)
            {
                meio = (inicio + final) / 2;
                contBinary++;

                if (list[meio] == target)
                {
                    break;
                }

                if (list[meio] < target)
                {
                    inicio = meio + 1;
                }
                else
                {
                    final = meio - 1;
                }
            }
            return contBinary;
        }
        public static int Linear(List<int> list, int target)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == target)
                {
                    return i;
                }
            }
            
            return -1;
        }
        public static int CatchLinearAttempts(List<int> list, int target)
        {
            int contLinear = 1;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == target)
                {
                    break;
                }

                contLinear++;
            }
        
            return contLinear;
        }
    }
}