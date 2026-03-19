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
                string query = $"select * from {VanTuongSql.KhoVaiSql.tableCâyVải.name}";
                Dictionary<string, List<object>> dataCâyVải = new Dictionary<string, List<object>>();
                List<string> listColumn = new List<string>() { 
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
                    VanTuongSql.KhoVaiSql.tableCâyVải.độCoDàiPhầnTrăm
                    // stop in here
                };

            }
            catch (Exception ex)
            {
                CommonInternalFunction.informDisconnection();
            }
        }
    }
}
