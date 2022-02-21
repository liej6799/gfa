using System;
using System.Collections.Generic;
using System.Linq;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace gfa_worker_common.Network
{
    public class SalesNetwork
    {
        private readonly SaleItemApi _saleItemApi;
        private readonly SaleApi _saleApi;
        private readonly ItemApi _itemApi;

        public SalesNetwork()
        {
            _saleItemApi = new SaleItemApi(CommonHelper.NetworkConfiguration);
            _saleApi = new SaleApi(CommonHelper.NetworkConfiguration);
            _itemApi = new ItemApi(CommonHelper.NetworkConfiguration);
        }
        public void Run(List<SalesRecord> baseSales, DateTime startDate, DateTime endDate)
        {
            var insert = baseSales.Select(x => new GfaWebSalesCreateUpdateSaleDto(
                sourceId: x.ID,
                dateSales: DateTime.ParseExact(x.TANGGAL + ' ' + x.JAM_INPUT, CommonHelper.YMDHMSDateFormat, CommonHelper.DateProvider),
                totalCash: x.LUNAS,
                totalChange: x.LUNAS - x.TOT_HARGA,
                totalAmount: x.TOT_HARGA
            )).ToList();

            _saleApi.ApiAppSaleBatchInsertPost(insert);


            saleList = _saleApi.ApiAppSaleNoPagedGet(startDate, endDate);

            var baseSaleDetail = baseSales.SelectMany(x => x.Detail).ToList();

            var updateDetail = saleItemList.Where(x => baseSaleDetail.FirstOrDefault(y =>
                (x.ItemSourceId == y.STOCK_ID
               && x.SaleSourceId == y.PENJUA_ID) && 
               !(Math.Abs(x.Quantity - y.JUMLAH) == 0
               && Math.Abs(x.Price - (y.HARGA / y.JUMLAH)) == 0
               && Math.Abs(x.Total - y.HARGA) == 0)) != null).Select(x =>
               {
                   var data = baseSaleDetail.FirstOrDefault(y => x.ItemSourceId == y.STOCK_ID && x.SaleSourceId == y.PENJUA_ID);
                   x.Quantity = data.JUMLAH;
                   x.Total = data.HARGA;
                   x.Price = (data.HARGA / data.JUMLAH);
                   return x;
               });

            var insertDetail = baseSaleDetail
             .Select(x => new GfaWebSalesCreateUpdateSaleItemDto(
                 quantity: x.JUMLAH,
                 total: x.HARGA,
                 price: (x.HARGA / x.JUMLAH),
                 itemId: itemList.FirstOrDefault(y => y.SourceId == x.STOCK_ID).Id,
                 saleId: saleList.FirstOrDefault(y => y.SourceId == x.PENJUA_ID).Id
             )).ToList();

            foreach (var item in updateDetail)
            {
                _saleItemApi.ApiAppSaleItemIdPut(item.Id, item);
            }
            
            _saleItemApi.ApiAppSaleItemBatchInsertPost(insertDetail);
        }
    }

}
