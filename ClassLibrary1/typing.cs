using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypingLibrary;

namespace TypingLibrary {
    public static class Typing {

        /*  created 17/10/2016
        *   by: Michael W
        *   for: calculating pokemon typings
        */

        ///defining variables/consts and the 2d array

        //enum for easier name assosiation in imlimentation
        public enum Types { Normal = 0 , Fire = 1, Water = 2, Electic = 3, Grass = 4, Ice = 5, Fighting = 6, Poison = 7, Ground = 8, Flying = 9, Pyschic = 10, Bug = 11, Rock = 12, Ghost = 13, Dragon = 14, Dark = 15, Steel = 16, Fairy = 17, nulltype = 18};

        //the array
        public static double[,] typeChart = new double[17, 17];

        //null array for when pokemon has only one type, enter null for second type
        public static double[] nulltype = new double[17] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        //values for type effectiveness and #goodprogrammingpractice
        
               

        ///methods for helping fill the 2d array

        /// <summary>
        /// sets the defualt types for type chart
        /// </summary>
        public static void setTypeDefault() {
            for (int y = 0; y < 18; y++) {
                for (int x = 0; x < 18; x++) {
                    typeChart[x, y] = 1;
                }
            }
        }// end setTypeDefault


        /// <summary>
        /// sets the values for all types and fills typeChart correctly
        /// </summary>
        public static void SetAllTypes() {
            setTypeDefault();
            #region calling type setting methods
            setBug();
            setDark();
            setDragon();
            setElectic();
            setFairy();
            setFighting();
            setFire();
            setFlying();
            setGhost();
            setGrass();
            setGround();
            setIce();
            setNormal();
            setPoison();
            setPsychic();
            setRock();
            setSteel();
            setWater();
            #endregion
        }//end SetAllTypes


        /// <summary>
        /// inputs two types then outputs the dual type stats
        /// </summary>
        /// <param name="typeOne"></param>
        /// <param name="typeTwo"></param>
        /// <returns></returns>
        public static double[] DualType(double[] typeOneDdefensiveArray, double[] typeTwoDefensiveArray) {
            double[] dualType = new double[17];
            for (int i = 18; i > 0; i--) {
                dualType[i] = typeOneDdefensiveArray[i] * typeTwoDefensiveArray[i];
            }
            return dualType;
        }//end DualType


        /// <summary>
        /// converts an object entered to the appropriate array for the drop downs when picking types
        /// </summary>
        /// <param name="entered"></param>
        /// <returns></returns>
        public static double[] ObjToType (string entered) {

            //for()

            
            switch (entered) {


                #region cases for all types
                case "Normal":
                    return NormalDef;
                case "Fire":
                    return FireDef;
                        /*
                case 2:
                    return WaterDef;
                case 3:
                    return ElecticDef;
                case 4:
                    return GrassDef;
                case 5:
                    return IceDef;
                case 6:
                    return FightingDef;
                case 7:
                    return PoisonDef;
                case 8:
                    return GroundDef;
                case 9:
                    return FlyingDef;
                case 10:
                    return PsychicDef;
                case 11:
                    return BugDef;
                case 12:
                    return RockDef;
                case 13:
                    return GhostDef;
                case 14:
                    return DragonDef;
                case 15:
                    return DarkDef;
                case 16:
                    return SteelDef;
                case 17:
                    return FairDef;
                    */
                    /*
                case "Normal":
                    return NormalDef;
                case "Fire":
                    return FireDef;
                case "Water":
                    return WaterDef;
                case "Electic":
                    return ElecticDef;
                case "Grass":
                    return GrassDef;
                case "Ice":
                    return IceDef;
                case "Fighting":
                    return FightingDef;
                case "Poison":
                    return PoisonDef;
                case "Ground":
                    return GroundDef;
                case "Flying":
                    return FlyingDef;
                case "Pyschic":
                    return PsychicDef;
                case "Bug":
                    return BugDef;
                case "Rock":
                    return RockDef;
                case "Ghost":
                    return GhostDef;
                case "Dragon":
                    return DragonDef;
                case "Dark":
                    return DarkDef;
                case "Steel":
                    return SteelDef;
                case "Fairy":
                    return FairDef;
                */
                    #endregion
                    
                default:
                    return nulltype;
            }
        
        }//end ObjToType



        /// blocks of methods and assigning code for other methods

