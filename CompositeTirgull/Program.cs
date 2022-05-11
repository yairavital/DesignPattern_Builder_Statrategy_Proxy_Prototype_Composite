using CompositeTirgull;

StudentGroup classStudent1 = new StudentGroup();
Student stu1 = new Student();
classStudent1.students.Add(stu1);
classStudent1.students.Add(new Student());
classStudent1.students.Add(new Student());
classStudent1.students.Add(new Student());
//Get Grade for every student
classStudent1.students.ForEach(student => global::System.Console.WriteLine(student.GetGrade()));
//Get Average for the class
Console.WriteLine("The average is: " + classStudent1.GetGrade());
StudentGroup classStudent2 = new StudentGroup();
Student stu2 = new Student();
classStudent2.students.Add(stu2);
classStudent2.students.Add(new Student());
classStudent2.students.Add(new Student());
classStudent2.students.Add(new Student());
StudentGroup layer = new StudentGroup();
    layer.students=(classStudent1.students.Union(classStudent2.students)).ToList();
//Return average of the layer
Console.WriteLine(layer.GetGrade());







