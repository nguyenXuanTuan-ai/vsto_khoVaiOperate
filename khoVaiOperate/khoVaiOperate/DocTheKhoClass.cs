using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace khoVaiOperate
{
    public static class DocTheKhoClass
    {
        public static void docTheKho_button_click()
        {
            Debug.WriteLine("đọc thẻ kho click");
            try
            {
                Excel.Worksheet sheet = khoVảiObject.sheetĐọcThẻKho.thisSheet;
                if (sheet.AutoFilterMode)
                {
                    sheet.AutoFilterMode = false;
                }
                BasicSqlFunction basicSqlFunction = new BasicSqlFunction();
                string query = $"select * from {VanTuongSql.KhoVaiSql.tableCâyVải.name} order by {VanTuongSql.KhoVaiSql.tableCâyVải.thẻKho}";
                Dictionary<string, List<object>> dataCâyVải = new Dictionary<string, List<object>>();
                List<string> listColumnCâyVải = new List<string>() { 
                    VanTuongSql.KhoVaiSql.tableCâyVải.thẻKho,
                    VanTuongSql.KhoVaiSql.tableCâyVải.phiếuNhập,
                    VanTuongSql.KhoVaiSql.tableCâyVải.sốĐơnHàngVải,
                    VanTuongSql.KhoVaiSql.tableCâyVải.ngàyNhập,
                    VanTuongSql.KhoVaiSql.tableCâyVải.nhàCungCấp,
                    VanTuongSql.KhoVaiSql.tableCâyVải.nhàCungCấpIn,
                    VanTuongSql.KhoVaiSql.tableCâyVải.mụcĐíchSửDụng,
                    VanTuongSql.KhoVaiSql.tableCâyVải.chấtLiệu,
                    VanTuongSql.KhoVaiSql.tableCâyVải.sốQuyển,
                    VanTuongSql.KhoVaiSql.tableCâyVải.vịTrí,
                    VanTuongSql.KhoVaiSql.tableCâyVải.khổVải,
                    VanTuongSql.KhoVaiSql.tableCâyVải.sốLượngNhập,
                    VanTuongSql.KhoVaiSql.tableCâyVải.đơnVị,
                    VanTuongSql.KhoVaiSql.tableCâyVải.trọngLượng,
                    VanTuongSql.KhoVaiSql.tableCâyVải.sốMét,
                    VanTuongSql.KhoVaiSql.tableCâyVải.độBềnVảiVàMàu,
                    VanTuongSql.KhoVaiSql.tableCâyVải.độCoDàiPhầnTrăm,
                    VanTuongSql.KhoVaiSql.tableCâyVải.độCoRộngPhầnTrăm,
                    VanTuongSql.KhoVaiSql.tableCâyVải.chếĐộGiặt,
                    VanTuongSql.KhoVaiSql.tableCâyVải.nguyênLiệu,
                    VanTuongSql.KhoVaiSql.tableCâyVải.địnhLượngg_m2,
                    VanTuongSql.KhoVaiSql.tableCâyVải.thunSi,
                    VanTuongSql.KhoVaiSql.tableCâyVải.thẻKhoĐạiDiện,
                    VanTuongSql.KhoVaiSql.tableCâyVải.sốThứTựMàuVải,
                    VanTuongSql.KhoVaiSql.tableCâyVải.ghiChú
                };
                basicSqlFunction.readWholeSqlTable(query, listColumnCâyVải, dataCâyVải);
                List<object> listThẻKhoObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.thẻKho];
                List<object> listPhiếuNhậpObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.phiếuNhập];
                List<object> listSốĐơnHàngVảiObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.sốĐơnHàngVải];
                List<object> listNgàyNhậpObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.ngàyNhập];
                List<object> listNhàCungCấpObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.nhàCungCấp];
                List<object> listNhàCungCấpInObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.nhàCungCấpIn];
                List<object> listMụcĐíchSửDụngObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.mụcĐíchSửDụng];
                List<object> listChấtLiệuObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.chấtLiệu];
                List<object> listSốQuyểnObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.sốQuyển];
                List<object> listVịTríObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.vịTrí];
                List<object> listKhổVảiObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.khổVải];
                List<object> listSốLượngNhậpObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.sốLượngNhập];
                List<object> listĐơnVịObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.đơnVị];
                List<object> listTrọngLượngObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.trọngLượng];
                List<object> listSốMétObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.sốMét];
                List<object> listĐộBềnVảiVàMàuObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.độBềnVảiVàMàu];
                List<object> listĐộCoDàiPhầnTrămObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.độCoDàiPhầnTrăm];
                List<object> listĐộCoRộngPhầnTrămObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.độCoRộngPhầnTrăm];
                List<object> listChếĐộGiặtObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.chếĐộGiặt];
                List<object> listNguyênLiệuObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.nguyênLiệu];
                List<object> listĐịnhLượngg_m2Object = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.địnhLượngg_m2];
                List<object> listThunSiObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.thunSi];
                List<object> listThẻKhoĐạiDiệnObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.thẻKhoĐạiDiện];
                List<object> listSốThứTựMàuVảiObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.sốThứTựMàuVải];
                List<object> listGhiChúObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.ghiChú];

                List<string> listThẻKho = listThẻKhoObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<string> listPhiếuNhập = listPhiếuNhậpObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<string> listSốĐơnHàngVải = listSốĐơnHàngVảiObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<DateTime?> listNgàyNhập = listNgàyNhậpObject.Select(x => x == null ? (DateTime?)null : (DateTime?)Convert.ToDateTime(x)).ToList();
                List<string> listNhàCungCấp = listNhàCungCấpObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<string> listNhàCungCấpIn = listNhàCungCấpInObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<string> listMụcĐíchSửDụng = listMụcĐíchSửDụngObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<string> listChấtLiệu = listChấtLiệuObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<string> listSốQuyển = listSốQuyểnObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<string> listVịTrí = listVịTríObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<double> listKhổVải = listKhổVảiObject.Select(x => Convert.ToDouble(x)).ToList();
                List<double> listSốLượngNhập = listSốLượngNhậpObject.Select(x => Convert.ToDouble(x)).ToList();
                List<string> listĐơnVị = listĐơnVịObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<double> listTrọngLượng = listTrọngLượngObject.Select(x => Convert.ToDouble(x)).ToList();
                List<double> listSốMét = listSốMétObject.Select(x => Convert.ToDouble(x)).ToList();
                List<string> listĐộBềnVảiVàMàu = listĐộBềnVảiVàMàuObject.Select(x => x?.ToString() ?? string.Empty).ToList(); 
                List<double> listĐộCoDàiPhầnTrăm = listĐộCoDàiPhầnTrămObject.Select(x => Convert.ToDouble(x)).ToList();
                List<double> listĐộCoRộngPhầnTrăm = listĐộCoRộngPhầnTrămObject.Select(x => Convert.ToDouble(x)).ToList();
                List<string> listChếĐộGiặt = listChếĐộGiặtObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<string> listNguyênLiệu = listNguyênLiệuObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<double> listĐịnhLượng = listĐịnhLượngg_m2Object.Select(x => Convert.ToDouble(x)).ToList();
                List<string> listThunSi = listThunSiObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<string> listThẻKhoĐạiDiện = listThẻKhoObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<int> listSốThứTựMàuVải = listSốThứTựMàuVảiObject.Select(x => Convert.ToInt32(x)).ToList();
                List<string> listGhiChú = listGhiChúObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                const int numberOfColumns = 27;
                int numberOfRows = listThẻKho.Count;

                List<double> listSốMétConverted = new List<double>();
                for(int i = 0; i < listThẻKho.Count; i++)
                {
                    listSốMétConverted.Add(0.0);
                }
                Excel.Worksheet thisSheet = khoVảiObject.sheetĐọcThẻKho.thisSheet;
                Excel.Range thẻKho = thisSheet.Range["A4"];
                Excel.Range thẻKhoĐạiDiện = thisSheet.Range["B4"];
                Excel.Range sốĐơnHàngVải = thisSheet.Range["C4"];
                Excel.Range phiếuNhập = thisSheet.Range["D4"];
                Excel.Range ngàyNhập = thisSheet.Range["E4"];
                Excel.Range nhàCungCấp = thisSheet.Range["F4"];
                Excel.Range nhàCungCấpIn = thisSheet.Range["G4"];
                Excel.Range mụcĐíchSửDụng = thisSheet.Range["H4"];
                Excel.Range chấtLiệu = thisSheet.Range["I4"];
                Excel.Range sốQuyển = thisSheet.Range["J4"];
                Excel.Range vịTrí = thisSheet.Range["K4"];
                Excel.Range khổVải = thisSheet.Range["L4"];
                Excel.Range sốLượngNhập = thisSheet.Range["M4"];
                Excel.Range đơnVị = thisSheet.Range["N4"];
                Excel.Range trọngLượng = thisSheet.Range["O4"];
                Excel.Range sốMétNhập = thisSheet.Range["P4"];
                Excel.Range độBềnVảiVàMàu = thisSheet.Range["Q4"];
                Excel.Range độCoDàiPhầnTrăm = thisSheet.Range["R4"];
                Excel.Range độCoRộngPhầnTrăm = thisSheet.Range["S4"];
                Excel.Range chếĐộGiặt = thisSheet.Range["T4"];
                Excel.Range nguyênLiệu = thisSheet.Range["U4"];
                Excel.Range địnhLượng = thisSheet.Range["V4"];
                Excel.Range thunSi = thisSheet.Range["W4"];
                Excel.Range sốThứTựMàuVải = thisSheet.Range["X4"];
                Excel.Range ghiChú = thisSheet.Range["Y4"];

                thẻKho.Value2 = "Thẻ kho";
                thẻKhoĐạiDiện.Value2 = "Thẻ kho đại diện";
                sốĐơnHàngVải.Value2 = "Số đơn hàng vải";
                phiếuNhập.Value2 = "Phiếu nhập";
                ngàyNhập.Value2 = "Ngày nhập";
                nhàCungCấp.Value2 = "Nhà cung cấp";
                nhàCungCấpIn.Value2 = "Nhà cung cấp in";
                mụcĐíchSửDụng.Value2 = "Mục đích sử dụng";
                chấtLiệu.Value2 = "Chất liệu";
                sốQuyển.Value2 = "Số quyển";
                vịTrí.Value2 = "Vị trí";
                khổVải.Value2 = "Khổ vải";
                sốLượngNhập.Value2 = "Số lượng nhập";
                đơnVị.Value2 = "Đơn vị";
                trọngLượng.Value2 = "Trọng lượng";
                sốMétNhập.Value2 = "Số mét nhập";
                độBềnVảiVàMàu.Value2 = "Độ bền vải và màu";
                độCoDàiPhầnTrăm.Value2 = "Độ co dài %";
                độCoRộngPhầnTrăm.Value2 = "Độ co rộng %";
                chếĐộGiặt.Value2 = "Chế độ giặt";
                nguyênLiệu.Value2 = "Nguyên liệu";
                địnhLượng.Value2 = "Định lượng g/m2";
                thunSi.Value2 = "Thun si";
                sốThứTựMàuVải.Value2 = "Số thứ tự màu vải";
                ghiChú.Value2 = "Ghi chú";

                // extract value of số mét
                Excel.Range sốMétConverted = khoVảiObject.sheetĐọcThẻKho.thisSheet.Range["Z4"];
                sốMétConverted.Value = "Số mét";
                sốMétConverted.Offset[-1, 0].Value = "Nếu số mét nhập là 0 thì số mét cây vải sẽ được suy ra từ các thông số khác. nếu giá trị là -1 nghĩa là " +
                    "không thể suy ra được số mét của cây vải";
                for (int i = 0; i < listSốMét.Count; i++)
                {
                    if (listSốMét[i] != 0 )
                    {
                        listSốMétConverted[i] = listSốMét[i];
                    } else
                    {
                        if (listKhổVải[i] == 0 || listĐịnhLượng[i] == 0)
                        {
                            listSốMétConverted[i] = -1;
                        } else
                        {
                            listSốMétConverted[i] = listTrọngLượng[i] * 10000 / (listKhổVải[i] * listĐịnhLượng[i]);
                        }
                    }
                }

                // extract value sản lượng tồn
                Excel.Range sảnLượngTồn = thisSheet.Range["AA4"];
                sảnLượngTồn.Value = "Sản lượng tồn";
                query = $"select {VanTuongSql.KhoVaiSql.tableXuấtVải.sốLượngXuất}, {VanTuongSql.KhoVaiSql.tableXuấtVải.thẻKho} from " +
                    $"{VanTuongSql.KhoVaiSql.tableXuấtVải.name} order by {VanTuongSql.KhoVaiSql.tableXuấtVải.ngày}, {VanTuongSql.KhoVaiSql.tableXuấtVải.phiếuXuấtVải}, " +
                    $"{VanTuongSql.KhoVaiSql.tableXuấtVải.thẻKho}";
                Dictionary<string, List<object>> dataXuấtVải = new Dictionary<string, List<object>>();
                List<string> listColumnTableXuấtVải = new List<string> {
                    VanTuongSql.KhoVaiSql.tableXuấtVải.thẻKho,
                    VanTuongSql.KhoVaiSql.tableXuấtVải.sốLượngXuất
                };
                basicSqlFunction.readWholeSqlTable(query, listColumnTableXuấtVải, dataXuấtVải);
                List<object> listSốLượngXuấtObject_xuấtVải = dataXuấtVải[VanTuongSql.KhoVaiSql.tableXuấtVải.sốLượngXuất];
                List<object> listThẻKhoObject_xuấtVải = dataXuấtVải[VanTuongSql.KhoVaiSql.tableXuấtVải.thẻKho];
                List<string> listThẻKho_xuấtVải = listThẻKhoObject_xuấtVải.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<double> listSốLượngXuất_xuấtVải = listSốLượngXuấtObject_xuấtVải.Select(x => Convert.ToDouble(x)).ToList();
                List<double> listSảnLượngXuất = new List<double>();
                for(int i = 0; i < listThẻKho.Count; i++)
                {
                    listSảnLượngXuất.Add(0.0);
                }
                for(int i = 0; i < listThẻKho.Count; i++)
                {
                    double sảnLượngXuất = 0;
                    for(int j = 0; j < listThẻKho_xuấtVải.Count; j ++)
                    {
                        if (listThẻKho[i] == listThẻKho_xuấtVải[j])
                        {
                            sảnLượngXuất += listSốLượngXuất_xuấtVải[j];
                        }
                    }
                    listSảnLượngXuất[i] = sảnLượngXuất;
                }
                List<double> listSảnLượngTồn = new List<double>();
                for(int i = 0; i < listThẻKho.Count; i++)
                {
                    listSảnLượngTồn.Add(0.0);
                }
                for(int i = 0; i < listThẻKho.Count;i++)
                {
                    listSảnLượngTồn[i] = listSốMétConverted[i] - listSảnLượngXuất[i];
                }

                object[] listThẻKhoArray = new object[numberOfRows];
                object[] listThẻKhoĐạiDiệnArray = new object[numberOfRows];
                object[] listSốĐơnHàngVảiArray = new object[numberOfRows];
                object[] listPhiếuNhậpArray = new object[numberOfRows];
                object[] listNgàyNhậpArray = new object[numberOfRows];
                object[] listNhàCungCấpArray = new object[numberOfRows];
                object[] listNhàCungCấpInArray = new object[numberOfRows];
                object[] listMụcĐíchSửDụngArray = new object[numberOfRows];
                object[] listChấtLiệuArray = new object[numberOfRows];
                object[] listSốQuyểnArray = new object[numberOfRows];
                object[] listVịTríArray = new object[numberOfRows];
                object[] listKhổVảiArray = new object[numberOfRows];
                object[] listSốLượngNhậpArray = new object[numberOfRows];
                object[] listĐơnVịArray = new object[numberOfRows];
                object[] listTrọngLượngArray = new object[numberOfRows];
                object[] listSốMétNhậpArray = new object[numberOfRows];
                object[] listĐộBềnVảiVàMàuArray = new object[numberOfRows];
                object[] listĐộCoDàiPhầnTrămArray = new object[numberOfRows];
                object[] listĐộCoRộngPhầnTrămArray = new object[numberOfRows];
                object[] listChếĐộGiặtArray = new object[numberOfRows];
                object[] listNguyênLiệuArray = new object[numberOfRows];
                object[] listĐịnhLượngArray = new object[numberOfRows];
                object[] listThunSiArray = new object[numberOfRows];
                object[] listSốThứTựMàuVảiArray = new object[numberOfRows];
                object[] listGhiChúArray = new object[numberOfRows];
                object[] listSốMétConvertedArray = new object[numberOfRows];
                object[] listSảnLượngTồnAraray = new object[numberOfRows];

                object[,] arrayOutput = new object[numberOfRows, numberOfColumns];
                for(int i = 0; i < numberOfRows; i++)
                {
                    listThẻKhoArray[i] = listThẻKho[i];
                    listThẻKhoĐạiDiệnArray[i] = listThẻKhoĐạiDiện[i];
                    listSốĐơnHàngVảiArray[i] = listSốĐơnHàngVải[i];
                    listPhiếuNhậpArray[i] = listPhiếuNhập[i];
                    listNgàyNhậpArray[i] = listNgàyNhập[i];
                    listNhàCungCấpArray[i] = listNhàCungCấp[i];
                    listNhàCungCấpInArray[i] = listNhàCungCấpIn[i];
                    listMụcĐíchSửDụngArray[i] = listMụcĐíchSửDụng[i];
                    listChấtLiệuArray[i] = listChấtLiệu[i];
                    listSốQuyểnArray[i] = listSốQuyển[i];
                    listVịTríArray[i] = listVịTrí[i];
                    listKhổVảiArray[i] = listKhổVải[i];
                    listSốLượngNhậpArray[i] = listSốLượngNhập[i];
                    listĐơnVịArray[i] = listĐơnVị[i];
                    listTrọngLượngArray[i] = listTrọngLượng[i];
                    listSốMétNhậpArray[i] = listSốMét[i];
                    listĐộBềnVảiVàMàuArray[i] = listĐộBềnVảiVàMàu[i];
                    listĐộCoDàiPhầnTrămArray[i] = listĐộCoDàiPhầnTrăm[i];
                    listĐộCoRộngPhầnTrămArray[i] = listĐộCoRộngPhầnTrăm[i];
                    listChếĐộGiặtArray[i] = listChếĐộGiặt[i];
                    listNguyênLiệuArray[i] = listNguyênLiệu[i];
                    listĐịnhLượngArray[i] = listĐịnhLượng[i];
                    listThunSiArray[i] = listThunSi[i];
                    listSốThứTựMàuVảiArray[i] = listSốThứTựMàuVải[i];
                    listGhiChúArray[i] = listGhiChú[i];
                    listSốMétConvertedArray[i] = listSốMétConverted[i];
                    listSảnLượngTồnAraray[i] = listSảnLượngTồn[i];
                }
                for (int i = 0; i < numberOfRows; i++)
                {
                    arrayOutput[i, 0] = listThẻKhoArray[i];
                    arrayOutput[i, 1] = listThẻKhoĐạiDiệnArray[i];
                    arrayOutput[i, 2] = listSốĐơnHàngVảiArray[i];
                    arrayOutput[i, 3] = listPhiếuNhậpArray[i];
                    arrayOutput[i, 4] = listNgàyNhậpArray[i];
                    arrayOutput[i, 5] = listNhàCungCấpArray[i];
                    arrayOutput[i, 6] = listNhàCungCấpInArray[i];
                    arrayOutput[i, 7] = listMụcĐíchSửDụngArray[i];
                    arrayOutput[i, 8] = listChấtLiệuArray[i];
                    arrayOutput[i, 9] = listSốQuyểnArray[i];
                    arrayOutput[i, 10] = listVịTríArray[i];
                    arrayOutput[i, 11] = listKhổVảiArray[i];
                    arrayOutput[i, 12] = listSốLượngNhậpArray[i];
                    arrayOutput[i, 13] = listĐơnVịArray[i];
                    arrayOutput[i, 14] = listTrọngLượngArray[i];
                    arrayOutput[i, 15] = listSốMétNhậpArray[i];
                    arrayOutput[i, 16] = listĐộBềnVảiVàMàuArray[i];
                    arrayOutput[i, 17] = listĐộCoDàiPhầnTrămArray[i];
                    arrayOutput[i, 18] = listĐộCoRộngPhầnTrămArray[i];
                    arrayOutput[i, 19] = listChếĐộGiặtArray[i];
                    arrayOutput[i, 20] = listNguyênLiệuArray[i];
                    arrayOutput[i, 21] = listĐịnhLượngArray[i];
                    arrayOutput[i, 22] = listThunSiArray[i];
                    arrayOutput[i, 23] = listSốThứTựMàuVảiArray[i];
                    arrayOutput[i, 24] = listGhiChúArray[i];
                    arrayOutput[i, 25] = listSốMétConvertedArray[i];
                    arrayOutput[i, 26] = listSảnLượngTồnAraray[i];
                }

                // set format for data
                thẻKho.NumberFormat = "dd/MM/yyyy";
                sốLượngNhập.Offset[1].Resize[numberOfRows, numberOfColumns].NumberFormat = "0.##";
                trọngLượng.Offset[1].Resize[numberOfRows, numberOfColumns].NumberFormat = "0.##";
                sốMétNhập.Offset[1].Resize[numberOfRows, numberOfColumns].NumberFormat = "0.##";
                độCoDàiPhầnTrăm.Offset[1].Resize[numberOfRows, numberOfColumns].NumberFormat = "0,##";
                độCoRộngPhầnTrăm.Offset[1].Resize[numberOfRows, numberOfColumns].NumberFormat = "0,##";
                địnhLượng.Offset[1].Resize[numberOfRows, numberOfColumns].NumberFormat = "0,##";
                sốMétConverted.Offset[1].Resize[numberOfRows, numberOfColumns].NumberFormat = "0.##";
                sốThứTựMàuVải.Offset[1].Resize[numberOfRows, numberOfColumns].NumberFormat = "0";

                Excel.Range writingRange = thẻKho.Offset[1].Resize[numberOfRows, numberOfColumns];
                writingRange.Value = arrayOutput;
                thẻKho.Resize[1, numberOfColumns].Font.Bold = true;
                thẻKho.Resize[1, numberOfColumns].HorizontalAlignment = HorizontalAlignment.Center;

                // xóa dữ liệu tồn ở những thẻ kho không có số mét vải
                for (int i = 0; i < listThẻKho.Count; i++)
                {
                    if (sốMétConverted.Offset[i+1].Value < 0)
                    {
                        sảnLượngTồn.Offset[i + 1].ClearContents();
                    }
                }

                CommonInternalFunction.setBorderTitle(thẻKho.Resize[1, numberOfColumns]);
                CommonInternalFunction.setBorderContent(thẻKho.Offset[1].Resize[numberOfRows, numberOfColumns]);
                thẻKho.Resize[1, numberOfColumns].AutoFilter(1);
            }
            catch (Exception ex)
            {
                CommonInternalFunction.informDisconnection();
            }
        }
    }
}