        #region defensive type arrays
        public static double[] NormalDef = typeChart.GetCol(0);
        public static double[] FireDef = typeChart.GetCol(1);
        public static double[] WaterDef = typeChart.GetCol(2);
        public static double[] ElecticDef = typeChart.GetCol(3);
        public static double[] GrassDef = typeChart.GetCol(4);
        public static double[] IceDef = typeChart.GetCol(5);
        public static double[] FightingDef = typeChart.GetCol(6);
        public static double[] PoisonDef = typeChart.GetCol(7);
        public static double[] GroundDef = typeChart.GetCol(8);
        public static double[] FlyingDef = typeChart.GetCol(9);
        public static double[] PsychicDef = typeChart.GetCol(10);
        public static double[] BugDef = typeChart.GetCol(11);
        public static double[] RockDef = typeChart.GetCol(12);
        public static double[] GhostDef = typeChart.GetCol(13);
        public static double[] DragonDef = typeChart.GetCol(14);
        public static double[] DarkDef = typeChart.GetCol(15);
        public static double[] SteelDef = typeChart.GetCol(16);
        public static double[] FairDef = typeChart.GetCol(17);
        #endregion

        #region offensive type arrays
        public static double[] NormalOff = typeChart.GetRow(0);
        public static double[] FireOff = typeChart.GetRow(1);
        public static double[] WaterlOff = typeChart.GetRow(2);
        public static double[] ElecticOff = typeChart.GetRow(3);
        public static double[] GrassOff = typeChart.GetRow(4);
        public static double[] IceOff = typeChart.GetRow(5);
        public static double[] FightingOff = typeChart.GetRow(6);
        public static double[] PoisonOff = typeChart.GetRow(7);
        public static double[] GroundOff = typeChart.GetRow(8);
        public static double[] FlyingOff = typeChart.GetRow(9);
        public static double[] PsychicOff = typeChart.GetRow(10);
        public static double[] BugOff = typeChart.GetRow(11);
        public static double[] RockOff = typeChart.GetRow(12);
        public static double[] GhostOff = typeChart.GetRow(13);
        public static double[] DragonOff = typeChart.GetRow(14);
        public static double[] DarkOff = typeChart.GetRow(15);
        public static double[] SteelOff = typeChart.GetRow(16);
        public static double[] FairOff = typeChart.GetRow(17);
        #endregion

