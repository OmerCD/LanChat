using System;

namespace LanChat.Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool IsDeleted { get; set; }
    }

    public abstract class UserEntity : BaseEntity
    {
        public User CreatedBy { get; set; }
        public User? UpdatedBy { get; set; }
    }
}