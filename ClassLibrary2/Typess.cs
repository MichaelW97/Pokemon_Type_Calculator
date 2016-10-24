using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeList;
using Typess;

namespace Typess {
    public class TypeStats {

        /*
         *  created 19/10/2016
         * 
         */

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

    public class TypeFunctions {
        /*
         *  created 19/10/2016
         * 
         */
        /*
       public void labeltypes() {
           #region assigning values for table labels
           label1.Text = Typess.TypeStats.AllTypes.NORMAL.ToString();
           label2.Text = Typess.TypeStats.AllTypes.FIRE.ToString();
           label3.Text = Typess.TypeStats.AllTypes.WATER.ToString();
           label4.Text = Typess.TypeStats.AllTypes.ELECTIC.ToString();
           label5.Text = Typess.TypeStats.AllTypes.GRASS.ToString();
           label6.Text = Typess.TypeStats.AllTypes.ICE.ToString();
           label7.Text = Typess.TypeStats.AllTypes.FIGHTING.ToString();
           label8.Text = Typess.TypeStats.AllTypes.POISON.ToString();
           label9.Text = Typess.TypeStats.AllTypes.GROUND.ToString();
           label10.Text = Typess.TypeStats.AllTypes.FLYING.ToString();
           label11.Text = Typess.TypeStats.AllTypes.PSYCHIC.ToString();
           label12.Text = Typess.TypeStats.AllTypes.BUG.ToString();
           label13.Text = Typess.TypeStats.AllTypes.ROCK.ToString();
           label14.Text = Typess.TypeStats.AllTypes.GHOST.ToString();
           label15.Text = Typess.TypeStats.AllTypes.DRAGON.ToString();
           label16.Text = Typess.TypeStats.AllTypes.DARK.ToString();
           label17.Text = Typess.TypeStats.AllTypes.STEEL.ToString();
           label18.Text = Typess.TypeStats.AllTypes.FAIRY.ToString();
           #endregion
       }
       */



        /// <summary>
        /// inputs two types then returns the final type
        /// </summary>
        /// <param name="typeOne"></param>
        /// <param name="typeTwo"></param>
        /// <returns></returns>
        public static double[] DualType(double[] typeOne, double[] typeTwo) {
            double[] finalType = new double[typeOne.Length];

            for (int i = 17; 0 <= i; i--) {
                finalType[i] = typeOne[i] * typeTwo[i];
            }

            return finalType;
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
                    return Psychih.PsycArrayDef;
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
                    return Psychih.PsycArrayOff;
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
        }

        public static double DualTypeScoreDef(double[] typeOne, double[] typeTwo) {
            double[] resultType = Typess.TypeFunctions.DualType(typeOne, typeTwo);
            return resultType.Sum();
        }

        public static double DualTypeScoreOff(double[] typeOne, double[] typeTwo) {
            double[] resultType = Typess.TypeFunctions.DualType(typeOne, typeTwo);
            foreach (double i in resultType) {
                if (resultType[0] == 4) {
                    resultType[0] = 2;
                }
                if (resultType[0] == 0.25) {
                    resultType[0] = 0;
                }
                if (resultType[0] == 0.5) {
                    resultType[0] = 1;
                }
            }
            return resultType.Sum();
        }

            /*
            double[] resultType = Typess.TypeFunctions.DualType(typeOne, typeTwo);
            foreach (double i in resultType) {
                double j = i;
                if (j == 4) {
                    j = 2;
                }
                if (j == 0.25) {
                    j = 0;
                }
                if (j == 0.5) {
                    j = 1;
                }
                
            }
            return resultType.Sum();
            */
    }
}