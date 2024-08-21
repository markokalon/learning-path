using LearningPath.Data;
using LearningPath.Service.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LearningPath.Service
{
    public class CurriculumService : ICurriculumService
    {
        public Curriculum GenerateCurriculumForPath(IEnumerable<Lesson> lessonLibrary, CareerPath path, int targetTotalHours)
        {
            // write an algorithm that generates a curriculum based on the lessons provided
            // the curriculum should be returned as a Curriculum object
            // the curriculum should be for the specified career path and be as close to the target total hours as possible
            // there should be no duplicate lessons in the curriculum
            // there should be as little lessons in the curriculum as possible
            // Filter lessons by the specified career path and sort by duration in descending order

        }
    }
}
