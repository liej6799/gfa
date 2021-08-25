using System.Collections.Generic;

namespace gfa_worker_common
{
    public class BasePurchase
    {
        public List<PurchaseRecord> Records { get; set; }
        public int TotalRecords { get; set; }
    }
    
    public class DetailPurchase
    {
        public int PEMBEL_ID { get; set; }
        public int PERKIR_ID { get; set; }
        public int STOCK_ID { get; set; }
        public int STOCK_GDG { get; set; }
        public string STOCK_NON { get; set; }
        public int STKSER_ID { get; set; }
        public string STKSER_1 { get; set; }
        public string STKSER_2 { get; set; }
        public int VENDOR { get; set; }
        public string TANGGAL { get; set; }
        public int SATUAN { get; set; }
        public string SATUAN_C { get; set; }
        public double JUMLAH { get; set; }
        public double HARGA { get; set; }
        public double HARGA_EX1 { get; set; }
        public double HARGA_EX2 { get; set; }
        public double DISC_PERS { get; set; }
        public double DISC_PERS2 { get; set; }
        public double DISC_PERS3 { get; set; }
        public double DISC_NILAI { get; set; }
        public double MAST_DISC { get; set; }
        public double MAST_PPN { get; set; }
        public double MAST_ADJ_1 { get; set; }
        public double MAST_ADJ_2 { get; set; }
        public double MAST_ADJ_3 { get; set; }
        public double MAST_ADJ_4 { get; set; }
        public double MAST_ADJ_5 { get; set; }
        public string EXPIRED { get; set; }
        public string CATATAN { get; set; }
        public string TGL_HAPUS { get; set; }
        public string DBF_VLD { get; set; }
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

    public class PurchaseRecord
    {
        public int ID { get; set; }
        public int DIVISI_ID { get; set; }
        public int JENPEM_ID { get; set; }
        public int PERKIR_1 { get; set; }
        public int PERKIR_2 { get; set; }
        public int BARANG_TRM { get; set; }
        public int NO_MILIK { get; set; }
        public int NO_MLK_CSH { get; set; }
        public string NO { get; set; }
        public string NO_EX1 { get; set; }
        public string NO_FAKPJK { get; set; }
        public string TGL_FAKPJK { get; set; }
        public int PURCOR_ID { get; set; }
        public int GUDANG { get; set; }
        public string TANGGAL { get; set; }
        public string TANGGAL2 { get; set; }
        public int PUKUL { get; set; }
        public int VENDOR { get; set; }
        public int MAUANG { get; set; }
        public double KURS { get; set; }
        public double TOT_HARGA { get; set; }
        public double TOT_HAREX1 { get; set; }
        public double TOT_HAREX2 { get; set; }
        public double TOT_DISC { get; set; }
        public double TOT_RETUR { get; set; }
        public double DISC_NILAI { get; set; }
        public int PPN_TIPE { get; set; }
        public double PPN_PERS { get; set; }
        public double PPN_NILAI { get; set; }
        public double ADJ_01 { get; set; }
        public double ADJ_02 { get; set; }
        public double ADJ_03 { get; set; }
        public double ADJ_04 { get; set; }
        public double ADJ_05 { get; set; }
        public double DEPOSIT { get; set; }
        public int TERM_CRD { get; set; }
        public string CATATAN { get; set; }
        public string CATATAN_2 { get; set; }
        public string CATATAN_3 { get; set; }
        public int SALDO_AWAL { get; set; }
        public string ALS_BATAL { get; set; }
        public string CLEAR_AP { get; set; }
        public int CETAK_OLEH { get; set; }
        public string CETAK_TGL { get; set; }
        public string CETAK_JAM { get; set; }
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
        public string VendorNama { get; set; }
        public string VendorGroup { get; set; }
        public List<DetailPurchase> Detail { get; set; }
    }
}