using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Mod6Demo1
{
    
    class Program
    {
        static void Main(string[] args)
        {// structure : value type , stack 

           
            
            Book b1 = new Book();
            Book b2=new Book("FIC-33-RE","FF","YY",20,"sfsf");
            //new line
            Console.WriteLine("Enter book details :");
            Console.WriteLine("Enter book id:");
            b1.Setbookid(Console.ReadLine());
            Console.WriteLine("Enter book name:");
            b1.Setbookname(Console.ReadLine());
            
            Console.WriteLine("Book details are:");
            Console.WriteLine("Book id is: {0}",b1.Getbookid());
            Console.WriteLine("Book name is: {0}", b1.Getbookname());
            
            Console.WriteLine("Second book is");
            Console.WriteLine("Book id is: {0}", b2.Getbookid());
            Console.WriteLine("Book name is: {0}", b2.Getbookname());

            Console.ReadLine();
            //Console.WriteLine(b1.ToString());

            Author a1 = new Author();
            
            
           

            //constructor 
        }
    }
}
