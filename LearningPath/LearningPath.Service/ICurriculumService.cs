using LearningPath.Data;
using LearningPath.Service.Models;

namespace LearningPath.Service
{
    public interface ICurriculumService
    {
        Curriculum GenerateCurriculumForPath(IEnumerable<Lesson> lessonLibrary, CareerPath path, int minimumHours);
    }
}