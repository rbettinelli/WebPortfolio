using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Collections;

namespace WebPortfolio
{
    public class ClsCompareFileInfo : IComparer
    { 
        public int Compare(object x, object y)
        {
            FileInfo file1;
            FileInfo file2;

            file1 = (FileInfo)x;
            file2 = (FileInfo)y;

            return DateTime.Compare(file2.CreationTime, file1.CreationTime);
        }
    }
}

