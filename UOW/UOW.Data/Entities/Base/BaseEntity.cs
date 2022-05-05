using System;

namespace UOW.Data.Entities
{
    public class BaseEntity
    {
        public Guid ID { get; set; }
        public bool IsActive { get; set; }
    }
}
