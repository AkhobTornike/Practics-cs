using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Programming.Classes
{
    internal class Train
    {
        #region 5.2.3

        #region private fields

        private int amountOfCarriage;
        private int amountOfPassenger;

        #endregion

        #region public fields

        public int ticketsPrice;
        public int amountOfSoldTickets;

        #endregion

        #region methods

        public Train(int amountOfSoldTickets, int ticketsPrice)
        {
            this.amountOfSoldTickets = amountOfSoldTickets;
            this.ticketsPrice = ticketsPrice;
        }

        public void setNumberOfPassengers(int passengers)
        {
            amountOfPassenger = passengers;
        }

        public void SetNumbersOfCarriage(int carrriage)
        {
            amountOfCarriage = carrriage;
        }

        public int CalculateProfit()
        {
            Console.WriteLine($"Amount of tickets: {amountOfSoldTickets}");
            Console.WriteLine($"Tickets Price: {ticketsPrice}");

            return amountOfSoldTickets * ticketsPrice;
        }

        #endregion

        #endregion
    }
}
