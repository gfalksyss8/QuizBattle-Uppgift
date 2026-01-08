using QuizBattle.Domain;

namespace QuizBattle.Console;

public class QuestionUtils
{
    private static List<Question> _questions = new();

    public static bool IsCompleted()
    {
        throw new NotImplementedException();
    }

    public static void DisplayQuestion()
    {
        throw new NotImplementedException();
    }

    public static int GetAnswer()
    {
        throw new NotImplementedException();
    }

    public static void CheckAnswer(int answer)
    {
        throw new NotImplementedException();
    }

    public static void WriteStatus()
    {
        throw new NotImplementedException();
    }

    public static void SeedQuestions()
    {
        Choice[] choices = {
                new Choice("Q1.1", "Två ben"),
                new Choice("Q1.2", "Tre ben"),
                new Choice("Q1.3","Fyra ben")
        };
        _questions.Add(new Question("Hur många ben har en hund?", choices, "Q1.3"));
        Choice[] choices2 = {
            new Choice("Q2.1", "Fyra ben"),
            new Choice("Q2.2", "Åtta ben"),
            new Choice("Q2.3", "Tio ben"),
            new Choice("Q2.4", "Tolv ben")
        };
        _questions.Add(new Question("Hur många ben har en spindel?", choices2, "Q2.2"));
    }
}
