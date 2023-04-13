using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    public interface IEmployee
    {
        event GradeAddedDelegate GradeAdded;
        string Name { get; }
        string Surname { get; }
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(string grade);
        void AddGrade(char grade);
        Statistics GetStatistics();
    }
}
