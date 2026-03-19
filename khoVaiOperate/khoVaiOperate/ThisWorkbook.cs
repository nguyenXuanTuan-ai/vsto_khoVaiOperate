using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace khoVaiOperate
{
    public partial class ThisWorkbook
    {
        protected override Office.IRibbonExtensibility CreateRibbonExtensibilityObject()
        {
            return new Ribbon1();
        }
        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
            try
            {
                this.InnerObject.Unprotect("arhrJkekn36*");
                khoVảiObject.sheetĐọcThẻKho.thisSheet.Cells.Clear();
                khoVảiObject.sheetĐọcThẻKho.thisSheet.Name = "Đọc thẻ kho";
                khoVảiObject.sheetĐọcThẻKho.thisSheet.Activate();

                this.InnerObject.Protect("arhrJkekn36*", Structure: true);
            } catch (Exception ex)
            {

            }
        }

        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisWorkbook_Startup);
            this.Shutdown += new System.EventHandler(ThisWorkbook_Shutdown);
        }

        #endregion

    }
}
