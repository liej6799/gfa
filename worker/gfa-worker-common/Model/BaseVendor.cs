using System.Collections.Generic;

namespace gfa_worker_common
{
    public class BaseVendor
    {
        public List<VendorRecord> Records { get; set; }
        public int TotalRecords { get; set; }

        public class VendorRecord
        {
            public int ID { get; set; }
            public string Nama { get; set; }
            public string Alamat { get; set; }
            public string KodePos { get; set; }
            public string Hubungi { get; set; }
            public string HubungiTelp { get; set; }
            public string Hubungi2 { get; set; }
            public string Hubungi2Telp { get; set; }
            public string Hubungi3 { get; set; }
            public string Hubungi3Telp { get; set; }
            public string Catatan { get; set; }
        }
    }
}