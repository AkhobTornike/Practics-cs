 using C_Programming.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programming.Classes
{
    internal class Person
    {

        #region private fields
        // default value is private
        private string pn; // personal id
        private string fn; // first name
        private string ln; // last name
        private DateTime db; // birth date
        private EnumGender gender;
        private EnumCountry country;
        #endregion


        #region public properties

        public String LastName 
        {
            get { return this.ln;  }
            set { this.ln = value;  }
        }

        public int Age
        {
            get
            {
                DateTime today = DateTime.Now;
                int diff = today.Year - this.db.Year;
                if (this.db.Month > today.Month || (this.db.Month == today.Month && this.db.Day > today.Day))
                    return --diff;
                return diff;
            }
        }
         
        public int FamilyMembersCount { get; set; }

        #endregion


        #region ovverloaded constructors(s)
        public Person() 
        {
            Console.WriteLine("Person object has created!");
        }

        public Person(string pn, string fn, string ln) : this()
        {
            this.fn = fn;
            this.ln = ln;
            this.pn = pn;
        }

        public Person(string pn, string fn, string ln, DateTime db) : this(pn, fn, ln)
        {
            this.db = db;
        }

        public Person(string pn, string fn, string ln, DateTime db, EnumGender gender) : this(pn, fn, ln, db)
        {
            this.gender = gender;
        }

        public Person(string pn, string fn, string ln, DateTime db, EnumGender gender, EnumCountry country) : this(pn, fn, ln, db, gender)
        {
            this.country = country;
        }


        #endregion


        #region overrided methods
        public override string ToString()
        {
            return $"Personal Number:{this.pn};" +
                $"\nFull Name:{this.fn} {this.ln};" +
                $"\nBirth Date:{this.db.ToShortDateString()};" +
                $"\nAge:{this.Age};" +
                $"\nGender:{this.gender};" +
                $"\nCounty:{this.country};" +
                $"\nFamily Members:{this.FamilyMembersCount}";
        }

        public override bool Equals(object obj)
        {
            Person o = obj as Person;
            return o.pn.Equals(this.pn);
        }

        #endregion

    }
}