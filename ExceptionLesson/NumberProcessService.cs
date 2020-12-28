using System;

namespace ExceptionLesson
{
    public class NumberProcessService
    {
        /// <summary>
        /// Math method with numbers
        /// </summary>
        /// <param name="potentialNumber">Argument</param>
        /// <returns>Number</returns>
        /// <exception cref="ArgumentException">ArgumentException</exception>
        public bool IsNormalNumber(int potentialNumber)
        {
            
            if (potentialNumber == 0)
            {
                return true;
            }
            else if (potentialNumber < 0)
            {
                throw new ArgumentException("Number less zero. Flu");
            }
            else
            {
                return true;
            }
        }

        public double ModuleNumber(double Number)
        {
            return RootNumber(Number);
        }

        public double RootNumber(double Number)
        {
            if (Number>=0)
                return Math.Sqrt(Number);
            else
            {
                throw new ArgumentException("Number less zero.");
            }
        } 
    }
}
