// Chapter 20, problem 1
// School namespace 
//class teacher (teaching courses, each course has a name, count of classes and count of exercises, teachers have names)
//class students (have names and unique numbers) 
//class classes have a unique text identifier. 

namespace School;

public class People
{
    protected string _name;
}
public class Teacher : People
{
    private string _course;

    public Teacher(string name, string course)
    {
        _name = name;
        _course = course;
    }

    public void TeachesCourse(string name, string course)
    {
         _course = course;
         _name = name;
         Console.WriteLine("{0} teaches the {1} course", name, course);
     }

}

public class Student : People
{
    private int _uniqueNum;

    public Student(string name, int uniqueNum)
    {
        _name = name;
        _uniqueNum = uniqueNum;
    }
}

public class Course
{
    private string _courseName;
    private int _countOfClasses;
    private int _countofExercises;

    public Course(string name, int countOfClasses, int countofExercises)
    {
        _courseName = name;
        _countOfClasses = countOfClasses;
        _countofExercises = countofExercises;
    }
}

public class Class 
{
    private int _classIdentifier;

    public Class(int classIdentifier)
    {
        _classIdentifier = classIdentifier;
    }
}