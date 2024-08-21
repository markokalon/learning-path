
using LearningPath.Data;
using LearningPath.Service;

var lessonLibrary = CreateLessonLibrary();

var curriculumService = new CurriculumService();
var curriculum = curriculumService.GenerateCurriculumForPath(lessonLibrary, CareerPath.Databases, 12);

foreach (var lesson in curriculum.Lessons)
{
    Console.WriteLine($"Lesson: {lesson.Title} - Hours: {lesson.Hours}");
}
Console.ReadLine();

IEnumerable<Lesson> CreateLessonLibrary()
{
    return new List<Lesson>
    {
        new Lesson { Id = 1, Title = "Introduction to Programming", Hours = 2, Path = CareerPath.SoftwareDevelopment },
        new Lesson { Id = 2, Title = "Algorithms and Data Structures", Hours = 4, Path = CareerPath.SoftwareDevelopment },
        new Lesson { Id = 3, Title = "Database Management", Hours = 3, Path = CareerPath.SoftwareDevelopment },
        new Lesson { Id = 4, Title = "Advanced Object-Oriented Programming", Hours = 6, Path = CareerPath.SoftwareDevelopment },
        new Lesson { Id = 5, Title = "Software Design Patterns", Hours = 7, Path = CareerPath.SoftwareDevelopment },
        new Lesson { Id = 6, Title = "Full-Stack Development", Hours = 10, Path = CareerPath.SoftwareDevelopment },
        new Lesson { Id = 7, Title = "Machine Learning Basics", Hours = 12, Path = CareerPath.SoftwareDevelopment },
        new Lesson { Id = 8, Title = "DevOps and CI/CD", Hours = 14, Path = CareerPath.SoftwareDevelopment },
        new Lesson { Id = 9, Title = "Software Architecture", Hours = 19, Path = CareerPath.SoftwareDevelopment },
        
        new Lesson { Id = 10, Title = "Data Warehousing", Hours = 6, Path = CareerPath.Databases },
        new Lesson { Id = 11, Title = "SQL Advanced Techniques", Hours = 5, Path = CareerPath.Databases },
        new Lesson { Id = 12, Title = "NoSQL Databases", Hours = 7, Path = CareerPath.Databases },
        new Lesson { Id = 13, Title = "Database Security", Hours = 9, Path = CareerPath.Databases },
        new Lesson { Id = 14, Title = "Database Optimization", Hours = 4, Path = CareerPath.Databases },
        new Lesson { Id = 15, Title = "Data Modeling", Hours = 3, Path = CareerPath.Databases },
        new Lesson { Id = 16, Title = "Cloud Databases", Hours = 13, Path = CareerPath.Databases },
        
        new Lesson { Id = 17, Title = "How to Lead a Team", Hours = 8, Path = CareerPath.Management },
        new Lesson { Id = 18, Title = "Management 101", Hours = 11, Path = CareerPath.Management },
        new Lesson { Id = 19, Title = "Project Management Fundamentals", Hours = 5, Path = CareerPath.Management },
        new Lesson { Id = 20, Title = "Agile Methodologies", Hours = 6, Path = CareerPath.Management },
        new Lesson { Id = 21, Title = "Strategic Planning", Hours = 15, Path = CareerPath.Management },
        new Lesson { Id = 22, Title = "Change Management", Hours = 9, Path = CareerPath.Management },
        new Lesson { Id = 23, Title = "Time Management for Leaders", Hours = 3, Path = CareerPath.Management },
        
        new Lesson { Id = 24, Title = "Data Visualization", Hours = 1, Path = CareerPath.DataScience },
        new Lesson { Id = 25, Title = "Big Data", Hours = 3, Path = CareerPath.DataScience },
        new Lesson { Id = 26, Title = "Data Science with Python", Hours = 7, Path = CareerPath.DataScience },
        new Lesson { Id = 27, Title = "Statistics for Data Science", Hours = 4, Path = CareerPath.DataScience },
        new Lesson { Id = 28, Title = "Machine Learning Models", Hours = 8, Path = CareerPath.DataScience },
        new Lesson { Id = 29, Title = "AI and Deep Learning", Hours = 12, Path = CareerPath.DataScience },
        new Lesson { Id = 30, Title = "Data Ethics and Governance", Hours = 5, Path = CareerPath.DataScience },
        new Lesson { Id = 31, Title = "Advanced Data Analysis", Hours = 14, Path = CareerPath.DataScience },
        
        new Lesson { Id = 32, Title = "Introduction to Cybersecurity", Hours = 4, Path = CareerPath.Cybersecurity },
        new Lesson { Id = 33, Title = "Network Security", Hours = 5, Path = CareerPath.Cybersecurity },
        new Lesson { Id = 34, Title = "Ethical Hacking", Hours = 7, Path = CareerPath.Cybersecurity },
        new Lesson { Id = 35, Title = "Cryptography", Hours = 6, Path = CareerPath.Cybersecurity },
        new Lesson { Id = 36, Title = "Incident Response", Hours = 8, Path = CareerPath.Cybersecurity },
        new Lesson { Id = 37, Title = "Advanced Threat Detection", Hours = 11, Path = CareerPath.Cybersecurity },
        new Lesson { Id = 38, Title = "Security in Cloud Computing", Hours = 10, Path = CareerPath.Cybersecurity },
        new Lesson { Id = 39, Title = "Cybersecurity Risk Management", Hours = 13, Path = CareerPath.Cybersecurity },
        new Lesson { Id = 40, Title = "Penetration Testing", Hours = 19, Path = CareerPath.Cybersecurity },
    };
}

