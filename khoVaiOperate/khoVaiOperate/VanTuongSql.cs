using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace khoVaiOperate
{
    public static class VanTuongSql
    {
        public static string ipAddress = "192.168.1.168";
        public static class xuongMaySql
        {
            public static class tableLươngCôngViệc
            {
                public static string name = "xuongMay.lươngCôngViệc";
                public static string cộtNgày = "Ngày";

                public static string cộtThẻNhập = "ThẻNhập";
                public static string cộtTênCôngViệc = "TênCôngViệc";
                public static string cộtGhiChú = "GhiChú";
                public static string cộtKanbai = "Kanbai";
                public static string cộtSốLượng = "SốLượng";
                public static string cộtSốThứTự = "SốThứTự";
                public static string cộtĐơnGiá = "ĐơnGiá";
                public static string cộtThànhTiền = "ThànhTiền";
                public static string cộtĐánhDấu = "đánhDấu";
                public static List<string> danhSáchCột = new List<string>
                { cộtNgày, cộtThẻNhập , cộtTênCôngViệc, cộtGhiChú, cộtKanbai, cộtSốLượng,
                        cộtSốThứTự, cộtĐơnGiá, cộtThànhTiền, cộtĐánhDấu};
            }
            public static class tableLươngTheoNhóm
            {
                public static string name = "xuongMay.lươngTheoNhóm";
                public static string cộtNgày = "Ngày";
                public static string cộtThẻNhập = "ThẻNhập";
                public static string cộtTên = "Tên";
                public static string cộtLươngTừngNgười = "lươngTừngNgười";
                public static string cộtNgàyCông = "ngàyCông";
                public static List<string> danhSáchCột = new List<string>
                {
                    cộtNgày, cộtThẻNhập, cộtTên, cộtLươngTừngNgười, cộtNgàyCông
                };
            }
            public static class tableKanbai
            {
                public static string name = "xuongMay.kanbai";
                public static string cộtKanbai = "sốKanbai";
                public static string cộtSốLượng = "sốLượng";
                public static string cộtSốPhiếuXuất = "sốPhiếuXuất";
                public static List<string> danhSáchCột = new List<string>
                {
                    cộtKanbai, cộtSốLượng, cộtSốPhiếuXuất
                };
            }
            public static class tablePhiếuXuấtBánThànhPhẩm
            {
                public static string name = "nhaCat.phiếuXuấtBtpXưởngMay";
                public static string cộtSốPhiếuXuất = "sốPhiếuXuất";
                public static string cộtMãĐơnGiá = "mãĐơnGiá";
                public static string cộtTênHàng = "tênHàng";
                public static string cộtSảnLượngCấp = "sảnLượngCấp";
                public static List<string> danhSáchCột = new List<string>
                {
                    cộtSốPhiếuXuất, cộtMãĐơnGiá, cộtTênHàng, cộtSảnLượngCấp
                };
            }
            public static class tableĐơnGiáMay
            {
                public static string name = "xuongMay.đơnGiáMay";
                public static string cộtMãĐơnGiá = "mãĐơnGiá";
                public static string cộtVòngTrong = "vòngTrong";
                public static string cộtChuyênDùng = "chuyênDùng";
                public static string cộtVòngNgoài = "vòngNgoài";
                public static string cộtĐóngBao = "đóngBao";
                public static string cộtỦi = "Ủi";
                public static List<string> danhSáchCột = new List<string>
                {
                    cộtMãĐơnGiá, cộtVòngTrong, cộtChuyênDùng, cộtVòngNgoài, cộtĐóngBao, cộtỦi
                };
            }
            public static class tableCôngĐoạnPhátSinhMay
            {
                public static string name = "xuongMay.côngĐoạnPhátSinhMay";
                public static string cộtTênCôngĐoạn = "tênCôngĐoạn";
                public static string cộtĐơnGiá = "đơnGiá";
                public static string cộtĐơnVị = "đơnVị";
                public static string cộtCôngĐoạnĐóngBao = "côngĐoạnĐóngBao";
                public static string cộtCôngĐoạnMay = "côngĐoạnMay";
                public static string cộtCôngĐoạnPhổBiến = "côngĐoạnPhổBiến";
                public static string cộtCôngĐoạnThờiGian = "côngĐoạnThờiGian";
                public static List<string> danhSáchCột = new List<string>
                {
                    cộtTênCôngĐoạn,  cộtĐơnGiá, cộtĐơnVị, cộtCôngĐoạnĐóngBao, cộtCôngĐoạnMay, cộtCôngĐoạnPhổBiến, cộtCôngĐoạnThờiGian
                };
            }
            public static class tableLươngThờiGian
            {
                public static string name = "xuongMay.lươngThờiGian";
                public static string cộtTênCôngViệc = "tênCôngViệc";
                public static string cộtĐơnVị = "đơnVị";
                public static List<string> danhSáchCột = new List<string>
                {
                    cộtTênCôngViệc, cộtĐơnVị
                };
            }
            public static class tableCôngĐoạnMay
            {
                public static string name = "xuongMay.côngĐoạnMay";
                public static string cộtTênCôngĐoạn = "tênCôngĐoạn";
                public static string cộtĐơnVị = "đơnVị";
                public static List<string> danhSáchCột = new List<string>
                {
                    cộtTênCôngĐoạn, cộtĐơnVị
                };
            }
            public static class tableBậcThợMay
            {
                public static string name = "xuongMay.bậcThợMay";
                public static string cộtBậcThợ = "bậcThợ";
                public static string cộtHệSốBậcThợ = "hệSốBậcThợ";
            }
        }
        public static class congTySql
        {
            public static class tableDanhSáchNhânViên
            {
                public static string name = "congTy.danhSáchNhânViên";
                public static string cộtLươngThờiGian = "lươngThờiGian";
                public static string cộtHọVàTên = "họVàTên";
                public static string cộtBậcThợMay = "bậcThợMay";
                public static string cộtHệSốMay = "hệSốMay";
                public static string cộtXưởngMay = "xưởngMay";
                public static string cộtCònLàm = "cònLàm";
            }
        }
        public static class nhaCatSql
        {
            public static class tablePhiếuXuấtBtp
            {
                public static string name = "nhaCat.phiếuXuấtBtpXưởngMay";
                public static string sốPhiếuXuất = "sốPhiếuXuất";
                public static string mãĐơnGiá = "mãĐơnGiá";
                public static string tênHàng = "tênHàng";
                public static string sảnLượngCấp = "sảnLượngCấp";
                public static List<string> danhSáchCột = new List<string>
                {
                    sốPhiếuXuất, mãĐơnGiá, tênHàng, sảnLượngCấp
                };
            }
        }
    }
}
