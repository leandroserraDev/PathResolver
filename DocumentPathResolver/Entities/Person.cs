namespace DocumentPathResolver.Entities
{
    public class Person
    {
        public Person(string name, string lastName, int age, string document)
        {
            Name=name;
            LastName=lastName;
            Age=age;
            Document=document;
        }

        public string Name { get; private set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Document { get; private set; }



    }
}
