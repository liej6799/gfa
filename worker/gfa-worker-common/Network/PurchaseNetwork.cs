using System;
using System.Linq;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace gfa_worker_common.Network
{
    public class PurchaseNetwork
    {
        private readonly PurchaseItemApi _purchaseItemApi;
        private readonly PurchaseApi _purchaseApi;
        private readonly VendorApi _vendorApi;
        private readonly ItemApi _itemApi;
        public PurchaseNetwork()
        {
            _purchaseApi = new PurchaseApi(CommonHelper.NetworkConfiguration);
            _vendorApi = new VendorApi(CommonHelper.NetworkConfiguration);
            _purchaseItemApi = new PurchaseItemApi(CommonHelper.NetworkConfiguration);
            _itemApi = new ItemApi(CommonHelper.NetworkConfiguration);
        }
        
        public void Run(BasePurchase basePurchase, DateTime startDate, DateTime endDate)
        {
            var purchaseList = _purchaseApi.ApiAppPurchaseNoPagedGet(startDate, endDate);
            var vendorList = _vendorApi.ApiAppVendorNoPagedGet();
            var purchaseItemList = _purchaseItemApi.ApiAppPurchaseItemNoPagedGet(startDate, endDate);
            var itemList = _itemApi.ApiAppItemNoPagedGet();


            var update = purchaseList.Where(x => basePurchase.Records.FirstOrDefault(y => y.ID == x.SourceId
                && !(DateTime.ParseExact(y.TANGGAL + ' ' + y.JAM_INPUT, CommonHelper.YMDHMSDateFormat, CommonHelper.DateProvider) == x.DatePurchase
                                                                      && y.VENDOR == x.VendorSourceId
                                                                      && Math.Abs(y.TOT_HARGA - x.TotalAmount) == 0)) != null).Select(
                    x =>
                    {
                        var data = basePurchase.Records.FirstOrDefault(y => x.SourceId == y.ID);
                        x.DatePurchase = DateTime.ParseExact(data.TANGGAL + ' ' + data.JAM_INPUT, CommonHelper.YMDHMSDateFormat,
                            CommonHelper.DateProvider);
                        x.VendorId = vendorList.FirstOrDefault(y => y.SourceId == data.VENDOR).Id;
                        x.TotalAmount = data.TOT_HARGA;
                        return x;

                    })
                .ToList();
            
            
            var insert = basePurchase.Records.Where(x => purchaseList.FirstOrDefault(y => y.SourceId == x.ID) == null).Select(x => new GfaWebPurchasesCreateUpdatePurchaseDto(
                sourceId: x.ID,
                datePurchase: DateTime.ParseExact(x.TANGGAL + ' ' + x.JAM_INPUT, CommonHelper.YMDHMSDateFormat, CommonHelper.DateProvider),
                vendorId: vendorList.FirstOrDefault(y => y.SourceId == x.VENDOR).Id,
                totalAmount: x.TOT_HARGA
            
            )).ToList();

            foreach (var item in update)
            {
                _purchaseApi.ApiAppPurchaseIdPut(item.Id, item);
            }
        
            _purchaseApi.ApiAppPurchaseBatchInsertPost(insert);
            
            purchaseList = _purchaseApi.ApiAppPurchaseNoPagedGet(startDate, endDate);

            var basePurchaseDetail = basePurchase.Records.SelectMany(x => x.Detail).ToList();
            
            var updateDetail = purchaseItemList.Where(x => basePurchaseDetail.FirstOrDefault(y =>
                (x.ItemSourceId == y.STOCK_ID &&
                x.PurchaseSourceId == y.PEMBEL_ID) &&
                !(Math.Abs(x.Quantity - y.JUMLAH) == 0
                && Math.Abs(x.Price - (y.HARGA / y.JUMLAH)) == 0
                && Math.Abs(x.Total - y.HARGA) == 0
                )) != null).Select(x =>
                {
                    var data = basePurchaseDetail.FirstOrDefault(y => x.ItemSourceId == y.STOCK_ID &&  x.PurchaseSourceId == y.PEMBEL_ID);
                    x.Quantity = data.JUMLAH;
                    x.Total = data.HARGA;
                    x.Price = (data.HARGA / data.JUMLAH);
                    return x;
                });


            var insertDetail = basePurchaseDetail
                .Where(x => purchaseItemList.FirstOrDefault(y => 
                        y.ItemSourceId == x.STOCK_ID
                        && y.PurchaseSourceId == x.PEMBEL_ID
                            ) == null && 
                            (itemList.FirstOrDefault(y => y.SourceId == x.STOCK_ID) != null 
                             &&(purchaseList.FirstOrDefault(y => y.SourceId == x.PEMBEL_ID) != null)))
                .Select(x => new GfaWebPurchasesCreateUpdatePurchaseItemDto(
                    quantity: x.JUMLAH,
                    total: x.HARGA,
                    price: (x.HARGA / x.JUMLAH),
                    itemId: itemList.FirstOrDefault(y => y.SourceId == x.STOCK_ID).Id,
                    purchaseId: purchaseList.FirstOrDefault(y => y.SourceId == x.PEMBEL_ID).Id
                )).ToList();
            
            foreach (var item in updateDetail)
            {
                _purchaseItemApi.ApiAppPurchaseItemIdPut(item.Id, item);
            }
            
            _purchaseItemApi.ApiAppPurchaseItemBatchInsertPost(insertDetail);
        }
    }
}