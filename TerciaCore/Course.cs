namespace Tercia.TerciaCore;

public class Course
{
    public int Id { get; init; }
    public string Name { get; init; }
    public string? CoverUrl { get; init; }
    public List<Lesson> Lessons { get; init; }
}
