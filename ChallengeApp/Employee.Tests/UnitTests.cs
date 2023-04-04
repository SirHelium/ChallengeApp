namespace ChallengeApp
{
    public class Tests
    {
        [Test]
        public void WhenTheAverageEqualZero()
        {
            var employee1 = new Employee("Piotr", "Testowski");

            employee1.AddGrade(-1);
            employee1.AddGrade(0);
            employee1.AddGrade(1);
            var statistics = employee1.GetStatistics();

            Assert.AreEqual(1, statistics.Max);
            Assert.AreEqual(-1, statistics.Min);
            Assert.AreEqual(0, statistics.Average);
        }
        [Test]
        public void TestingAtStartingIndicators()
        {
            var employee1 = new Employee("Piotr", "Testowski");

            var statistics = employee1.GetStatistics();

            // do naprawy
            Assert.AreNotEqual(0, statistics.Max);
            Assert.AreNotEqual(0, statistics.Min);
            Assert.AreNotEqual(0, statistics.Average);
        }
        [Test]
        public void Test3WhenAddingDifferentGrades()
        {
            var employee1 = new Employee("Piotr", "Testowski");

            employee1.AddGrade(6);
            employee1.AddGrade(-2);
            employee1.AddGrade(8);
            var statistics = employee1.GetStatistics();

            Assert.AreEqual(8, statistics.Max);
            Assert.AreEqual(-2, statistics.Min);
            Assert.AreEqual(4, statistics.Average);
        }
    }
}