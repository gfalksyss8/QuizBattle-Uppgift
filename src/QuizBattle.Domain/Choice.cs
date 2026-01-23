
using System;

namespace QuizBattle.Domain
{
    public class Choice
    {
        public Choice(string code, string option)
        {
            Code = code;
            Text = option;
            EnsureValid();
        }

        protected Choice() { }// default konstruktor behövs av EF Core

        public int Id { get; set; } // PK för Choice
        public int QuestionId { get; set; } // FK för Question
        public Question Question { get; set; }
        public string Code { get; set; }
        public string Text { get; set; }

        private void EnsureValid()
        {
            if (string.IsNullOrWhiteSpace(Code))
            {
                throw new DomainException("Code must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(Text))
            {
                throw new DomainException("Text must not be null or empty.");
            }
        }
    }
}
