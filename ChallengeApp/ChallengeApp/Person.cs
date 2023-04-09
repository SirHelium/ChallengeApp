namespace ChallengeApp
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public char Sex { get; private set; }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Person(string name, string surname, char sex) : this (name, surname)
        {
            Sex = sex;
        }
    }
}
