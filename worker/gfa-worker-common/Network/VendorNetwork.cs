using System;
using System.Linq;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace gfa_worker_common.Network
{
    public class VendorNetwork
    {
        private readonly VendorApi _vendorApi;
        public VendorNetwork()
        {
            _vendorApi = new VendorApi(CommonHelper.NetworkConfiguration);
        }

        public void Run(BaseVendor baseVendor)
        {
            var source = _vendorApi.ApiAppVendorNoPagedGet();

            var update = source.Where(x => baseVendor.Records.FirstOrDefault(y => y.ID == x.SourceId
                && !(y.Nama == x.Name)) != null).ToList();
            
            
            var insert = baseVendor.Records.Where(x => source.FirstOrDefault(y => y.SourceId == x.ID) == null).Select(x => new GfaWebVendorsCreateUpdateVendorDto(
                sourceId: x.ID,
                name: x.Nama
            )).ToList();

            insert.AddRange(baseVendor.Records.Where(x => update.FirstOrDefault(y => y.SourceId == x.ID) != null).Select(x => new GfaWebVendorsCreateUpdateVendorDto(
                sourceId: x.ID,
                name: x.Nama
            )).ToList());
            
            foreach (var item in update)
            {
                _vendorApi.ApiAppVendorIdDelete(item.Id);
            }
            _vendorApi.ApiAppVendorBatchInsertPost(insert);
        }
    }
}