using QuizBattle.Application.Interfaces;
using QuizBattle.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizBattle.Application.Features.StartSession
{
    public sealed class StartQuizHandler
    {
        private readonly IQuestionRepository _questions;
        private readonly ISessionRepository _sessions;

        public StartQuizHandler(IQuestionRepository questions, ISessionRepository sessions)
        {
            _questions = questions;
            _sessions = sessions;
        }

        public async Task<StartQuizResult> Handle(StartQuizCommand cmd, CancellationToken ct)
        {
            if (cmd.QuestionCount <= 0)
            {
                throw new ArgumentException("Question count must be greater than zero.", nameof(cmd.QuestionCount));
            }

            var questions = await _questions.GetRandomAsync(
                cmd.Category,
                cmd.Difficulty,
                cmd.QuestionCount,
                ct);

            var sessionId = Guid.NewGuid();

            var result = new StartQuizResult(sessionId, questions);

            return result;
        }
    }
}
