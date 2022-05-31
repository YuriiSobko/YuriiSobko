using System;

namespace CSharp_Net_module1_1_2_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use "Debugging" and "Watch" to study variables and constants

            //1) declare variables of all simple types:
            //bool, char, byte, sbyte, short, ushort, int, uint, long, ulong, decimal, float, double
            // their names should be: 
            //boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0
            // initialize them with 1, 100, 250.7, 150, 10000, -25, -223, 300, 100000.6, 8, -33.1
            // Check results (types and values). Is possible to do initialization?
            // Fix compilation errors (change values for impossible initialization)

            bool boo = false;
            char ch = 'a';
            byte b = 1;
            sbyte sb = 100;
            short sh = -25;
            ushort ush = 8;
            int i = -223;
            uint ui = 150;
            long l = 300;
            ulong ul = 10000;
            decimal de = -33.1M;
            float fl = 100000.6f;
            double d0 = 250.7;

            //2) declare constants of int and double. Try to change their values.

            const int coIn = 20;
            const double coDo = 50.01;

            //3) declare 2 variables with var. Initialize them 20 and 20.5. Check types. 
            // Try to reinitialize by 20.5 and 20 (change values). What results are there?
           
            // IMPOSSIBLE TO REINITIALIZE  vIn variable as it took int type but for vDo it is possible 
            var vIn = 20;
            var vDo = 20.5;
            

            // 4) declare variables of System.Int32 and System.Double.
            // Initialize them by values of i and d0. Is it possible?
            // POSSIBLE
            System.Int32 syIn = -223;
            System.Double syDo = 250.7;


            if (true)
            {
                // 5) declare variables of int, char, double 
                // with names i, ch, do
                // is it possible?

                //NOT POSSIBLE - we cannot declare variable with already existed name
                //int i;
                //char ch;
                //double d0;


                // 6) change values of variables from 1)

                boo = true;
                ch = '1';
                b = 127;
                sb = 10;
                sh = 255;
                ush = 400;
                i = 30;
                ui = 1555;
                l = -2587;
                ul = 20578;
                de = 3356.45m;
                fl = 6023.12f;
                d0 = -2458.35;

            }

            // 7)check values of variables from 1). Are they changed? Think, why
          
            // THEY ARE CHANGED - it is not forbiden
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}", boo, ch, b, sb, sh, ush, i, ui, l, ul, de, fl, d0);

            // 8) use implicit/ explicit conversion to convert variables from 1). 
            // Is it possible? 

            // Fix compilation errors (in case of impossible conversion commemt that line).
           
            // ===== EXPLICIT CONVERSION =====
            // int -> char
            char ch_2 = (char)i;
            Console.WriteLine("Value of ch_2: {0}", ch_2);
            Console.WriteLine("Type of ch_2: {0}", ch_2.GetType());
           
            // bool -> short
            // short sh_2 = (short)boo;
            // Console.WriteLine("Value of sh_2: {0}", sh_2);
            // Console.WriteLine("Type of sh_2: {0}", sh_2.GetType());

            // double -> long
            long l_2 = (long)d0;
            Console.WriteLine("Value of l_2: {0}", l_2);
            Console.WriteLine("Type of l_2: {0}", l_2.GetType());

           //  float -> char 
            char ch_3 = (char)fl;
            Console.WriteLine("Value of ch_3: {0}", ch_3);
            Console.WriteLine("Type of ch_3: {0}", ch_3.GetType());

            // decimal -> double
            double d_1 = (double)de;
            Console.WriteLine("Value of d_1: {0}", d_1);
            Console.WriteLine("Type of d_1: {0}", d_1.GetType());

            // byte -> uint
            uint ui_1 = (uint)b;
            Console.WriteLine("Value of ui_1: {0}", ui_1);
            Console.WriteLine("Type of ui_1: {0}", ui_1.GetType());

            // ulong -> sbyte
            sbyte sb_2 = (sbyte)ul;
            Console.WriteLine("Value of sb_2: {0}", sb_2);
            Console.WriteLine("Type of sb_2: {0}", sb_2.GetType());

            // ===== IMPLICIT CONVERSION =====

          //  bool bol = d0;
          //  char cha = boo;
          //  byte by = ch;
          //  sbyte sby = b;
            short shor = sb;
            int inn = sh;
          //  uint uinn = i;
            long lon = ui;
          //  ulong ulon = l;
            decimal dec = ul;
          //  float flo = de;
            double doub = fl;


            // 9) and reverse conversion with fixing compilation errors.

            // ===== EXPLICIT CONVERSION =====

            // char -> int   
            int in_a = (int)ch; 
            Console.WriteLine("Value of in_a: {0}", in_a);
            Console.WriteLine("Type of in_a: {0}", in_a.GetType());

            //short -> bool
            //bool boo_b = (bool)sh;
            //Console.WriteLine("Value of boo_b: {0}", boo_b);
            //Console.WriteLine("Type of boo_b: {0}", boo_b.GetType());

            // long -> double
            double d0_a = (double)l;
            Console.WriteLine("Value of d0_a: {0}", d0_a);
            Console.WriteLine("Type of d0_a: {0}", d0_a.GetType());

            //  char -> float 
            float fl_a= (float)ch;
            Console.WriteLine("Value of fl_a: {0}", fl_a);
            Console.WriteLine("Type of fl_a: {0}", fl_a.GetType());

            // double -> decimal
            decimal de_a = (decimal)d0;
            Console.WriteLine("Value of de_a: {0}", de_a);
            Console.WriteLine("Type of de_a: {0}", de_a.GetType());

            // uint -> byte
            byte b_a = (byte)ui;
            Console.WriteLine("Value of ui_1: {0}", ui_1);
            Console.WriteLine("Type of ui_1: {0}", ui_1.GetType());

            // sbyte -> long
            long l_a = (long)sb;
            Console.WriteLine("Value of l_a: {0}", l_a);
            Console.WriteLine("Type of l_a: {0}", l_a.GetType());

            //double doub_1 = boo;
            //bool bol_1 = ch;
            //char cha_1 = b;
            //byte by_1 = sb;
            //sbyte sby_1 = sh;
            //short shp_1 = i;
            //int inn_1 = ui;
            //uint uinn_1 = l;
            //long lon_1 = ul;
            //ulong ulon_1 = de;
            //decimal dec_1 = fl;
            //float flo_1 = d0;


            // 10) declare int nullable value. Initialize it with 'null'. 
            // Try to initialize variable i with 'null'. Is it possible? - IMPOSSIBLE AS HAS DOFOULT VALUE
            int? abc = null;
           // i = null;



        }
    }
}
