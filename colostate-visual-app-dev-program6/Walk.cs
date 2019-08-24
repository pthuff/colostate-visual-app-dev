/*
 * Date:            September 18, 2018
 * ModifiedL        September 19,2018
 * Developed By:    Paul Huff
 * Class Name:      Walk
 * Description:     Class for constructing Walk and calculating distance walked
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHuffProgram6
{
    class Walk
    {
        //Declare variables
        private string walkerName;
        private double numberOfSteps, lengthOfStep;

        //Private and public accessor properties
        public string WalkerName
        {
            get { return walkerName; }
            set { walkerName = value; }
        }
        public double NumberOfSteps
        {
            get { return numberOfSteps; }
            set { numberOfSteps = value; }
        }
        public double LengthOfStep
        {
            get { return lengthOfStep; }
            set { lengthOfStep = value; }
        }

        //Constructor with parameters
        public Walk(string nameOfWalker, double stepsCount, double stepLength)
        {
            WalkerName = nameOfWalker;
            NumberOfSteps = stepsCount;
            LengthOfStep = stepLength;
        }

        //Calculate miles walked
        public double CalculateMilesWalked()
        {
            //Constants and variable
            const int idkWhatThisNumRepresents = 63360;
            double distance;

            //Calculate
            distance = (NumberOfSteps * LengthOfStep) / idkWhatThisNumRepresents;

            //Return distance
            return distance;
        }


    }
}
