using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz1.Classes
{
    public abstract class ProgramProvision
    {
        public DateTime dateNow = DateTime.Now;
        public double UseDate {  get; set; }

        public DateTime CheckDate { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
