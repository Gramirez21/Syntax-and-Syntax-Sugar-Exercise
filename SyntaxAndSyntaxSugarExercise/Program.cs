namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;

            var response = (answer > 9)
            ? $"{answer} is greater"
            : $"{answer} is lower";
        }
    }
}
