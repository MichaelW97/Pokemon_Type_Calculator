using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeList;
using Typess;

namespace Typess {
    /// <summary>
    /// sort of failed in implimenting this the way i wanted. a few things depend on this and more will int eh future.
    /// may try to fix it some time
    /// </summary>
    public class TypeStats {

        /*
         *  created 19/10/2016
         * 
         */

        #region didn't get this working the way i wanted, ignore
        /// defining variable etc

        //intiating arrays for defesive/offensive
        public double[] Defensive  { get; set; }
        public double[] Offensive  { get; set; }

        public TypeStats(double[] Defensive, double[] Offensive) {
            //Defensive = Defensive;
            //Offensive = Offensive;
        }


        // public TypeStats (double[] iOff, double[] iDef) {
        //          Defensive = iDef; //{ get; set; }
        //         Offensive = iOff; //{ get; set; }
        //      }
        #endregion

        //All types for defintions in implementations
        public enum AllTypes { NORMAL, FIRE, WATER, ELECTIC, GRASS, ICE, FIGHTING, POISON, GROUND, FLYING, PSYCHIC, BUG, ROCK, GHOST, DRAGON, DARK, STEEL, FAIRY, NULL };

        //type effectivness numbers
        public static double SUPEREFFECTIVE = 2;
        public static double EFFECTIVE = 1;
        public static double NONEFFECTIVE = 0.5;
        public static double NOEFFECTIVE = 0;

        ///more will be added as more thigns need to be set etc
        
    }//end TypeStats class

     /// <summary>
     /// provides functionality to a lot of forms.
     /// more will be added as needed.
     /// all static to be able to use with instination
     /// </summary>
    public class TypeFunctions {
        /*
         *  created 19/10/2016
         * 
         */

        //assinging magic numbers
        public static int lenghtOfArray = 17;

        /// <summary>
        /// inputs two types then returns the final type (defensive)
        /// </summary>
        /// <param name="typeOne"></param>
        /// <param name="typeTwo"></param>
        /// <returns></returns>
        public static double[] DualTypeDef(double[] typeOne, double[] typeTwo) {
            double[] finalType = new double[typeOne.Length];

            for (int i = lenghtOfArray; 0 <= i; i--) {
                finalType[i] = typeOne[i] * typeTwo[i];
            }

            return finalType;
        }// end DualType

        /// <summary>
        /// inputs two types the reutns final type (offensive)
        /// </summary>
        /// <param name="typeOne"></param>
        /// <param name="typeTwo"></param>
        /// <returns></returns>
        public static double[] DualTypeOff(double[] typeOne, double[] typeTwo) {
            double[] resultTypes = new double[typeOne.Length];
            for (int i = 0; i < typeOne.Length; i++) {
                resultTypes[i] = Math.Max(typeOne[i], typeTwo[i]);
            }
            return resultTypes;
        }

        /// <summary>
        /// converts a string input to the type array (defensive)
        /// </summary>
        /// <param name="iint"></param>
        /// <returns></returns>
        public static double[] StringToTypeDef(int iint) {
            double[] empty = new double[0];
            switch (iint) {
                #region cases for each type
                case 0:
                    return Normal.NormalArrayDef;
                case 1:
                    return Fire.FireArrayDef;
                case 2:
                    return Water.WateArrayDef;
                case 3:
                    return Electric.ElecArrayDef;
                case 4:
                    return Grass.GrasArrayDef;
                case 5:
                    return Ice.IceeArrayDef;
                case 6:
                    return Fighting.FighArrayDef;
                case 7:
                    return Poison.PoisArrayDef;
                case 8:
                    return Ground.GrouArrayDef;
                case 9:
                    return Flying.FlyiArrayDef;
                case 10:
                    return Psychic.PsycArrayDef;
                case 11:
                    return Bug.BuggArrayDef;
                case 12:
                    return Rock.RockArrayDef;
                case 13:
                    return Ghost.GhosArrayDef;
                case 14:
                    return Dragon.DragArrayDef;
                case 15:
                    return Dark.DarkArrayDef;
                case 16:
                    return Steel.SteeArrayDef;
                case 17:
                    return Fairy.FairArrayDef;
                case 18:
                    return Null.NullArrayDef;
                    #endregion
            }
            return empty;
        }//end StringToTypeDef

        /// <summary>
        /// converts a string input to the type array (offensive)
        /// </summary>
        /// <param name="iint"></param>
        /// <returns></returns>
        public static double[] StringToTypeOff(int iint) {
            double[] empty = new double[0];
            switch (iint) {
                #region cases for each type
                case 0:
                    return Normal.NormalArrayOff;
                case 1:
                    return Fire.FireArrayOff;
                case 2:
                    return Water.WateArrayOff;
                case 3:
                    return Electric.ElecArrayOff;
                case 4:
                    return Grass.GrasArrayOff;
                case 5:
                    return Ice.IceeArrayOff;
                case 6:
                    return Fighting.FighArrayOff;
                case 7:
                    return Poison.PoisArrayOff;
                case 8:
                    return Ground.GrouArrayOff;
                case 9:
                    return Flying.FlyiArrayOff;
                case 10:
                    return Psychic.PsycArrayOff;
                case 11:
                    return Bug.BuggArrayOff;
                case 12:
                    return Rock.RockArrayOff;
                case 13:
                    return Ghost.GhosArrayOff;
                case 14:
                    return Dragon.DragArrayOff;
                case 15:
                    return Dark.DarkArrayOff;
                case 16:
                    return Steel.SteeArrayOff;
                case 17:
                    return Fairy.FairArrayOff;
                case 18:
                    return Null.NullArrayOff;
                    #endregion
            }
            return empty;
        }//end StringToTypeOff

        /// <summary>
        /// return a score for dual typing (defensive)
        /// </summary>
        /// <param name="typeOne"></param>
        /// <param name="typeTwo"></param>
        /// <returns></returns>
        public static double DualTypeScoreDef(double[] typeOne, double[] typeTwo) {
            double[] resultType = Typess.TypeFunctions.DualTypeDef(typeOne, typeTwo);
            return resultType.Sum() - 13.25;
        }//end DualTypeScoreDef

        /// <summary>
        /// return a score for dual typing (offensive)
        /// </summary>
        /// <param name="typeOne"></param>
        /// <param name="typeTwo"></param>
        /// <returns></returns>
        public static double DualTypeScoreOff(double[] typeOne, double[] typeTwo) {
            double[] resultTypes = new double[typeOne.Length];
            for (int i = 0; i < typeOne.Length; i++) {
                resultTypes[i] = Math.Max(typeOne[i], typeTwo[i]);
            }
            return resultTypes.Sum();
        }// end DualTypeScoreOff
    }//end TypeFunctions class
}