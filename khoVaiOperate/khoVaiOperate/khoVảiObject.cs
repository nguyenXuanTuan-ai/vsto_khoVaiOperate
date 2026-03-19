using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace khoVaiOperate
{
    public static class khoVảiObject
    {
        public static class sheetĐọcThẻKho
        {
            public static Excel.Worksheet thisSheet => Globals.đọcThẻKho.InnerObject;

        }
    }
}
