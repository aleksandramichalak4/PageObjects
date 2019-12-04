namespace ClassLibrary1
{
    internal class ExampleNote
    {
        public ExampleNote()
        {
            Title = Faker.Lorem.Paragraph();
            Content = Faker.Lorem.Paragraph();
        }

        public string Title { get; }
        public string Content { get; }
    }
}