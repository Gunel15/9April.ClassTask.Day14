using _9AprilClassTaskDay14.Models;

namespace _9AprilClassTaskDay14
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    List<Quiz> quizzes= new List<Quiz>();
        begin:

            Console.WriteLine("Menyunun elementləri \r\n\r\n1. Create new quiz\r\n2. Solve a quiz\r\n3. Show quizzes\r\n0. Quit");
            string text = Console.ReadLine();


            switch (text)

            {
                case "1":
                    Console.WriteLine("Add quiz name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("How many questions do you want to add?");
                    int n = int.Parse(Console.ReadLine());
                    List<Question> newQuestion = new List<Question>();
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Enter questions:");
                        string title = Console.ReadLine();
                        List<string> newVariants = new List<string>();
                        for (int j = 0; j < 4; j++)
                        {
                            Console.WriteLine("Variantlari daxil edin:");
                            newVariants.Add(Console.ReadLine());
                        }
                        Console.WriteLine("Duzgun variant No:");
                        int correct=int.Parse(Console.ReadLine());
                        Question question = new Question(title, newVariants, correct);
                        newQuestion.Add(question);
                        Console.WriteLine("Question succesfully added!");

                    }
                    Quiz quizz=new Quiz(name,newQuestion);
                    quizzes.Add(quizz);
                    break;
            }

        }





    }
}
