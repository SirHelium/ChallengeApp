namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int Count { get; private set; }
        public float Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public char AverageLetter
        {
            get
            {
                switch (Average)
                {
                    case var average when average >= 80:
                        return 'A';
                    case var average when average >= 60:
                        return 'B';
                    case var average when average >= 40:
                        return 'C';
                    case var average when average >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }

        }
        public Statistics()
        {
            Count = 0;
            Sum = 0;
            Max = float.MinValue;
            Min = float.MaxValue;
        }

        public void AddGrade(float grade)
        {
            Count++;
            Sum += grade;
            Min = Math.Min(Min, grade);
            Max = Math.Max(Max, grade);
        }

    }
}
