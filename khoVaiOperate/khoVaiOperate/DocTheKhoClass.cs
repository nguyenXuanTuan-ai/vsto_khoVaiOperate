using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khoVaiOperate
{
    public static class DocTheKhoClass
    {
        public static void docTheKho_button_click()
        {
            Debug.WriteLine("đọc thẻ kho click");
            try
            {
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
                List<object> listGhiChúObject = dataCâyVải[VanTuongSql.KhoVaiSql.tableCâyVải.ghiChú];

                List<string> listThẻKho = listThẻKhoObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<string> listPhiếuNhập = listPhiếuNhậpObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                List<string> listSốĐơnHàngVải = listSốĐơnHàngVảiObject.Select(x => x?.ToString() ?? string.Empty).ToList();
                 //stop in here , next time convert sheet ngày nhập
            }
            catch (Exception ex)
            {
                CommonInternalFunction.informDisconnection();
            }
        }
    }
}
