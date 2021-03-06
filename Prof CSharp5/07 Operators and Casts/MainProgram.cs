﻿using System;
using Cons = System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleA1._07_Operators_and_Casts
{
    struct Items
    {
        public string Descp;
        public int AppPrice;
    }
    class MainProgram
    {
        public static void Main()
        {
            //Type Cons
            long val = 300000000000;
            try {
                int i = checked((int)val);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            ushort c = 43;
            char sym = (char)c;
            Console.WriteLine(sym);

            double[] Prices = { 10.90, 20.25, 15.33, 34.99 };

            Items items;
            items.Descp = "Red Bottle";
            items.AppPrice = (int)(Prices.Average());


            try
            {
                int? a = null;
                int b = checked((int)a);
            }
            catch (Exception)
            {
                
            }

            Boolean res = BoxUnBox.Box(false);

            res = TypeSafe.sTypeSafe();

            OpOverloading oL = new OpOverloading();
            res = oL.eTest(null);
            res = oL.eTest("Dave");

            MVector sVec = new MVector(1, 2, 3);
            MVector eVec = new MVector(4, 5, -3);
            MVector rVec = sVec + eVec;
            Cons.WriteLine($"sVec {sVec.ToString()} + eVec {eVec.ToString()} = rVec {rVec.ToString()}.");

            rVec = 2 * sVec;
            rVec = (sVec * 3) * 3;

            double r = sVec * eVec;
            Cons.WriteLine($"{sVec} * {eVec} in dot notation = {r}");

            rVec -= eVec;
            Cons.WriteLine($"rVec -= eVec gives us {rVec}");

            Cur w = new Cur(32200,33);
            SimpleCur sCur = new SimpleCur("Dave", w);

            float aAmount = 4500.12f;
            Cur cAmount = (Cur) aAmount;

            //The Issue
            try
            {
                Cur bal = new Cur(50, 35);
                float fBal = bal;
                bal = (Cur) fBal;

                checked   //This is not needed when Checked in Cur operator.
                {
                    bal = (Cur) (-555.33);  
                }
            }
            catch (Exception ex)
            {
                Cons.WriteLine("Exception is {0}", ex.Message);
            }


            //More Boxing unBoxing
            Boolean res2 = BoxUnBox.Box(true);

        }
    }
}
