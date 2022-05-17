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
            var saleList = _saleApi.ApiAppSaleNoPagedGet(startDate, endDate);
            var saleItemList = _saleItemApi.ApiAppSaleItemNoPagedGet(startDate, endDate);
            var itemList = _itemApi.ApiAppItemNoPagedGet();

            var update = saleList.Where(x => baseSales.FirstOrDefault(y => y.ID == x.SourceId
                && !(DateTime.ParseExact(y.TANGGAL + ' ' + y.JAM_INPUT, CommonHelper.YMDHMSDateFormat, CommonHelper.DateProvider) == x.DateSales
                                                                      && Math.Abs(y.LUNAS - x.TotalCash) == 0
                                                                      && Math.Abs(Math.Abs(y.LUNAS - y.TOT_HARGA) - x.TotalChange) == 0
                                                                      && Math.Abs(y.TOT_HARGA - x.TotalAmount) == 0)) != null).Select(
                    x =>
                    {
                        var data = baseSales.FirstOrDefault(y => x.SourceId == y.ID);
                        x.DateSales = DateTime.ParseExact(data.TANGGAL + ' ' + data.JAM_INPUT, CommonHelper.YMDHMSDateFormat,
                            CommonHelper.DateProvider);
                        x.TotalCash = data.LUNAS;
                        x.TotalChange = data.LUNAS - data.TOT_HARGA;
                        x.TotalAmount = data.TOT_HARGA;
                        return x;

                    })
                .ToList();


            var insert = baseSales.Where(x => saleList.FirstOrDefault(y => y.SourceId == x.ID) == null).Select(x => new GfaWebSalesCreateUpdateSaleDto(
                sourceId: x.ID,
                dateSales: DateTime.ParseExact(x.TANGGAL + ' ' + x.JAM_INPUT, CommonHelper.YMDHMSDateFormat, CommonHelper.DateProvider),
                totalCash: x.LUNAS,
                totalChange: x.LUNAS - x.TOT_HARGA,
                totalAmount: x.TOT_HARGA
            )).ToList();

            foreach (var item in update)
            {
                _saleApi.ApiAppSaleIdPut(item.Id, item);
            }

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
             .Where(x => saleItemList.FirstOrDefault(y =>
                     y.ItemSourceId == x.STOCK_ID
                     && y.SaleSourceId == x.PENJUA_ID
                         ) == null &&
                         (itemList.FirstOrDefault(y => y.SourceId == x.STOCK_ID) != null
                          && (saleList.FirstOrDefault(y => y.SourceId == x.PENJUA_ID) != null))
                          && x.JUMLAH > 0 && x.HARGA > 0 && (x.HARGA / x.JUMLAH) > 0)
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
