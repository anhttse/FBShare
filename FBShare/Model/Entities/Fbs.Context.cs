﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FBShare.Model.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FbsEntities : DbContext
    {
        public FbsEntities()
            : base("name=FbsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Caption> Captions { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual ObjectResult<GetGroups_Result> GetGroups(string userId, Nullable<int> memberCount, string privacy)
        {
            var userIdParameter = userId != null ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(string));
    
            var memberCountParameter = memberCount.HasValue ?
                new ObjectParameter("MemberCount", memberCount) :
                new ObjectParameter("MemberCount", typeof(int));
    
            var privacyParameter = privacy != null ?
                new ObjectParameter("Privacy", privacy) :
                new ObjectParameter("Privacy", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetGroups_Result>("GetGroups", userIdParameter, memberCountParameter, privacyParameter);
        }
    }
}
