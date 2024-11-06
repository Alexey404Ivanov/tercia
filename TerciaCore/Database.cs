namespace Tercia.TerciaCore;

public static class Database
{
    public static List<Lesson> GetCourseLessons(int courseId)
    {
        return new List<Lesson>()
        {
            new Lesson
            {
                Id = 1, Title = "Как держать гитару",
                Link = "https://vk.com/video_ext.php?oid=-227293370&id=456239060&hash=b490453dc0cc24bd"
            }
        };
    }

    public static List<Course> GetAllCourses()
    {
        return new List<Course>()
        {
            new Course
            {
                Id = 1,
                Name = "Акустическая гитара",
                Lessons = GetCourseLessons(1),
                CoverUrl = "https://s3-alpha-sig.figma.com/img/03a3/e00b/3e94b2167c1fcefaf62f6f10c35f7a04?Expires=1731888000&Key-Pair-Id=APKAQ4GOSFWCVNEHN3O4&Signature=ewS7GCy7xe7Duon0WO42N23gKMek872p2hnF8guePz8MOAlP17bOldqBQqvGGIHFZD9fL7zxO42~EiqZew6Kmmyk~m16lg-Y-ws75aDeJt9pN4SW29B15L4wsiOAh6p3tjSiHQaJESQ-2eXOnqXkwXBmgFOWFD5kgoWkSams~l2yonHqMJEoa8gQCorR78HUo-Iy7NS1YsxpD4TWov0PAUDC5S42WDkQU8kv6QOqFILNiiQ3MDp3QRTJ6Hm4Hg7xSzHxPIr76XTUO9O9KlYEJrUyCAbK4-YxOfKCYrEZlAr3XxlxrsoUmft6zt8OteoOlX9NrGCE~BHLJHBdEQNkww__"
            }
        };
    }
}