using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz1.Classes
{
    public class Try : ProgramProvision
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public DateTime releaseDate { get; set; }

        public DateTime instalationDate { get; set; }

        public DateTime freeTrial { get; set; }

        public Try(string name, string manufacturer, DateTime releaseDate, DateTime instalationDate, DateTime freeTrial)
        {
            Name = name;
            Manufacturer = manufacturer;
            this.releaseDate = releaseDate;
            this.instalationDate = instalationDate;
            this.freeTrial = freeTrial;
            this.UseDate = (freeTrial - dateNow).TotalDays;
            CheckDate = freeTrial;
        }

        public override string ToString()
        {
            return $"Name: {Name};" +
                $"\n Manufacturer: {Manufacturer};" +
                $"\n ReleaseDate: {releaseDate};" +
                $"\n InstalationDate: {instalationDate};" +
                $"\n FreeTrial: {freeTrial};" +
                $"\n UseDate: {UseDate};";
        }
    }
}
