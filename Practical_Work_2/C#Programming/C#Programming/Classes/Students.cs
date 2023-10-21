using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programming.Classes
{
    internal class Students
    {
        #region task 5.2.2

        #region private fields

        private string fn;
        private string ln;
        private int age;

        #endregion

        #region private methods

        public String FirstName
        {
            get { return this.fn; }
            set { this.fn = value; }
        }

        public String LastName
        {
            get { return this.ln; }
            set { this.ln = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        #endregion

        #endregion

        #region task 5.2.1

        public static float AvarageGrade(int[] grades, out string msg)
        {
            float sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }
            msg = $"[ {string.Join(", ", grades)} ] are your grades," +
                $"\n And your Avarage grades is {sum / grades.Length}";
            return sum/grades.Length;
        }

        #endregion
    }
}
