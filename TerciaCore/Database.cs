using System.Net.Http.Json;
namespace Tercia.TerciaCore;

public static class Database
{
    private static readonly HttpClient HttpClient = new() { BaseAddress = new Uri("http://130.193.58.142:8000") };
    private static List<Course>? _courses;
    private static readonly Dictionary<int, List<Lesson>> Lessons = new();

    public static async Task<List<Lesson>> GetCourseLessons(int courseId)
    {
        if (!Lessons.ContainsKey(courseId))
        {
            var response = await HttpClient.GetFromJsonAsync<List<Lesson>>($"/get-course-lessons?course_id={courseId}");
            if (response is null)
                throw new Exception($"Could not fetch lessons for course {courseId}");
            Lessons[courseId] = response;
        }

        return Lessons[courseId];
    }

    public static async Task<List<Course>> GetAllCourses()
    {
        if (_courses is null)
            _courses = await HttpClient.GetFromJsonAsync<List<Course>>("/get-courses");
        if (_courses is null)
            throw new Exception("Could not fetch courses list");
        return _courses;
    }
}