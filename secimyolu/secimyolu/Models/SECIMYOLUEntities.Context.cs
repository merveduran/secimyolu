﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace secimyolu.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SECIMYOLUEntities : DbContext
    {
        public SECIMYOLUEntities()
            : base("name=SECIMYOLUEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CarType> CarType { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Destination> Destination { get; set; }
        public virtual DbSet<Mail> Mail { get; set; }
        public virtual DbSet<MailError> MailError { get; set; }
        public virtual DbSet<MailStatus> MailStatus { get; set; }
        public virtual DbSet<ResetPassword> ResetPassword { get; set; }
        public virtual DbSet<Right> Right { get; set; }
        public virtual DbSet<ServicePassenger> ServicePassenger { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserCountry> UserCountry { get; set; }
        public virtual DbSet<UserRight> UserRight { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<CountryTemp> CountryTemp { get; set; }
        public virtual DbSet<vwCarSearchQuery> vwCarSearchQuery { get; set; }
        public virtual DbSet<vwServicePassenger> vwServicePassenger { get; set; }
        public virtual DbSet<vwUserList> vwUserList { get; set; }
        public virtual DbSet<CarService> CarService { get; set; }
        public virtual DbSet<vwCarList> vwCarList { get; set; }
        public virtual DbSet<DestinationPollingDates> DestinationPollingDates { get; set; }
        public virtual DbSet<PollingList> PollingList { get; set; }
        public virtual DbSet<PollingBox> PollingBox { get; set; }
        public virtual DbSet<PollingClerk> PollingClerk { get; set; }
        public virtual DbSet<vwPollingBox> vwPollingBox { get; set; }
    
        [DbFunction("SECIMYOLUEntities", "GetRightsOfTheUser")]
        public virtual IQueryable<GetRightsOfTheUser_Result> GetRightsOfTheUser(Nullable<int> p1)
        {
            var p1Parameter = p1.HasValue ?
                new ObjectParameter("p1", p1) :
                new ObjectParameter("p1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetRightsOfTheUser_Result>("[SECIMYOLUEntities].[GetRightsOfTheUser](@p1)", p1Parameter);
        }
    
        [DbFunction("SECIMYOLUEntities", "GetRightsOfTheUserr")]
        public virtual IQueryable<GetRightsOfTheUserr_Result> GetRightsOfTheUserr(Nullable<int> p1)
        {
            var p1Parameter = p1.HasValue ?
                new ObjectParameter("p1", p1) :
                new ObjectParameter("p1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetRightsOfTheUserr_Result>("[SECIMYOLUEntities].[GetRightsOfTheUserr](@p1)", p1Parameter);
        }
    }
}
