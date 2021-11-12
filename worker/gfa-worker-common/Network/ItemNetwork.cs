using System;
using System.Collections.Generic;
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
            
        public void Run(List<ItemRecord> baseItem)
        {
            var source = _itemApi.ApiAppItemNoPagedGet();

            var update = source.Where(x => baseItem.FirstOrDefault(y => y.ID == x.SourceId
                                           && !(y.Nama == x.Name
                                           && y.Kode == x.Code
                                           && Math.Abs(y.HargaJual1Nilai - x.SellPrice) == 0
                                           && Math.Abs(y.HargaBeliNilai - x.BuyPrice) == 0)) != null).Select(x =>
                {
                    var data = baseItem.FirstOrDefault(y => x.SourceId == y.ID);
                    x.Name = data.Nama;
                    x.Code = data.Kode;
                    x.SellPrice = data.HargaJual1Nilai;
                    x.BuyPrice = data.HargaBeliNilai;
                    return x;

                })
                
                .ToList();
            
            
            var insert = baseItem.Where(x => source.FirstOrDefault(y => y.SourceId == x.ID) == null).Select(x => new GfaWebItemsCreateUpdateItemDto(
                sourceId: x.ID,
                name: x.Nama,
                code: x.Kode,
                buyPrice: x.HargaBeliNilai,
                sellPrice: x.HargaJual1Nilai,
                profitLoss: x.HargaJual1Nilai - x.HargaBeliNilai
            )).ToList();

            
            foreach (var item in update)
            {
                _itemApi.ApiAppItemIdPut(item.Id, item);
            }


            _itemApi.ApiAppItemBatchInsertPost(insert);
        }
    }
}