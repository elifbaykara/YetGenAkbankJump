using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetGenAkbankJump.Domain.Entities;
using YetGenAkbankJump.Domain.Enums;

namespace YetGenAkbankJump.Domain.Identity
{

    public class User : IdentityUser<Guid>, IEntityBase<Guid>, ICreatedByEntity, IModifiedByEntity, IDeletedByEntity
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public DateTimeOffset? BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string CreatedByUserId { get; set; }
        public DateTimeOffset CreatedOn {  get; set; }
        public string? ModifiedByUserId { get; set; }
        public DateTimeOffset? LastModifiedOn { get; set; }
        public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? DeletedByUserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTimeOffset? DeletedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
