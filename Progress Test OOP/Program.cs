using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Progress_test_oop;

namespace Progress_test_oop
{
    public class ObjectOrientedProgrammingCourse
    {
        public string studentName = "Student Name:";
        public string studentId = "Student ID:";
        public string identificationCard = "Identification Card:";
        public string mark = "Mark:";
        public void detail()
        {Console.WriteLine();
            Console.WriteLine("Object Oriented Programming Course");
            
        }
    }
    public class Student : ObjectOrientedProgrammingCourse
    {

        public string stu_name1 = "Caleb Lim";
        public string stu_id1 = "BCS21090001";
        public string id_card1 = "020101130001";
        public decimal mark1 = 85;
    }
    public class Student2 : ObjectOrientedProgrammingCourse
    {
        public string stu_name2 = "Cody Cheng";
        public string stu_id2 = "BCS21090002";
        public string id_card2 = "020202130003";
        public decimal mark2 = 86;
    }
    public class Student3 : ObjectOrientedProgrammingCourse
    {
        public string stu_name3 = "Patrick Yung";
        public string stu_id3 = "BCS21090003";
        public string id_card3 = "020303130005";
        public decimal mark3 = 87;
    }
    public class Student4 : ObjectOrientedProgrammingCourse
    {
        public string stu_name4 = "Peter Wong";
        public string stu_id4 = "BCS21090004";
        public string id_card4 = "020404140007";
        public decimal mark4 = 88;
    }
    public class Student5 : ObjectOrientedProgrammingCourse
    {
        public string stu_name5 = "Samuel Tham";
        public string stu_id5 = "BCS21090005";
        public string id_card5 = "020505130009";
        public decimal mark5 = 89;

    }
}

class Program
{
    static void Main(string[] args)
    {
        Progress_test_oop.Student myStudent = new Student();

        myStudent.detail();

        Console.WriteLine(myStudent.studentName + " " + myStudent.stu_name1);
        Console.WriteLine(myStudent.studentId + " " + myStudent.stu_id1);
        Console.WriteLine(myStudent.identificationCard + " " + myStudent.id_card1);
        Console.WriteLine(myStudent.mark + " " + myStudent.mark1);


        Progress_test_oop.Student2 myStudent2 = new Student2();

        myStudent.detail();
        Console.WriteLine(myStudent2.studentName + " " + myStudent2.stu_name2);
        Console.WriteLine(myStudent2.studentId + " " + myStudent2.stu_id2);
        Console.WriteLine(myStudent2.identificationCard + " " + myStudent2.id_card2);
        Console.WriteLine(myStudent2.mark + " " + myStudent2.mark2);


        Progress_test_oop.Student3 myStudent3 = new Student3();

        myStudent.detail();
        Console.WriteLine(myStudent3.studentName + " " + myStudent3.stu_name3);
        Console.WriteLine(myStudent3.studentId + " " + myStudent3.stu_id3);
        Console.WriteLine(myStudent3.identificationCard + " " + myStudent3.id_card3);
        Console.WriteLine(myStudent3.mark + " " + myStudent3.mark3);


        Progress_test_oop.Student4 myStudent4 = new Student4();

        myStudent.detail();
        Console.WriteLine(myStudent4.studentName + " " + myStudent4.stu_name4);
        Console.WriteLine(myStudent4.studentId + " " + myStudent4.stu_id4);
        Console.WriteLine(myStudent4.identificationCard + " " + myStudent4.id_card4);
        Console.WriteLine(myStudent4.mark + " " + myStudent4.mark4);


        Progress_test_oop.Student5 myStudent5 = new Student5();

        myStudent.detail();
        Console.WriteLine(myStudent5.studentName + " " + myStudent5.stu_name5);
        Console.WriteLine(myStudent5.studentId + " " + myStudent5.stu_id5);
        Console.WriteLine(myStudent5.identificationCard + " " + myStudent5.id_card5);
        Console.WriteLine(myStudent5.mark + " " + myStudent5.mark5);


    }

    
}
class Sort_Student_Ranking
{
    static void Main(string[] args)
    {

        List<string> students = new List<string>(){ "Caleb Lim", "Cody Cheng",
                                                "Patrick Yung", "Peter Wong","Samuel Tham" };

        var result = students.OrderByDescending(n => n);

        Console.Write("Sorted list in Descending order:\n");
        foreach (string student in result)
        {
            Console.Write(student + " ");
        }
    }
}

class Sort_Student_Details
{

   
    public static void Main()
    {

        int[] arr = new int[] { 85,86,87,88,89 };

        Array.Sort(arr);
       
        Array.Reverse(arr);

        foreach (int value in arr)
        {
            Console.Write(value + " ");
        }
    }
}

