/*
 * Date:            October 3, 2018
 * Modified:        October 9,2018
 * Developed By:    Paul Huff
 * Class Name:      CateringEvent
 * Description:     Class for constructing CateringEvent and calculate a catering object's charges
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHuffProgram9
{
    //Declare entre enumration
    public enum EntreType
    {
        PrimeRib,
        ChickenMarsala,
        GardenLasagna
    }
    //Declare class
    class CateringEvent
    {
        //Declare constants and assign values
        const decimal primeRibPrice = 62.87m, chickenMarsalaPrice = 53.74m, gardenLasagnaPrice = 45.31m;
        const decimal openBarPrice = 46.92m, wineWithDinnerPrice = 37.48m, over100AdditionalCharge = 35.00m;

        const int cutoffForAdditionalCharge = 100;

        //Declare fields
        private EntreType entreChoice;
        private int numberOfGuests;
        private bool openBar, wineWithDinner;

        //Declare auto-implmented public properties
        public string EventName { get; set; }
        public decimal EntreCharge { get; private set; }
        public decimal DrinksCharge { get; private set; }
        public decimal Surcharge { get; private set; }
        public decimal TotalCharge { get; private set; }

        //Declare public properties with private get/set accessors and call to update method values
        public int NumberOfGuests
        {
            get
            {
                return numberOfGuests;
            }
            set
            {
                numberOfGuests = value;
                CalcEventCharges();
            }
        }
        public EntreType EntreChoice
        {
            get
            {
                return entreChoice;
            }
            set
            {
                entreChoice = value;
                CalcEventCharges();
                ReturnEntrePrice();
            }
        }
        public bool OpenBar
        {
            get
            {
                return openBar;
            }
            set
            {
                openBar = value;
                CalcEventCharges();
            }
        }
        public bool WineWithDinner
        {
            get
            {
                return wineWithDinner;
            }
            set
            {
                wineWithDinner = value;
                CalcEventCharges();
            }
        }
        //Declare constructor with paramaters
        public CateringEvent(string name, int numGuests, EntreType entre, bool barOption, bool wineOption)
        {
            //Assign parameters
            EventName = name;
            NumberOfGuests = numGuests;
            EntreChoice = entre;
            OpenBar = barOption;
            WineWithDinner = wineOption;
        }
        //Private method to calculate entre price
        private decimal ReturnEntrePrice()
        {
            //Declare local empty variable
            decimal entrePrice = 0.00m;

            //Switch method to assign value
            switch (EntreChoice)
            {
                case EntreType.PrimeRib:
                    entrePrice = primeRibPrice;
                    break;
                case EntreType.ChickenMarsala:
                    entrePrice = chickenMarsalaPrice;
                    break;
                case EntreType.GardenLasagna:
                    entrePrice = gardenLasagnaPrice;
                    break;
            }
            //Return the value
            return entrePrice;
        }
        //Private method to calculate entre charge, drinks charge, surcharge, and total charge
        private void CalcEventCharges()
        {
            //Calculate entre charge
            EntreCharge = (NumberOfGuests * ReturnEntrePrice());

            //Calculate drinks charge
            if (OpenBar == true & WineWithDinner == true)
            {
                DrinksCharge = ((openBarPrice * NumberOfGuests) + (wineWithDinnerPrice * NumberOfGuests));
            }
            else if (OpenBar == true & WineWithDinner == false)
            {
                DrinksCharge = (openBarPrice * NumberOfGuests);
            }
            else if (OpenBar == false & WineWithDinner == true)
            {
                DrinksCharge = (wineWithDinnerPrice * NumberOfGuests);
            }
            else if (OpenBar == false & WineWithDinner == false)
            {
                DrinksCharge = 0.00m;
            }

            //Calculate surcharge
            if (NumberOfGuests > cutoffForAdditionalCharge)
            {
                Surcharge = (over100AdditionalCharge * Convert.ToDecimal(NumberOfGuests - cutoffForAdditionalCharge));
            }
            else if (NumberOfGuests <= cutoffForAdditionalCharge)
            {
                Surcharge = 0.00m;
            }

            //Calculate total charge
            TotalCharge = ((EntreCharge + DrinksCharge) + Surcharge);
        }
    }
}
