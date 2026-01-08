using QuizBattle.Console;

QuestionUtils.SeedQuestions();

Console.WriteLine("Welcome to Quiz Battle!");

Console.WriteLine("Quiz Battle regler:");
Console.WriteLine("Svara på frågor korrekt för att tjäna poäng.");

while (!QuestionUtils.IsCompleted())
{
    QuestionUtils.DisplayQuestion();
    int answer = QuestionUtils.GetAnswer();

    QuestionUtils.CheckAnswer(answer);

    QuestionUtils.WriteStatus();
}

Console.WriteLine("Tack för att du spelade Quiz Battle!");
