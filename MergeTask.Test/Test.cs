using MergeTask.Project;
namespace MergeTask.Test
{
    public class SolutionTests
    {
        private static bool IsSorted(int[] row)
        {
            for (int i = 1; i < row.Length; i++)
            {
                if (row[i] < row[i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        private static int[] RandomRow()
        {
            Random rnd = new Random();
            int size = rnd.Next(10, 21);
            int[] row = new int[size];
            for (int i = 0; i < size; i++)
            {
                row[i] = rnd.Next(101);
            }
            return row;
        }
        ///<param name="amount">
        ///количество 
        ///</param>
        public static string RunTests(int amount)
        {
            if (amount < 1) throw new ArgumentException("amount of tests cannot be non-positive");
            string result = string.Empty;
            for (int i = 0; i < amount; i++)
            {
                int[] row = RandomRow();
                Solution.Sort(row, 0, row.Length);
                result += $"{IsSorted(row)} : {string.Join(" ", row)}\n";
            }
            return result;
        }
        public static string ReturnSortedRow()
        {
            int[] row = new int[] {2, 6, 3, 0, 4, 5, 1, 7};
            Solution.Sort(row, 0, row.Length);
            return string.Join(" ", row);
        }
    }
}
