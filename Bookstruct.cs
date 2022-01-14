using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod6Demo1
{
    // access specifiers : public, internal, private, protected
     struct Author //internal ( private to namespace)
    {
        public string authorname;

    }
    public struct Book
    {

        // 100
        // "FIC-2015-1001"
        //data menmbers: private
        //int i;
        //data hiding
       // string myname; //private
        private string bookId;
        private string name;
        private string author;
        private int copies;
        private string ISBN;
        //constructor
        //initialize 
        
        public Book(string id,string name,string author,int cps,string isbn)
        {
            this.bookId = id;
            this.name = name;
            this.author = author;
            this.copies = cps;
            this.ISBN = isbn;

        }
        internal string Getbookname() // private to the type
        {
            //me

            return this.name;
        }
        public void Setbookname(string name)
        {

            //validation logic ( len <50)
            //business logic
            if (name.Length <= 15)
            {
                this.name = name;
            }
            else
            {
                Console.WriteLine("Len should be small than 50");
            }
        }
        public string Getbookid() // private to the type
        {
            //me
            
            return this.bookId;
        }
        public void Setbookid(string id)
        {
           

            this.bookId=id;
        }

        public bool Checkbook(string name)
        {
            // search logic
            return true;
        }

        



    }
}
