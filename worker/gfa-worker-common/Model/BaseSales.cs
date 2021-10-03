using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfa_worker_common
{
    public class BaseSales
    {
        public List<SalesRecord> Records { get; set; }
        public int TotalRecords { get; set; }
    }
    public class DetailSales
    {
        public int PENJUA_ID { get; set; }
        public int PEMBEL_ID { get; set; }
        public int STKTRA_ID { get; set; }
        public int PERKIR_ID { get; set; }
        public int STOCK_ID { get; set; }
        public int STOCK_ID2 { get; set; }
        public int STOCK_GDG { get; set; }
        public string STOCK_NON { get; set; }
        public int STKSER_ID { get; set; }
        public string STKSER_1 { get; set; }
        public string STKSER_2 { get; set; }
        public int PELANG { get; set; }
        public int SALES { get; set; }
        public string TANGGAL { get; set; }
        public int SATUAN { get; set; }
        public string SATUAN_C { get; set; }
        public double JUMLAH { get; set; }
        public int OUT_SATUAN { get; set; }
        public double OUT_JUMLAH { get; set; }
        public int BON_SATUAN { get; set; }
        public double BON_JUMLAH { get; set; }
        public double HARGA { get; set; }
        public double HARGA_EX1 { get; set; }
        public double HARGA_EX2 { get; set; }
        public double DISC_PERS { get; set; }
        public double DISC_PERS2 { get; set; }
        public double DISC_PERS3 { get; set; }
        public double DISC_NILAI { get; set; }
        public double PPN_PERS { get; set; }
        public double PPN_NILAI { get; set; }
        public double MAST_DISC { get; set; }
        public double MAST_PPN { get; set; }
        public double MAST_ADJ_1 { get; set; }
        public double MAST_ADJ_2 { get; set; }
        public double MAST_ADJ_3 { get; set; }
        public double MAST_ADJ_4 { get; set; }
        public double MAST_ADJ_5 { get; set; }
        public double HPP { get; set; }
        public double HPP_BONUS { get; set; }
        public string ALS_BATAL { get; set; }
        public string EXPIRED { get; set; }
        public string CATATAN { get; set; }
        public string TGL_HAPUS { get; set; }
        public string DBF_VLD { get; set; }
        public int DiscPers1Nilai { get; set; }
        public int DiscPers2Nilai { get; set; }
        public int DiscPers3Nilai { get; set; }
        public int DiscPersNilai { get; set; }
        public int ItemGrpStk { get; set; }
        public int ItemGrpSt2 { get; set; }
        public int ItemGrpSt3 { get; set; }
        public string ItemKode { get; set; }
        public string ItemKode2 { get; set; }
        public string ItemNama { get; set; }
        public string ItemJumlah { get; set; }
        public string ItemSatuan { get; set; }
        public string ItemBonusJml { get; set; }
        public string ItemBonusSat { get; set; }
    }

    public class SalesRecord
    {
        public int ID { get; set; }
        public int SALORD_ID { get; set; }
        public int ECRLST_ID { get; set; }
        public int RESERV_ID { get; set; }
        public int DIVISI_ID { get; set; }
        public int JENPEN_ID { get; set; }
        public int PERKIR_1 { get; set; }
        public int PERKIR_2 { get; set; }
        public string RECORD_CAT { get; set; }
        public int BARANG_KLR { get; set; }
        public int LINKED { get; set; }
        public int NO_MILIK { get; set; }
        public int NO_MLK_CSH { get; set; }
        public int NO { get; set; }
        public string NO_C { get; set; }
        public int NO_PJK_SR { get; set; }
        public int NO_PJK_PRE { get; set; }
        public int NO_PJK { get; set; }
        public string PO { get; set; }
        public int GUDANG { get; set; }
        public string TANGGAL { get; set; }
        public string TGL_PAJAK { get; set; }
        public int PUKUL { get; set; }
        public int PELANG { get; set; }
        public int PELEXT_ID { get; set; }
        public string PEL_NAMA { get; set; }
        public string PEL_ALAMAT { get; set; }
        public int MAUANG { get; set; }
        public double KURS { get; set; }
        public double KURS_PAJAK { get; set; }
        public double TOT_HARGA { get; set; }
        public double TOT_HAREX1 { get; set; }
        public double TOT_HAREX2 { get; set; }
        public double TOT_DISC { get; set; }
        public double TOT_PAJAK { get; set; }
        public double TOT_RETUR { get; set; }
        public double DISC_NILAI { get; set; }
        public double DISC_PERST { get; set; }
        public int PPN_TIPE { get; set; }
        public double PPN_PERS { get; set; }
        public double PPN_NILAI { get; set; }
        public double ADJ_01 { get; set; }
        public double ADJ_02 { get; set; }
        public double ADJ_03 { get; set; }
        public double ADJ_04 { get; set; }
        public double ADJ_05 { get; set; }
        public double DEPOSIT { get; set; }
        public string TGL_LUNAS { get; set; }
        public double LUNAS { get; set; }
        public int LUN_TIPE_1 { get; set; }
        public string LUN_DOC_1 { get; set; }
        public string LUN_DOC_1A { get; set; }
        public double LUNAS_1 { get; set; }
        public double CHARGES_1 { get; set; }
        public int TERM_CRD { get; set; }
        public int SALES { get; set; }
        public double SALES_KOM { get; set; }
        public int SUPIR { get; set; }
        public string CATATAN { get; set; }
        public string CATATAN_2 { get; set; }
        public string CATATAN_3 { get; set; }
        public int SALDO_AWAL { get; set; }
        public string ALS_BATAL { get; set; }
        public string CLEAR_AR { get; set; }
        public int CETAK_OLEH { get; set; }
        public string CETAK_TGL { get; set; }
        public string CETAK_JAM { get; set; }
        public int CETA2_OLEH { get; set; }
        public string CETA2_TGL { get; set; }
        public string CETA2_JAM { get; set; }
        public int KONF_OLEH { get; set; }
        public string KONF_TGL { get; set; }
        public string KONF_JAM { get; set; }
        public int IMP_OWNID { get; set; }
        public int IMP_ID { get; set; }
        public int IMP_OLEH { get; set; }
        public string IMP_TGL { get; set; }
        public string IMP_JAM { get; set; }
        public int EXP_OLEH { get; set; }
        public string EXP_TGL { get; set; }
        public string EXP_JAM { get; set; }
        public int INPUT_OLEH { get; set; }
        public int UBAH_OLEH { get; set; }
        public int HAPUS_OLEH { get; set; }
        public int KUNCI_OLEH { get; set; }
        public string TGL_INPUT { get; set; }
        public string TGL_UBAH { get; set; }
        public string TGL_HAPUS { get; set; }
        public string TGL_KUNCI { get; set; }
        public string JAM_INPUT { get; set; }
        public string JAM_UBAH { get; set; }
        public string JAM_HAPUS { get; set; }
        public string JAM_KUNCI { get; set; }
        public string DBF_VLD { get; set; }
        public string DivisiText { get; set; }
        public string GudangText { get; set; }
        public string SalesNama { get; set; }
        public string SalesTelepon { get; set; }
        public string SalesNonAktif { get; set; }
        public string PelangganKode { get; set; }
        public string PelangganNama { get; set; }
        public string PelangganDaerah { get; set; }
        public string PelangganGroup { get; set; }
        public string PelangganGroup2 { get; set; }
        public List<DetailSales> Detail { get; set; }
    }
}
