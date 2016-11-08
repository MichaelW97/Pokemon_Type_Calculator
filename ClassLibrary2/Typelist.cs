using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Typess;

namespace TypeList {
    /// <summary>
    /// this space is defining the literal value for the types.
    /// not entirly happy with this but its working so its fine.
    /// i would have liked if the classes inherited TypesStats and would be able to call Normal.Defensive ...
    /// that would then return the correct array.
    /// </summary>
    #region defining types with arrays
    public class Normal {
        /////////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] NormalArrayDef = new double[18] { 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1 };
        /////////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] NormalArrayOff = new double[18] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0.5, 0, 1, 1, 0.5, 1 };
    }
    public class Fire {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        //static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] FireArrayDef = new double[18] { b, c, a, b, c, c, b, b, c, b, b, c, a, b, b, b, c, c };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] FireArrayOff = new double[18] { b, c, c, b, a, a, b, b, b, b, b, a, c, b, c, b, a, b };

    }
    public class Water {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        //static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] WateArrayDef = new double[18] { b, c, c, a, a, c, b, b, b, b, b, b, b, b, b, b, c, b };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] WateArrayOff = new double[18] { b, a, c, b, c, b, b, b, a, b, b, b, a, b, c, b, b, b };

    }
    public class Electric {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] ElecArrayDef = new double[18] { b, b, b, c, b, b, b, b, a, c, b, b, b, b, b, b, c, b };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] ElecArrayOff = new double[18] { b, b, a, c, c, b, b, b, d, a, b, b, b, b, c, b, b, b };

    }
    public class Grass
        {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        //static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] GrasArrayDef = new double[18] { b, a, c, c, c, a, b, a, c, a, b, a, b, b, b, b, b, b };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] GrasArrayOff = new double[18] { b, c, a, b, c, b, b, c, a, c, b, c, a, b, c, b, c, b };

    }
    public class Ice {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        //static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] IceeArrayDef = new double[18] { b, a, b, b, b, c, a, b, b, b, b, b, a, b, b, b, b, b };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] IceeArrayOff = new double[18] { b, c, c, b, a, c, b, b, a, a, b, b, b, b, a, b, c, b };

    }
    public class Fighting {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] FighArrayDef = new double[18] { b, b, b, b, b, b, b, b, b, a, a, c, c, b, b, c, b, a };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] FighArrayOff = new double[18] { a, b, b, b, b, a, b, c, b, c, c, c, a, d, b, a, a, b };

    }
    public class Poison {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] PoisArrayDef = new double[18] { b, b, b, b, c, b, c, c, a, b, a, c, b, b, b, b, b, c };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] PoisArrayOff = new double[18] { b, b, b, b, a, b, b, c, c, b, b, b, c, c, b, b, d, a };

    }
    public class Ground {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] GrouArrayDef = new double[18] { b, b, a, d, a, a, b, c, b, b, b, b, c, b, b, b, b, b };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] GrouArrayOff = new double[18] { b, a, b, a, c, b, b, a, b, d, b, c, a, b, b, b, a, b };
    }
    public class Flying {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] FlyiArrayDef = new double[18] { b, b, b, a, c, a, c, b, d, b, b, c, a, b, b, b, b, b };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] FlyiArrayOff = new double[18] { b, b, b, c, a, b, a, b, b, b, b, a, c, b, b, b, c, b };

    }
    public class Psychic { 

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] PsycArrayDef = new double[18] { b, b, b, b, b, b, c, b, b, b, c, a, b, a, b, c, b, b };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] PsycArrayOff = new double[18] { b, b, b, b, b, b, a, a, b, b, c, b, b, b, b, d, c, b };

    }
    public class Bug {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        //static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] BuggArrayDef = new double[18] { b, a, b, b, c, b, c, b, c, a, b, b, a, b, b, b, b, b };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] BuggArrayOff = new double[18] { b, c, b, b, a, b, c, c, b, c, a, b, b, c, b, a, c, c };

    }
    public class Rock {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        //static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] RockArrayDef = new double[18] { c, c, a, b, a, b, a, c, a, c, b, b, b, b, b, b, a, b };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] RockArrayOff = new double[18] { b, a, b, b, b, a, c, b, c, a, b, a, b, b, b, b, c, b };

    }
    public class Ghost {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] GhosArrayDef = new double[18] { d, b, b, b, b, b, d, c, b, b, b, c, b, a, b, a, b, b };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] GhosArrayOff = new double[18] { d, b, b, b, b, b, b, b, b, b, a, b, b, a, b, c, b, b };

    }
    public class Dragon {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] DragArrayDef = new double[18] { b, c, c, c, c, a, b, b, b, b, b, b, b, b, a, b, b, a };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] DragArrayOff = new double[18] { b, b, b, b, b, b, b, b, b, b, b, b, b, b, a, b, c, d };

    }
    public class Dark {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] DarkArrayDef = new double[18] { b, b, b, b, b, b, a, b, b, b, d, a, b, c, b, c, b, a };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] DarkArrayOff = new double[18] { b, b, b, b, b, b, c, b, b, b, a, b, b, a, b, c, b, c };

    }
    public class Steel {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] SteeArrayDef = new double[18] { c, a, b, b, c, c, a, d, a, c, c, c, c, b, c, b, c, c };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] SteeArrayOff = new double[18] { b, c, c, c, b, a, b, b, b, b, b, b, a, b, b, b, c, a };

    }
    public class Fairy {

        static double a = 2;
        static double b = 1;
        static double c = 0.5;
        static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] FairArrayDef = new double[18] { b, b, b, b, b, b, c, a, b, b, b, c, b, b, d, c, a, b };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] FairArrayOff = new double[18] { b, c, b, b, b, b, a, c, b, b, b, b, b, b, a, a, c, b };

    }
    public class Null {

        //static double a = 2;
        static double b = 1;
        //static double c = 0.5;
        //static double d = 0;
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] NullArrayDef = new double[18] { b, b, b, b, b, b, b, b, b, b, b, b, b, b, b, b, b, b };
        ///////////////////////////////////////////////////////1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17 18
        public static double[] NullArrayOff = new double[18] { b, b, b, b, b, b, b, b, b, b, b, b, b, b, b, b, b, b };

    }
    #endregion
    //type Null is for when no second type is wanted
}
