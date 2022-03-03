using System;
using System.Collections.Generic;
using System.Linq;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace gfa_worker_common.Network
{
    public class SalesNetwork
    {
        private readonly RawSaleItemApi _rawSaleItemApi;
        private readonly RawSaleApi _rawSaleApi;

        public SalesNetwork()
        {
            _rawSaleItemApi = new RawSaleItemApi(CommonHelper.NetworkConfiguration);
            _rawSaleApi = new RawSaleApi(CommonHelper.NetworkConfiguration);
        }
        public void Run(List<SalesRecord> baseSales, DateTime startDate, DateTime endDate)
        {
            var insert = baseSales.Select(x => new GfaWebSalesCreateUpdateRawSaleDto(
                sourceId: x.ID,
                dateSales: DateTime.ParseExact(x.TANGGAL + ' ' + x.JAM_INPUT, CommonHelper.YMDHMSDateFormat, CommonHelper.DateProvider),
                totalCash: x.LUNAS,
                totalChange: x.LUNAS - x.TOT_HARGA,
                totalAmount: x.TOT_HARGA
            )).ToList();

            _rawSaleApi.ApiAppRawSaleBatchInsertPost(insert);
            
            var baseSaleDetail = baseSales.SelectMany(x => x.Detail).ToList();
            
            var insertDetail = baseSaleDetail
             .Select(x => new GfaWebSalesCreateUpdateRawSaleItemDto(
                 quantity: x.JUMLAH,
                 total: x.HARGA,
                 sourceItemId: x.STOCK_ID,
                 sourceSaleId: x.PENJUA_ID
             )).ToList();
            
            _rawSaleItemApi.ApiAppRawSaleItemBatchInsertPost(insertDetail);
        }
    }

}
