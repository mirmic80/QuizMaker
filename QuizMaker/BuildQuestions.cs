namespace QuizMaker
{
    public class BuildQuestions
    {
        public int QuestioNumber;
        public string QuestioOutput;
        public string CorrectAnswer;
        public AnswersPossibilities thePossibilities = new AnswersPossibilities();
    }
    public class AnswersPossibilities
    {
        public string FirstPossibleAnswer;
        public string SecondPossibleAnswer;
        public string ThirdPossibleAnswer;
        public string FourthPossibleAnswer;
    }
}
