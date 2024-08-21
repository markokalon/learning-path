using LearningPath.Data;

namespace LearningPath.Service.Models
{
    public class Curriculum
    {

        public Curriculum()
        {
            Lessons = new List<Lesson>();
        }

        public IEnumerable<Lesson> Lessons { get; set; }

        public int TotalHours
        {
            get
            {
                return Lessons.Sum(l => l.Hours);
            }
        }
    }
}
