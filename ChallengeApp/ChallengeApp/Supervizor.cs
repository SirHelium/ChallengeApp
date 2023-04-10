namespace ChallengeApp
{
    internal class Supervizor : IEmployee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }

        private List<float> grades = new List<float>();

        public Supervizor(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public void AddGrade(float grade)
        {
            throw new NotImplementedException("Incorrect grade");
        }
        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    grades.Add(100);
                    break;
                case "6-" or "-6":
                    grades.Add(95);
                    break;
                case "5+" or "+5":
                    grades.Add(85);
                    break;
                case "5":
                    grades.Add(80);
                    break;
                case "5-" or "-5":
                    grades.Add(75);
                    break;
                case "4+" or "+4":
                    grades.Add(65);
                    break;
                case "4":
                    grades.Add(60);
                    break;
                case "4-" or "-4":
                    grades.Add(55);
                    break;
                case "3+" or "+3":
                    grades.Add(45);
                    break;
                case "3":
                    grades.Add(40);
                    break;
                case "3-" or "-3":
                    grades.Add(35);
                    break;
                case "2+" or "+2":
                    grades.Add(25);
                    break;
                case "2":
                    grades.Add(20);
                    break;
                case "2-" or "-2":
                    grades.Add(15);
                    break;
                case "1":
                    grades.Add(0);
                    break;
                default:
                    throw new Exception("Incorrect grade");
            }
        }
        public void AddGrade(char grade)
        {
            throw new NotImplementedException("Incorrect grade");
        }

        public void AddGrade(double grade)
        {
            throw new NotImplementedException("Incorrect grade");
        }
        public void AddGrade(long grade)
        {
            throw new NotImplementedException("Incorrect grade");
        }
        public void AddGrade(int grade)
        {
            throw new NotImplementedException("Incorrect grade");
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average = statistics.Average / this.grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
            return statistics;
        }
    }
}
