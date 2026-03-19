using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
namespace khoVaiOperate
{
    internal class CommonInternalFunction
    {
        public static void setBorderTitle(Excel.Range range)
        {
            range.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Excel.XlBordersIndex.xlInsideHorizontal].Weight = Excel.XlLineStyle.xlContinuous;
        }
        public static void setBorderContent(Excel.Range range)
        {
            range.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlContinuous;
            range.Borders[Excel.XlBordersIndex.xlInsideHorizontal].Weight = Excel.XlLineStyle.xlContinuous;
            range.Borders[Excel.XlBordersIndex.xlInsideHorizontal].Weight = Excel.XlBorderWeight.xlHairline;
        }
        public static void setBorderAround(Excel.Range inputRange)
        {
            inputRange.Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = Excel.XlLineStyle.xlContinuous;
            inputRange.Borders[Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
            inputRange.Borders[Excel.XlBordersIndex.xlEdgeLeft].LineStyle = Excel.XlLineStyle.xlContinuous;
            inputRange.Borders[Excel.XlBordersIndex.xlEdgeRight].LineStyle = Excel.XlLineStyle.xlContinuous;
            inputRange.Borders[Excel.XlBordersIndex.xlInsideVertical].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
            inputRange.Borders[Excel.XlBordersIndex.xlInsideHorizontal].LineStyle = Excel.XlLineStyle.xlLineStyleNone;
        }


        public static void informConnectionStable()
        {
            Ribbon1.SetConnectionLabel("Có kết nối");
        }
        public static void informDisconnection()
        {
            Ribbon1.SetConnectionLabel("Mất kết nối");
        }
        public static bool isValidDate(Excel.Range inputRange)
        {
            bool result = false;
            DateTime parsedDate;
            if (inputRange.Value2 != null)
            {
                if (inputRange.Value2 is double oaDate)
                {
                    if (oaDate % 1 == 0)
                        result = true;
                }
                else if (DateTime.TryParse(inputRange.Value2.ToString(), out parsedDate))
                {
                    if (parsedDate.TimeOfDay == TimeSpan.Zero)
                        result = true;
                }
            }
            return result;
        }
        public static DateTime getDateValue(Excel.Range inputRange)
        {
            object value = inputRange.Value2;
            DateTime date = DateTime.MinValue;
            if (value != null)
            {
                if (value is double oaDate)
                {
                    date = DateTime.FromOADate(oaDate);
                }
                else if (DateTime.TryParse(value.ToString(), out DateTime parsed))
                {
                    date = parsed;
                }
            }
            return date;
        }
        public static bool IsExcelInEditMode()
        {
            try
            {
                Globals.ThisWorkbook.Application.Interactive = false;
                Globals.ThisWorkbook.Application.Interactive = true;
                return false;
            }
            catch
            {
                return true;
            }
        }
        public static object lookUpArray(object inputValue, List<object> findList, List<object> resultList)
        {
            for (int i = 0; i < findList.Count; i++)
            {
                if (inputValue.Equals(findList[i]) && i < resultList.Count)
                {
                    return resultList[i];
                }
            }
            return null;
        }
    }
}
