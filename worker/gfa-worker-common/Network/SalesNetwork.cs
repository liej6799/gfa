using System;
using System.Linq;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace gfa_worker_common.Network
{
    public class SalesNetwork
    {
        private readonly SaleApi _saleApi;
        public SalesNetwork()
        {
            _saleApi = new SaleApi(CommonHelper.NetworkConfiguration);
        }
        public void Run(BaseSales baseSales)
        {
            var saleList = _saleApi.ApiAppSaleNoPagedGet();

            var update = saleList.Where(x => baseSales.Records.FirstOrDefault(y => y.ID == x.SourceId
                && !(DateTime.ParseExact(y.TANGGAL + ' ' + y.JAM_INPUT, CommonHelper.YMDHMSDateFormat, CommonHelper.DateProvider) == x.DateSales
                                                                      && Math.Abs(y.LUNAS - x.TotalCash) == 0
                                                                      && Math.Abs(Math.Abs(y.LUNAS - y.TOT_HARGA) - x.TotalChange) == 0
                                                                      && Math.Abs(y.TOT_HARGA - x.TotalAmount) == 0)) != null).Select(
                    x =>
                    {
                        var data = baseSales.Records.FirstOrDefault(y => x.SourceId == y.ID);
                        x.DateSales = DateTime.ParseExact(data.TANGGAL + ' ' + data.JAM_INPUT, CommonHelper.YMDHMSDateFormat,
                            CommonHelper.DateProvider);
                        x.TotalCash = data.LUNAS;
                        x.TotalChange = data.LUNAS - data.TOT_HARGA;
                        x.TotalAmount = data.TOT_HARGA;
                        return x;

                    })
                .ToList();


            var insert = baseSales.Records.Where(x => saleList.FirstOrDefault(y => y.SourceId == x.ID) == null).Select(x => new GfaWebSalesCreateUpdateSaleDto(
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
        }
    }

}
