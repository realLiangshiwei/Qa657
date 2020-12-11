using System;
using qa657.Users;
using Volo.Abp.Domain.Entities.Auditing;

namespace qa657
{
    public class InventoryAdjustmentLog : AuditedEntityWithUser<Guid, AppUser>
    {
        public InventoryAdjustmentLog()
        {
        }

        public Guid? UserId { get; set; }

        public int CurrentStockLevel { get; set; }

        public int AdjustedStockLevel { get; set; }
    }
}
