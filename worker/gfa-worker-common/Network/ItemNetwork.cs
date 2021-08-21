using System;
using System.Collections.Generic;
using System.Linq;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace gfa_worker_common.Network
{
    public class ItemNetwork
    {
        private ItemApi _itemApi;
        public ItemNetwork()
        {
            _itemApi = new ItemApi(CommonHelper.NetworkConfiguration);
        }
            
        public void Run(BaseItem baseItem)
        {
            var source = _itemApi.ApiAppItemNoPagedGet();

            var update = source.Where(x => baseItem.Records.FirstOrDefault(y => y.ID == x.SourceId) != null).ToList();

            var insert = baseItem.Records.Where(x => source.FirstOrDefault(y => y.SourceId == x.ID) == null).Select(x => new GfaWebItemsCreateUpdateItemDto(
                    sourceId: x.ID,
                    name: x.Nama,
                    code: x.Kode,
                    buyPrice: x.HargaBeliNilai,
                    sellPrice: x.HargaJual1Nilai
                )).ToList();
            
            _itemApi.ApiAppItemBatchInsertPost(insert);
            _itemApi.ApiAppItemBatchUpdatePost(update);
        }
    }
}