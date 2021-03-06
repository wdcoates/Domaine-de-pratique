﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace ConsoleA1._00_Common
{
    public static class StringExtenders
    {
        public static void Boots(this string b)
        {
            Console.WriteLine($"Crotch, Thigh, Knee, Calf, Ankle:{b}.");
        }

        public static string FirstName(this string name)
        {
            int ix = name.LastIndexOf(' ');
            return name.Substring(0, ix);
        }

        public static string LastName(this string name)
        {
            int ix = name.LastIndexOf(' ');
            return name.Substring(ix + 1);
        }

        public static string Initials(this string name)
        {
            int ix = name.LastIndexOf(' ');
            return name.Substring(0,1)+(ix > 0 ? " "+name.Substring(ix + 1, 1):"");
        }

        public static string FullNameToString(this Person p)
        {
            return String.Concat(p.FirstName, " ", p.LastName);
        }

    }
}