        #region block of set types
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setNormal() {
            double NOEFFECT = typeChart[1, 14];
            //double SUPEREFFECTIVE = typeChart[1,];
            double NONEFFECTIVE = typeChart[1, 13] = typeChart[1, 17];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setFire() {
            //double NOEFFECT = typeChart[2,];
            double SUPEREFFECTIVE = typeChart[2, 5] = typeChart[2, 6] = typeChart[2, 12] = typeChart[2, 17];
            double NONEFFECTIVE = typeChart[2, 2] = typeChart[2, 3] = typeChart[2, 13] = typeChart[2, 15];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setWater() {
            //double NOEFFECT = typeChart[3,];
            double SUPEREFFECTIVE = typeChart[3, 2] = typeChart[3, 9] = typeChart[3, 13];
            double NONEFFECTIVE = typeChart[3, 3] = typeChart[3, 5] = typeChart[3, 15];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setElectic() {
            double NOEFFECT = typeChart[4, 9];
            double SUPEREFFECTIVE = typeChart[4, 3] = typeChart[4, 10];
            double NONEFFECTIVE = typeChart[4, 4] = typeChart[4, 5] = typeChart[4, 15];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setGrass() {
            //double NOEFFECT = typeChart[5,];
            double SUPEREFFECTIVE = typeChart[5, 3] = typeChart[4, 9] = typeChart[4, 13];
            double NONEFFECTIVE = typeChart[5, 2] = typeChart[5, 5] = typeChart[5, 8] = typeChart[5, 10] = typeChart[5, 12] = typeChart[5, 15] = typeChart[5, 17];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setIce() {
            //double NOEFFECT = typeChart[6,];
            double SUPEREFFECTIVE = typeChart[6, 5] = typeChart[6, 9] = typeChart[6, 10] = typeChart[6, 15];
            double NONEFFECTIVE = typeChart[6, 2] = typeChart[6, 3] = typeChart[6, 6] = typeChart[6, 17];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setFighting() {
            double NOEFFECT = typeChart[7, 14];
            double SUPEREFFECTIVE = typeChart[7, 1] = typeChart[7, 6] = typeChart[7, 13] = typeChart[7, 16] = typeChart[7, 17];
            double NONEFFECTIVE = typeChart[7, 8] = typeChart[7, 10] = typeChart[7, 11] = typeChart[7, 12] = typeChart[7, 18];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setPoison() {
            double NOEFFECT = typeChart[8, 17];
            double SUPEREFFECTIVE = typeChart[8, 5] = typeChart[8, 17];
            double NONEFFECTIVE = typeChart[8, 8] = typeChart[8, 9] = typeChart[8, 13] = typeChart[8, 14];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setGround() {
            double NOEFFECT = typeChart[9, 10];
            double SUPEREFFECTIVE = typeChart[9, 2] = typeChart[9, 4] = typeChart[9, 8] = typeChart[9, 13] = typeChart[9, 17];
            double NONEFFECTIVE = typeChart[9, 5] = typeChart[9, 12];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setFlying() {
            //double NOEFFECT = typeChart[10,];
            double SUPEREFFECTIVE = typeChart[10, 5] = typeChart[10, 7] = typeChart[10, 12];
            double NONEFFECTIVE = typeChart[10, 4] = typeChart[10, 13] = typeChart[10, 17];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setPsychic() {
            double NOEFFECT = typeChart[11, 16];
            double SUPEREFFECTIVE = typeChart[11, 7] = typeChart[11, 8];
            double NONEFFECTIVE = typeChart[11, 11] = typeChart[11, 17];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setBug() {
            //double NOEFFECT = typeChart[12,];
            double SUPEREFFECTIVE = typeChart[12, 5] = typeChart[12, 11] = typeChart[12, 16];
            double NONEFFECTIVE = typeChart[12, 2] = typeChart[12, 7] = typeChart[12, 8] = typeChart[12, 10] = typeChart[12, 14] = typeChart[12, 17] = typeChart[12, 18];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setRock() {
            //double NOEFFECT = typeChart[13,];
            double SUPEREFFECTIVE = typeChart[13, 2] = typeChart[13, 6] = typeChart[13, 10] = typeChart[13, 12];
            double NONEFFECTIVE = typeChart[13, 7] = typeChart[13, 9] = typeChart[13, 17];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setGhost() {
            double NOEFFECT = typeChart[14, 1];
            double SUPEREFFECTIVE = typeChart[14, 11] = typeChart[14, 14];
            double NONEFFECTIVE = typeChart[14, 16];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setDragon() {
            double NOEFFECT = typeChart[15, 18];
            double SUPEREFFECTIVE = typeChart[15, 15];
            double NONEFFECTIVE = typeChart[15, 17];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setDark() {
            //double NOEFFECT = typeChart[16,];
            double SUPEREFFECTIVE = typeChart[16, 11] = typeChart[16, 14];
            double NONEFFECTIVE = typeChart[16, 7] = typeChart[16, 16] = typeChart[16, 18];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setSteel() {
            //double NOEFFECT = typeChart[17,];
            double SUPEREFFECTIVE = typeChart[17, 7] = typeChart[17, 13] = typeChart[17, 18];
            double NONEFFECTIVE = typeChart[17, 2] = typeChart[17, 3] = typeChart[17, 4] = typeChart[17, 17];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setFairy() {
            //double NOEFFECT = typeChart[18,];
            double SUPEREFFECTIVE = typeChart[18, 7] = typeChart[18, 15] = typeChart[18, 16];
            double NONEFFECTIVE = typeChart[18, 2] = typeChart[18, 8] = typeChart[18, 17];
        }//end type
        #endregion

    }

    


    public static class MatrixExtensions {

        /*      created 28/04/2009
        *       by 'Stevo3000'
        *       for a user on stack overflow to allow them to copy rows/columns of 2d arrays to 1d arrays
        *       use here should be self explanatory, use in Typing for finding 1d defensive/offensive arrays from the main 2d array
        */      

        
        /// <summary>
        /// Returns the row with number 'row' of this matrix as a 1D-Array.
        /// </summary>
        public static T[] GetRow<T>(this T[,] matrix, int row) {
            var rowLength = matrix.GetLength(1);
            var rowVector = new T[rowLength];

            for (var i = 0; i < rowLength; i++)
                rowVector[i] = matrix[row, i];

            return rowVector;
        }



        /// <summary>
        /// Sets the row with number 'row' of this 2D-matrix to the parameter 'rowVector'.
        /// </summary>
        public static void SetRow<T>(this T[,] matrix, int row, T[] rowVector) {
            var rowLength = matrix.GetLength(1);

            for (var i = 0; i < rowLength; i++)
                matrix[row, i] = rowVector[i];
        }



        /// <summary>
        /// Returns the column with number 'col' of this matrix as a 1D-Array.
        /// </summary>
        public static T[] GetCol<T>(this T[,] matrix, int col) {
            var colLength = matrix.GetLength(0);
            var colVector = new T[colLength];

            for (var i = 0; i < colLength; i++)
                colVector[i] = matrix[i, col];

            return colVector;
        }



        /// <summary>
        /// Sets the column with number 'col' of this 2D-matrix to the parameter 'colVector'.
        /// </summary>
        public static void SetCol<T>(this T[,] matrix, int col, T[] colVector) {
            var colLength = matrix.GetLength(0);

            for (var i = 0; i < colLength; i++)
                matrix[i, col] = colVector[i];
        }
    }
}
