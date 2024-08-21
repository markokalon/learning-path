namespace LearningPath.Data
{
    public class Lesson
    {
        public int Id { get; set; }
        public int Hours { get; set; }
        public string Title { get; set; }
        public CareerPath Path { get; set; }
    }
}
