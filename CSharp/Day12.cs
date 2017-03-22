using System;
using System.Collections.Generic;
using System.IO;
class Student{
   protected String firstName;
   protected String lastName;
   public int phone;
   public Student(String fname,String lname,int p){
         firstName=fname;
         lastName=lname;
         phone=p;
       
   }
   public void display(){// display the details of the student
       Console.WriteLine("First Name: "+firstName+"\nLast Name: "+lastName+"\nPhone: "+phone); 
   }

}
class Grade : Student{
    private int score;
	public Grade(String firstName,String lastName,int p,int s): base(firstName,lastName,p)
	{
		score = s;
	}
    public char calculate()
	{
		char r = ' ';
		if(score < 40)
		{
			r = 'D';
		}
		else if (score>=40 && score < 60)
		{
			r = 'B';
		}
		else if (score>=60 && score < 75)
		{
			r = 'A';
		}
		else if (score>=75 && score < 90)
		{
			r = 'E';
		}
		else if (score>=90 && score < 100)
		{
			r = 'O';
		}
		
		return r;
	}
}
class Solution {
    static void Main(String[] args) {
        String firstName=Console.ReadLine();
        String lastName=Console.ReadLine();
        int phone=Int32.Parse(Console.ReadLine());
        int score=Int32.Parse(Console.ReadLine());
        Student stu=new Grade(firstName,lastName,phone,score);
        stu.display();
        Grade g=(Grade)stu;
        Console.WriteLine("Grade: "+g.calculate());
		Console.ReadKey();
    } 
}