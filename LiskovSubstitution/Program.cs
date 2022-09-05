﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var liksubstitution = new LikSubFile();
            liksubstitution.LoadFileData();            

            var likswritefile = new WritableFile();
            likswritefile.LoadFileData();
            likswritefile.SaveFileData();

            var projectfileobj = new ReadOnlyFile();
            projectfileobj.SaveFileData();

            Console.ReadLine();

        }
    }
}
