using MergeTask.Test;
using MergeTask.Project;
namespace MergeTask.ConsoleProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            string result = SolutionTests.RunTests(10);
            Console.WriteLine(result);
            Console.WriteLine(SolutionTests.ReturnSortedRow());
        }
    }
}