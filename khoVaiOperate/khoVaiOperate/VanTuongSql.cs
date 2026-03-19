using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khoVaiOperate
{
    public static class VanTuongSql
    {
        public static string ipAddress = "100.64.0.1";
        public static class congTySql
        {
            public static class tableDanhSáchNhânViên
            {
                public static string name = "congTy.danhSáchNhânViên";
                public static string họVàTên = "họVàTên";
                public static string mậtKhẩu = "mậtKhẩu";
                public static string lươngThờiGian = "lươngThờiGian";
                public static string bậcThợMay = "bậcThợMay";
                public static string xưởngMay = "xưởngMay";
                public static string xưởngCắt = "xưởngCắt";
                public static string khoVải = "khoVải";
                public static string cánBộ = "cánBộ";
                public static string cònLàm = "cònLàm";
            }

            public static class tableMãVạch
            {
                public static string name = "congTy.mãVạch";
                public static string mãVạchThươngMại = "mãVạchThươngMại";
                public static string mãVạchSảnXuất = "mãVạchSảnXuất";
                public static string mãVạchQuốcGia = "mãVạchQuốcGia";
                public static string tênHàng = "tênHàng";
                public static string mãVạchPhổBiến = "mãVạchPhổBiến";
            }
            public static class tableDanhSáchKhuVực
            {
                public static string name = "congTy.danhSáchKhuVực";
                public static string khuVực = "khuVực";
            }
        }
        public static class KhoVaiSql
        {
            public static class tableCâyVải
            {
                public static string name = "khoVai.câyVải";
                public static string thẻKho = "thẻKho";
                public static string phiếuNhập = "phiếuNhập";
                public static string sốĐơnHàngVải = "sốĐơnHàngVải";
                public static string ngàyNhập = "ngàyNhập";
                public static string nhàCungCấp = "nhàCungCấp";
                public static string nhàCungCấpIn = "nhàCungCấpIn";
                public static string mụcĐíchSửDụng = "mụcĐíchSửDụng";
                public static string chấtLiệu = "chấtLiệu";
                public static string sốQuyển = "sốQuyển";
                public static string vịTrí = "vịTrí";
                public static string khổVải = "khổVải";
                public static string sốLượngNhập = "sốLượngNhập";
                public static string đơnVị = "đơnVị";
                public static string trọngLượng = "trọngLượng";
                public static string sốMét = "sốMét";
                public static string độBềnVảiVàMàu = "độBềnVảiVàMàu";
                public static string độCoDàiPhầnTrăm = "độCoDàiPhầnTrăm";
                public static string độCoRộngPhầnTrăm = "độCoRộngPhầnTrăm";
                public static string chếĐộGiặt = "chếĐộGiặt";
                public static string nguyênLiệu = "nguyênLiệu";
                public static string địnhLượngg_m2 = "địnhLượngg_m2";
                public static string thunSi = "thunSi";
                public static string thẻKhoĐạiDiện = "thẻKhoĐạiDiện";
                public static string ghiChú = "ghiChú";
            }
            public static class tableXuấtVải
            {
                public static string name = "khoVai.xuấtVải";
                public static string ngày = "Ngày";
                public static string phiếuXuấtVải = "phiếuXuấtVải";
                public static string sốLượngXuất = "sốLượngXuất";
                public static string thẻKho = "ThẻKho";
            }
            public static class tableĐơnVịNhậpCâyVải
            {
                public static string name = "khoVai.đơnVịNhậpCâyVải";
                public static string đơnVị = "đơnVị";
            }

            public static class tableCâyVảiThunSi
            {
                public static string name = "khoVai.câyVảiThunSi";
                public static string thunSi = "thunSi";
            }
            public static class tableVịTríKhoVải
            {
                public static string name = "khoVai.vịTríKhoVải";
                public static string vịTrí = "vịTrí";
                public static string khuVực = "khuVực";
                public static string ghiChú = "ghiChú";
            }

        }
        public static class xuongMaySql
        {
            public static class tableCôngĐoạnPhátSinhMay
            {
                public static string name = "xuongMay.côngĐoạnPhátSinhMay";
                public static string tênCôngĐoạn = "tênCôngĐoạn";
                public static string đơnGiá = "đơnGiá";
                public static string đơnVị = "đơnVị";
                public static string côngĐoạnĐóngBao = "côngĐoạnĐóngBao";
                public static string côngĐoạnMay = "côngĐoạnMay";
                public static string côngĐoạnPhổBiến = "côngĐoạnPhổBiến";
                public static string côngĐoạnThờiGian = "côngĐoạnThờiGian";
            }

            public static class tableLươngCôngViệc
            {
                public static string name = "xuongmay.lươngCôngViệc";
                public static string ngày = "Ngày";
                public static string thẻNhập = "ThẻNhập";
                public static string tênCôngViệc = "TênCôngViệc";
                public static string ghiChú = "GhiChú";
                public static string kanbai = "Kanbai";
                public static string sốLượng = "sốLượng";
                public static string sốThứTự = "sốThứTự";
                public static string đơnGiá = "đơnGiá";
                public static string thànhTiền = "thànhTiền";
                public static string đánhDấu = "đánhDấu";
            }
            public static class tableLươngTheoNhóm
            {
                public static string name = "xuongMay.lươngTheoNhóm";
                public static string ngày = "Ngày";
                public static string thẻNhập = "ThẻNhập";
                public static string tên = "Tên";
                public static string lươngTừngNgười = "lươngTừngNgười";
                public static string ngàyCông = "ngàyCông";
            }
        }
    }
}
