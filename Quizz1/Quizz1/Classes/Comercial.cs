using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizz1.Classes
{
    public class Comercial : ProgramProvision
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public DateTime releaseDate { get; set; }

        public DateTime instalationDate { get; set; }

        public DateTime expiryDate { get; set; }

        public float price { get; set; }


        public Comercial(string name, string manufacturer, DateTime releaseDate, DateTime instalationDate, DateTime freeTrial, float price)
        {
            Name = name;
            Manufacturer = manufacturer;
            this.releaseDate = releaseDate;
            this.instalationDate = instalationDate;
            this.expiryDate = freeTrial;
            this.price = price;
            this.UseDate = (expiryDate - dateNow).TotalDays;
            CheckDate = expiryDate;
        }

        public override string ToString()
        {
            return $"Name: {Name};" +
                $"\n Manufacturer: {Manufacturer};" +
                $"\n ReleaseDate: {releaseDate};" +
                $"\n InstalationDate: {instalationDate};" +
                $"\n ExpiryDate: {expiryDate};" +
                $"\n Price: {price};" +
                $"\n UseDate: {UseDate};";
        }
    }
}
