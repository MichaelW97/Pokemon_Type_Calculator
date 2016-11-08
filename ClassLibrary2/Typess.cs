using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeList;
using Typess;

namespace Typess {
    /// <summary>
    /// sort of failed in implimenting this the way i wanted. a few things depend on this and more will in the future.
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
     /// all static to be able to use without instination
     /// </summary>
    public class TypeFunctions {
        /*
         *  created 19/10/2016
         * 
         */

        //assinging magic numbers
        public static int lenghtOfArray = 17;

        /// <summary>
        /// inputs two types the reutns final type (offensive)
        /// </summary>
        /// <param name="typeOne"></param>
        /// <param name="typeTwo"></param>
        /// <returns></returns>
        public static double[] DualType(double[] typeOne, double[] typeTwo, string offdef) {
            double[] resultTypes = new double[typeOne.Length];
            if (offdef == "off") {
                if (typeOne != TypeList.Null.NullArrayOff || typeTwo != TypeList.Null.NullArrayOff) {
                    for (int i = 0; i < typeOne.Length; i++) {
                        resultTypes[i] = Math.Max(typeOne[i], typeTwo[i]);
                    }
                }
                if (typeOne == TypeList.Null.NullArrayOff) {
                    for (int i = 0; i < typeOne.Length; i++) {
                        resultTypes[i] = typeOne[i];
                    }
                }
                if (typeTwo == TypeList.Null.NullArrayOff) {
                    for (int i = 0; i < typeOne.Length; i++) {
                        resultTypes[i] = typeTwo[i];
                    }
                }
            }
            if (offdef == "def") {
                for (int i = lenghtOfArray; 0 <= i; i--) {
                    resultTypes[i] = typeOne[i] * typeTwo[i];
                }
            }
            return resultTypes;
        }

        
        /// <summary>
        /// converts a string input to the type array
        /// dependins on offdef for which to use
        /// </summary>
        /// <param name="iint"></param>
        /// <returns></returns>
        public static double[] StringToType(int iint, string Offdef) {
            double[] empty = new double[0];
            if (Offdef == "off") {
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
            }
            if (Offdef == "def") {
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
            }
        }//end StringToType

        /// <summary>
        /// return a score for dual typing (defensive)
        /// </summary>
        /// <param name="typeOne"></param>
        /// <param name="typeTwo"></param>
        /// <returns></returns>
        public static double DualTypeScoreDef(double[] typeOne, double[] typeTwo) {
            double[] resultType = Typess.TypeFunctions.DualType(typeOne, typeTwo, "def");
            return resultType.Sum() - 13.25;
        }//end DualTypeScoreDef

        /// <summary>
        /// return a score for dual typing (offensive)
        /// </summary>
        /// <param name="typeOne"></param>
        /// <param name="typeTwo"></param>
        /// <returns></returns>
        public static double DualTypeScoreOff(int typeOne, int typeTwo, string offdef) {
            double[] resultTypes;
            double typeOneD = StringToTypeOff(1);
            double typeTwoD = StringToTypeOff(1);
            if (offdef == "off") {
                if (typeOneD != TypeList.Null.NullArrayOff || typeTwoD != TypeList.Null.NullArrayOff) {
                    for (int i = 0; i < typeOneD.Length; i++) {
                        resultTypes[i] = Math.Max(typeOneD[i], typeTwoD[i]);
                    }
                }
                if (typeOneD == TypeList.Null.NullArrayOff) {
                    for (int i = 0; i < typeOneD.Length; i++) {
                        resultTypes[i] = typeOneD[i];
                    }
                }
                if (typeTwoD == TypeList.Null.NullArrayOff) {
                    for (int i = 0; i < typeOneD.Length; i++) {
                        resultTypes[i] = typeTwoD[i];
                    }
                }
                return Math.Abs(resultTypes.Sum() - 27);
            }
            if (offdef == "def") {
                double[] resultType = Typess.TypeFunctions.DualType(typeOne, typeTwo, "def");
                return resultType.Sum() - 13.25;
            }
        }// end DualTypeScore
    }//end TypeFunctions class
}