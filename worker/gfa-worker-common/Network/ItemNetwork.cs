using System;
using System.Linq;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace gfa_worker_common.Network
{
    public class ItemNetwork
    {
        private readonly ItemApi _itemApi;
        public ItemNetwork()
        {
            _itemApi = new ItemApi(CommonHelper.NetworkConfiguration);
        }
            
        public void Run(BaseItem baseItem)
        {
            var source = _itemApi.ApiAppItemNoPagedGet();

            var update = source.Where(x => baseItem.Records.FirstOrDefault(y => y.ID == x.SourceId
                                           && !(y.Nama == x.Name
                                           && y.Kode == x.Code
                                           && Math.Abs(y.HargaJual1Nilai - x.SellPrice) == 0
                                           && Math.Abs(y.HargaBeliNilai - x.BuyPrice) == 0)) != null).ToList();
            
            
            var insert = baseItem.Records.Where(x => source.FirstOrDefault(y => y.SourceId == x.ID) == null).Select(x => new GfaWebItemsCreateUpdateItemDto(
                sourceId: x.ID,
                name: x.Nama,
                code: x.Kode,
                buyPrice: x.HargaBeliNilai,
                sellPrice: x.HargaJual1Nilai
            )).ToList();

            insert.AddRange(baseItem.Records.Where(x => update.FirstOrDefault(y => y.SourceId == x.ID) != null).Select(x => new GfaWebItemsCreateUpdateItemDto(
                sourceId: x.ID,
                name: x.Nama,
                code: x.Kode,
                buyPrice: x.HargaBeliNilai,
                sellPrice: x.HargaJual1Nilai
            )).ToList());

            
            foreach (var item in update)
            {
                _itemApi.ApiAppItemIdDelete(item.Id);
            }


            _itemApi.ApiAppItemBatchInsertPost(insert);
        }
    }
}