using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using gfa_web.Items;
using gfa_web.Purchases;
using gfa_web.Sales;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.BackgroundWorkers;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Threading;
using Volo.Abp.Uow;
using Volo.Abp.Application.Services;
namespace gfa_webWorker.Quantity
{
 

    [UnitOfWork]   
    public class QuantityWorker : AsyncPeriodicBackgroundWorkerBase, ISingletonDependency
    {
        private readonly IItemRepository _itemRepository;
        private readonly IPurchaseRepository _purchaseRepository;
        private readonly IPurchaseItemRepository _purchaseItemRepository;
        private readonly ISaleRepository _saleRepository;
        private readonly ISaleItemRepository _saleItemRepository;

        
        public QuantityWorker(AbpAsyncTimer timer, IServiceScopeFactory serviceScopeFactory,
            IItemRepository itemRepository,
            IPurchaseRepository purchaseRepository,
            IPurchaseItemRepository purchaseItemRepository,
            ISaleRepository saleRepository,
            ISaleItemRepository saleItemRepository
            ) : base(timer, serviceScopeFactory)
        {
            _itemRepository = itemRepository;
            _purchaseRepository = purchaseRepository;
            _purchaseItemRepository = purchaseItemRepository;
            _saleRepository = saleRepository;
            _saleItemRepository = saleItemRepository;
            Timer.Period = 3600000;
        }

        protected override async  Task DoWorkAsync(PeriodicBackgroundWorkerContext workerContext)
        {
            var itemRepository = await _itemRepository.ToListAsync();
            foreach (var item in itemRepository)
            {
                var totalPurchaseQuantity = _purchaseItemRepository.Where(x => x.ItemId == item.Id)
                    .Sum(x => x.Quantity);
                
                var totalSaleQuantity = _saleItemRepository.Where(x => x.ItemId == item.Id)
                    .Sum(x => x.Quantity);
                item.Quantity = Math.Abs(totalPurchaseQuantity) - Math.Abs(totalSaleQuantity);
                await _itemRepository.UpdateAsync(item);
            }
        }
    }
}