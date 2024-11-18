using System.Net.Http.Json;

namespace Tercia.TerciaCore;

public static class Database
{
    private static HttpClient _httpClient = new()
    {
        BaseAddress = new Uri("http://130.193.58.142:8000")
    };

    public static async Task<List<Lesson>?> GetCourseLessons(int courseId)
    {
        return await _httpClient.GetFromJsonAsync<List<Lesson>>("/get-course-lessons");
    }

    public static async Task<List<Course>?> GetAllCourses()
    {
        return await _httpClient.GetFromJsonAsync<List<Course>>("/get-courses");
    }
}