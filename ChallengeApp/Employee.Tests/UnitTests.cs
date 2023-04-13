namespace ChallengeApp
{
    public class Tests
    {
        [Test]
        public void WhenAddStringGrades()
        {
            var employee1 = new EmployeeInMemory("Piotr", "Testowski");

            employee1.AddGrade("84");
            employee1.AddGrade("c");

            var statistics = employee1.GetStatistics();

            Assert.AreEqual(84, statistics.Max);
            Assert.AreEqual(60, statistics.Min);
        }
        [Test]
        public void WhenAddCharGrades()
        {
            var employee1 = new EmployeeInMemory("Piotr", "Testowski");

            employee1.AddGrade('A');
            employee1.AddGrade('d');

            var statistics = employee1.GetStatistics();

            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(40, statistics.Min);
        }
        [Test]
        public void WhenAddFloatOrDoubleOrIntGrades()
        {
            var employee1 = new EmployeeInMemory("Piotr", "Testowski");

            employee1.AddGrade(10);
            employee1.AddGrade(24.5673f);
            employee1.AddGrade(56.56734234324);

            var statistics = employee1.GetStatistics();

            Assert.AreEqual(57, Math.Round(statistics.Max));
            Assert.AreEqual(10, statistics.Min);
            Assert.AreEqual(30, Math.Round(statistics.Average));
            Assert.AreEqual('D', statistics.AverageLetter);
        }

    }
}