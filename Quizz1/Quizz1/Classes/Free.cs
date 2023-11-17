using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz1.Classes
{
    public class Free : ProgramProvision
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public DateTime releaseDate { get; set; }

        public Free(string name, string manufacturer, DateTime releaseDate)
        {
            Name = name;
            Manufacturer = manufacturer;
            this.releaseDate = releaseDate;
            UseDate = 1;
        }

        public override string ToString()
        {
            return $"Name: {Name};" +
                $"\n Manufacturer: {Manufacturer};" +
                $"\n ReleaseDate: {releaseDate};" +
                $"\n UseDate: {UseDate};";
        }
    }
}
