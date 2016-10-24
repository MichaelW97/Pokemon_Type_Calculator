using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TypingLibrary;
//using System;

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
        public static double[,] typeChart = new double[18, 18];

        //null array for when pokemon has only one type, enter null for second type
        public static double[] nulltype = new double[17] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        //values for type effectiveness and #goodprogrammingpractice
        public static double NOEFFECT = 0;
        public static double SUPEREFFECTIVE = 2;
        public static double NONEFFECTIVE = 0.5;



        ///methods for helping fill the 2d array

        /// <summary>
        /// sets the defualt types for type chart
        /// </summary>
        public static void setTypeDefault() {
            for (int y = 0; y < 17; y++) {
                for (int x = 0; x < 17; x++) {
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
            double NOEFFECT = typeChart[0, 13];
            //double SUPEREFFECTIVE = typeChart[1,];
            double NONEFFECTIVE = typeChart[0, 12] = typeChart[0, 16];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setFire() {
            //double NOEFFECT = typeChart[2,];
            double SUPEREFFECTIVE = typeChart[1, 4] = typeChart[1, 5] = typeChart[1, 11] = typeChart[1, 16];
            double NONEFFECTIVE = typeChart[1, 1] = typeChart[1, 2] = typeChart[1, 12] = typeChart[1, 15];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setWater() {
            //double NOEFFECT = typeChart[3,];
            double SUPEREFFECTIVE = typeChart[2, 1] = typeChart[2, 8] = typeChart[2, 12];
            double NONEFFECTIVE = typeChart[2, 2] = typeChart[2, 4] = typeChart[2, 14];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setElectic() {
            double NOEFFECT = typeChart[3, 8];
            double SUPEREFFECTIVE = typeChart[3, 2] = typeChart[3, 9];
            double NONEFFECTIVE = typeChart[3, 3] = typeChart[3, 4] = typeChart[3, 14];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setGrass() {
            //double NOEFFECT = typeChart[5,];
            double SUPEREFFECTIVE = typeChart[4, 0] = typeChart[4, 8] = typeChart[4, 12];
            double NONEFFECTIVE = typeChart[4, 1] = typeChart[4, 4] = typeChart[4, 7] = typeChart[4, 9] = typeChart[4, 11] = typeChart[4, 14] = typeChart[4, 16];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setIce() {
            //double NOEFFECT = typeChart[6,];
            double SUPEREFFECTIVE = typeChart[5, 4] = typeChart[5, 8] = typeChart[5, 9] = typeChart[5, 14];
            double NONEFFECTIVE = typeChart[5, 1] = typeChart[5, 2] = typeChart[5, 5] = typeChart[5, 16];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setFighting() {
            double NOEFFECT = typeChart[7, 14];
            double SUPEREFFECTIVE = typeChart[6, 0] = typeChart[6, 5] = typeChart[6, 12] = typeChart[6, 15] = typeChart[6, 16];
            double NONEFFECTIVE = typeChart[6, 7] = typeChart[6, 9] = typeChart[6, 10] = typeChart[6, 11] = typeChart[6, 17];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setPoison() {
            double NOEFFECT = typeChart[7, 16];
            double SUPEREFFECTIVE = typeChart[7, 4] = typeChart[7, 17];
            double NONEFFECTIVE = typeChart[7, 7] = typeChart[7, 8] = typeChart[7, 12] = typeChart[7, 13];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setGround() {
            double NOEFFECT = typeChart[8, 9];
            double SUPEREFFECTIVE = typeChart[8, 1] = typeChart[8, 3] = typeChart[8, 7] = typeChart[8, 12] = typeChart[8, 16];
            double NONEFFECTIVE = typeChart[8, 4] = typeChart[8, 11];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setFlying() {
            //double NOEFFECT = typeChart[10,];
            double SUPEREFFECTIVE = typeChart[9, 4] = typeChart[9, 6] = typeChart[9, 11];
            double NONEFFECTIVE = typeChart[9, 3] = typeChart[9, 12] = typeChart[9, 16];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setPsychic() {
            double NOEFFECT = typeChart[10, 15];
            double SUPEREFFECTIVE = typeChart[10, 6] = typeChart[10, 7];
            double NONEFFECTIVE = typeChart[10, 10] = typeChart[10, 16];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setBug() {
            //double NOEFFECT = typeChart[12,];
            double SUPEREFFECTIVE = typeChart[11, 6] = typeChart[11, 10] = typeChart[11, 15];
            double NONEFFECTIVE = typeChart[11, 1] = typeChart[11, 6] = typeChart[11, 7] = typeChart[11, 9] = typeChart[11, 13] = typeChart[11, 16] = typeChart[11, 17];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setRock() {
            //double NOEFFECT = typeChart[13,];
            double SUPEREFFECTIVE = typeChart[12, 1] = typeChart[12, 5] = typeChart[12, 9] = typeChart[12, 11];
            double NONEFFECTIVE = typeChart[12, 6] = typeChart[12, 8] = typeChart[12, 16];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setGhost() {
            double NOEFFECT = typeChart[13, 0];
            double SUPEREFFECTIVE = typeChart[13, 10] = typeChart[13, 13];
            double NONEFFECTIVE = typeChart[13, 15];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setDragon() {
            double NOEFFECT = typeChart[14, 17];
            double SUPEREFFECTIVE = typeChart[14, 14];
            double NONEFFECTIVE = typeChart[14, 16];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setDark() {
            //double NOEFFECT = typeChart[16,];
            double SUPEREFFECTIVE = typeChart[15, 10] = typeChart[15, 13];
            double NONEFFECTIVE = typeChart[15, 6] = typeChart[15, 15] = typeChart[15, 17];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setSteel() {
            //double NOEFFECT = typeChart[17,];
            double SUPEREFFECTIVE = typeChart[16, 6] = typeChart[16, 12] = typeChart[16, 17];
            double NONEFFECTIVE = typeChart[16, 1] = typeChart[16, 2] = typeChart[16, 3] = typeChart[16, 16];
        }//end type
        /// <summary>
        /// sets values for type
        /// </summary>
        public static void setFairy() {
            //double NOEFFECT = typeChart[18,];
            double SUPEREFFECTIVE = typeChart[17, 6] = typeChart[17, 14] = typeChart[17, 15];
            double NONEFFECTIVE = typeChart[17, 1] = typeChart[17, 7] = typeChart[17, 16];
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
        public static double[] GetRow(this double[,] matrix, int row) {
            var rowLength = matrix.GetLength(1);
            var rowVector = new double[rowLength];

            for (var i = 0; i < rowLength; i++)
                rowVector[i] = matrix[row, i];

            return rowVector;
        }



        /// <summary>
        /// Sets the row with number 'row' of this 2D-matrix to the parameter 'rowVector'.
        /// </summary>
        public static void SetRow(this Double[,] matrix, int row, double[] rowVector) {
            var rowLength = matrix.GetLength(1);

            for (var i = 0; i < rowLength; i++)
                matrix[row, i] = rowVector[i];
        }



        /// <summary>
        /// Returns the column with number 'col' of this matrix as a 1D-Array.
        /// </summary>
        public static double[] GetCol(this double[,] matrix, int col) {
            var colLength = matrix.GetLength(0);
            var colVector = new double[colLength];

            for (var i = 0; i < colLength; i++)
                colVector[i] = matrix[i, col];

            return colVector;
        }



        /// <summary>
        /// Sets the column with number 'col' of this 2D-matrix to the parameter 'colVector'.
        /// </summary>
        public static void SetCol(this double[,] matrix, int col, double[] colVector) {
            var colLength = matrix.GetLength(0);

            for (var i = 0; i < colLength; i++)
                matrix[i, col] = colVector[i];
        }
    }


    /*
    public class AppException : Exception {
        public AppException(string message) : base(message) { }
        public AppException(string message, Exception inner) : base(message, inner) { }
    }

    public static class ExceptionExtensions {
        public static Exception GetOriginalException(this Exception ex) {
            if (ex.InnerException == null) return ex;

            return ex.InnerException.GetOriginalException();
        }
    }
    */
}
