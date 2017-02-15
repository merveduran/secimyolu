//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CarService
    {
        public int Id { get; set; }
        public Nullable<int> CarTypeId { get; set; }
        public string PostalCode { get; set; }
        public string CityName { get; set; }
        public string Address { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> Destination { get; set; }
        public Nullable<System.DateTime> DepartureDate { get; set; }
        public string DepartureHour { get; set; }
        public int Qutoa { get; set; }
        public Nullable<int> Status { get; set; }
        public string ResponsibleName { get; set; }
        public string ResponsiblePhone { get; set; }
        public string Description { get; set; }
        public Nullable<int> AddUserId { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<int> DeletedUserId { get; set; }
        public Nullable<System.DateTime> DeleteDate { get; set; }
        public Nullable<bool> IsVoluntaryService { get; set; }
        public string MapLatitude { get; set; }
        public string MapLongitude { get; set; }
    }
}
