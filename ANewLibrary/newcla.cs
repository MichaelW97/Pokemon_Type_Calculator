using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TypeList;
using Typess;

namespace Typess {
    public class TypeStats {

        /*
         *  created 19/10/2016
         * 
         */

        /// defining variable etc

        //intiating arrays for defesive/offensive
        public double[] Defensive { get; set; }
        public double[] Offensive { get; set; }

        public void Typess() {
            this.Defensive = new double[0];
            this.Offensive = new double[0];
        }


        public void typeArrays(double[] iDef, double[] iOff) {
            Defensive = iDef; //{ get; set; }
            Offensive = iOff; //{ get; set; }
        }

        //All types for defintions in implementations
        public enum AllTypes { NORMAL, FIRE, WATER, ELECTIC, GRASS, ICE, FIGHTING, POISON, GROUND, FLYING, PSYCHIC, BUG, ROCK, GHOST, DRAGON, DARK, STEEL, FAIRY, NULL };

        //type effectivness numbers
        public static double SUPEREFFECTIVE = 2;
        public static double EFFECTIVE = 1;
        public static double NONEFFECTIVE = 0.5;
        public static double NOEFFECTIVE = 0;

        /*
        public static double[] ChangeDef(double[] array) {
            Defensive = array;
            return array;
        }
        public static double[] ChangeOff(double[] array) {
            Offensive = array;
            return array;
        }
        */
    }

    public class TypeFunctions : TypeStats {
        /*
         *  created 19/10/2016
         * 
         */


        /// <summary>
        /// inputs two types then returns the final type
        /// </summary>
        /// <param name="typeOne"></param>
        /// <param name="typeTwo"></param>
        /// <returns></returns>
        public static double[] DualType(double[] typeOne, double[] typeTwo) {
            double[] finalType = new double[typeOne.Length];

            for (int i = typeOne.Length; 0 < i; i--) {
                finalType[i] = typeOne[i] * typeTwo[i];
            }
            return finalType;
        }

        /*
        public void ChangeDef(double[] array) {
            this.Defensive = array;
            //return array;
        }
        public void ChangeOff(double[] array) {
            this.Offensive = array;
            //return array;
        }
        */

    }
    public class CalendarEntry {
        // private field
        private DateTime date;

        // public field (Generally not recommended.)
        public string day;

        // Public property exposes date field safely.
        public DateTime Date {
            get {
                return date;
            }
            set {
                // Set some reasonable boundaries for likely birth dates.
                if (value.Year > 1900 && value.Year <= DateTime.Today.Year) {
                    date = value;
                } else
                    throw new ArgumentOutOfRangeException();
            }

        }

        // Public method also exposes date field safely.
        // Example call: birthday.SetDate("1975, 6, 30");
        public void SetDate(string dateString) {
            DateTime dt = Convert.ToDateTime(dateString);

            // Set some reasonable boundaries for likely birth dates.
            if (dt.Year > 1900 && dt.Year <= DateTime.Today.Year) {
                date = dt;
            } else
                throw new ArgumentOutOfRangeException();
        }

        public TimeSpan GetTimeSpan(string dateString) {
            DateTime dt = Convert.ToDateTime(dateString);

            if (dt != null && dt.Ticks < date.Ticks) {
                return date - dt;
            } else
                throw new ArgumentOutOfRangeException();

        }
    }
    class Person {
        private string name;  // the name field
        public string Name    // the Name property
        {
            get {
                return name;
            }
            set {
                name = value;
            }
        }
    }
    public class Test {
        public void newmeth() {
            Person person = new Person();
            person.Name = "Joe";  // the set accessor is invoked here                
        }
        //System.Console.Write(person.Name);  // the get accessor is invoked here
    }
}
