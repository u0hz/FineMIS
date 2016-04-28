﻿
// This file was automatically generated by the PetaPoco T4 Template
// Do not make changes directly to this file - edit the template instead
// 
// The following connection settings were used to generate this file
// 
//     Connection String Name: `connectionString`
//     Provider:               `System.Data.SqlClient`
//     Connection String:      `Data Source=.\SQL90;Initial Catalog=C7V3;Integrated Security = SSPI;`
//     Schema:                 ``
//     Include Views:          `False`

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PetaPoco;

namespace FineMIS
{

    
	[TableName("dbo.SYS_DEPARTMENT")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class SYS_DEPARTMENT : BaseModel<SYS_DEPARTMENT, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public long? ParentId { get; set; }
	
		[Column] public string Name { get; set; }
	
		[Column] public int? SortIndex { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.WEG_WEIGHING")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class WEG_WEIGHING : BaseModel<WEG_WEIGHING, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public string Code { get; set; }
	
		[Column] public string ClientId { get; set; }
	
		[Column] public int? Status { get; set; }
	
		[Column] public int? Verified { get; set; }
	
		[Column] public string Remarks { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.SYS_ROLE")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class SYS_ROLE : BaseModel<SYS_ROLE, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public string Name { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.SYS_ROLE_MENU_ACTION")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class SYS_ROLE_MENU_ACTION : BaseModel<SYS_ROLE_MENU_ACTION, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public long? RoleId { get; set; }
	
		[Column] public long? MenuId { get; set; }
	
		[Column] public long? ActionId { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.SYS_USER_ROLE")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class SYS_USER_ROLE : BaseModel<SYS_USER_ROLE, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public long? UserId { get; set; }
	
		[Column] public long? RoleId { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.SYS_USER")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class SYS_USER : BaseModel<SYS_USER, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public string Name { get; set; }
	
		[Column] public string UserName { get; set; }
	
		[Column] public string Password { get; set; }
	
		[Column] public long? DepartmentId { get; set; }
	
		[Column] public string Phone { get; set; }
	
		[Column] public string Email { get; set; }
	
		[Column] public bool? Enabled { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.CNF_SILO")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class CNF_SILO : BaseModel<CNF_SILO, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public string Code { get; set; }
	
		[Column] public string Name { get; set; }
	
		[Column] public string ClientId { get; set; }
	
		[Column] public int? SortIndex { get; set; }
	
		[Column] public string MapColumn { get; set; }
	
		[Column] public long? LineId { get; set; }
	
		[Column] public string LineName { get; set; }
	
		[Column] public long? MaterialId { get; set; }
	
		[Column] public string MaterialName { get; set; }
	
		[Column] public string MaterialType { get; set; }
	
		[Column] public decimal? Volume { get; set; }
	
		[Column] public decimal? MaxVolume { get; set; }
	
		[Column] public decimal? MinVolume { get; set; }
	
		[Column] public int? Status { get; set; }
	
		[Column] public int? Verified { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.SYS_ROLE_MENU")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class SYS_ROLE_MENU : BaseModel<SYS_ROLE_MENU, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public long? RoleId { get; set; }
	
		[Column] public long? MenuId { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.CNF_MATERIAL")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class CNF_MATERIAL : BaseModel<CNF_MATERIAL, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public string Code { get; set; }
	
		[Column] public string Name { get; set; }
	
		[Column] public string ClientId { get; set; }
	
		[Column] public int? SortIndex { get; set; }
	
		[Column] public string MapColumn { get; set; }
	
		[Column] public string Usage { get; set; }
	
		[Column] public string Type { get; set; }
	
		[Column] public string Category { get; set; }
	
		[Column] public string Modal { get; set; }
	
		[Column] public string Unit { get; set; }
	
		[Column] public string Orgin { get; set; }
	
		[Column] public string Manufacturer { get; set; }
	
		[Column] public long? Status { get; set; }
	
		[Column] public short? Verified { get; set; }
	
		[Column] public string Remarks { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.SYS_MENU")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class SYS_MENU : BaseModel<SYS_MENU, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public long? ParentId { get; set; }
	
		[Column] public string Name { get; set; }
	
		[Column] public string ViewName { get; set; }
	
		[Column] public string ImageUrl { get; set; }
	
		[Column] public string NavigateUrl { get; set; }
	
		[Column] public int? SortIndex { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.PRD_DELIVERY")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class PRD_DELIVERY : BaseModel<PRD_DELIVERY, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public string Code { get; set; }
	
		[Column] public string Serial { get; set; }
	
		[Column] public string ClientId { get; set; }
	
		[Column] public string NodeCode { get; set; }
	
		[Column] public long? ProjectId { get; set; }
	
		[Column] public string ProjectName { get; set; }
	
		[Column] public long? CustomerId { get; set; }
	
		[Column] public string CustomerName { get; set; }
	
		[Column] public long? ContractId { get; set; }
	
		[Column] public string ContractName { get; set; }
	
		[Column] public long? LineId { get; set; }
	
		[Column] public string LineName { get; set; }
	
		[Column] public long? PlanId { get; set; }
	
		[Column] public string PlanName { get; set; }
	
		[Column] public long? TaskId { get; set; }
	
		[Column] public string TaskName { get; set; }
	
		[Column] public long? TheoryProportionId { get; set; }
	
		[Column] public string TheoryProportionName { get; set; }
	
		[Column] public long? ActualProportionId { get; set; }
	
		[Column] public string ActualProportionName { get; set; }
	
		[Column] public string ConstructionUnit { get; set; }
	
		[Column] public string BuildingUnit { get; set; }
	
		[Column] public string SupervisionUnit { get; set; }
	
		[Column] public string Address { get; set; }
	
		[Column] public decimal? Distance { get; set; }
	
		[Column] public string DistanceRange { get; set; }
	
		[Column] public string Marker { get; set; }
	
		[Column] public string Grade { get; set; }
	
		[Column] public string Slump { get; set; }
	
		[Column] public string StoneSizeLevel { get; set; }
	
		[Column] public string SandSizeLevel { get; set; }
	
		[Column] public string SpecialRequest { get; set; }
	
		[Column] public string PouringPart { get; set; }
	
		[Column] public string PouringMode { get; set; }
	
		[Column] public string MixerTruck { get; set; }
	
		[Column] public string MixerDriver { get; set; }
	
		[Column] public string PumperTruck { get; set; }
	
		[Column] public string ForkliftTruck { get; set; }
	
		[Column] public string Operator { get; set; }
	
		[Column] public DateTime? OperateTime { get; set; }
	
		[Column] public DateTime? SetOutTime { get; set; }
	
		[Column] public DateTime? ArriveTime { get; set; }
	
		[Column] public DateTime? ReturnTime { get; set; }
	
		[Column] public decimal? PlanQuantity { get; set; }
	
		[Column] public decimal? TotalQuantity { get; set; }
	
		[Column] public int? TotalTripCount { get; set; }
	
		[Column] public decimal? Quantity { get; set; }
	
		[Column] public decimal? PrdQuantity { get; set; }
	
		[Column] public decimal? PrtQuantity { get; set; }
	
		[Column] public decimal? ChkQuantity { get; set; }
	
		[Column] public decimal? ResQuantity { get; set; }
	
		[Column] public long? SourceDeliveryId { get; set; }
	
		[Column] public decimal? PlateVolume { get; set; }
	
		[Column] public int? PlateCount { get; set; }
	
		[Column] public int? Status { get; set; }
	
		[Column] public int? Verified { get; set; }
	
		[Column] public string Remarks { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.PRD_MANUFACTURE")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class PRD_MANUFACTURE : BaseModel<PRD_MANUFACTURE, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public string Code { get; set; }
	
		[Column] public string ClientId { get; set; }
	
		[Column] public string NodeCode { get; set; }
	
		[Column] public long? DeliveryId { get; set; }
	
		[Column] public DateTime? StartTime { get; set; }
	
		[Column] public DateTime? EndTime { get; set; }
	
		[Column] public int? PlateIndex { get; set; }
	
		[Column] public decimal? Quantity { get; set; }
	
		[Column] public int? Duration { get; set; }
	
		[Column] public int? Status { get; set; }
	
		[Column] public int? Verified { get; set; }
	
		[Column] public string Remarks { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.PRD_COMSUPTION")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class PRD_COMSUPTION : BaseModel<PRD_COMSUPTION, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public string Code { get; set; }
	
		[Column] public string ClientId { get; set; }
	
		[Column] public string NodeCode { get; set; }
	
		[Column] public long? ManufactureId { get; set; }
	
		[Column] public long? SiloId { get; set; }
	
		[Column] public string SiloName { get; set; }
	
		[Column] public long? MaterialId { get; set; }
	
		[Column] public string MaterialType { get; set; }
	
		[Column] public string MaterialName { get; set; }
	
		[Column] public decimal? TheoryValue { get; set; }
	
		[Column] public decimal? ActualValue { get; set; }
	
		[Column] public decimal? Deviation { get; set; }
	
		[Column] public int? Status { get; set; }
	
		[Column] public int? Verified { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.SYS_ACTION")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class SYS_ACTION : BaseModel<SYS_ACTION, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public string Name { get; set; }
	
		[Column] public long? MenuId { get; set; }
	
		[Column] public string ControlId { get; set; }
	
		[Column] public string ControlType { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.PRD_TASK")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class PRD_TASK : BaseModel<PRD_TASK, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public string Code { get; set; }
	
		[Column] public string Name { get; set; }
	
		[Column] public string ClientId { get; set; }
	
		[Column] public string NodeCode { get; set; }
	
		[Column] public long? ProjectId { get; set; }
	
		[Column] public string ProjectName { get; set; }
	
		[Column] public long? CustomerId { get; set; }
	
		[Column] public string CustomerName { get; set; }
	
		[Column] public long? ContractId { get; set; }
	
		[Column] public string ContractName { get; set; }
	
		[Column] public long? LineId { get; set; }
	
		[Column] public string LineName { get; set; }
	
		[Column] public long? PlanId { get; set; }
	
		[Column] public string PlanName { get; set; }
	
		[Column] public long? TheoryProportionId { get; set; }
	
		[Column] public string TheoryProportionName { get; set; }
	
		[Column] public long? ActualProportionId { get; set; }
	
		[Column] public string ActualProportionName { get; set; }
	
		[Column] public string ConstructionUnit { get; set; }
	
		[Column] public string BuildingUnit { get; set; }
	
		[Column] public string SupervisionUnit { get; set; }
	
		[Column] public string Address { get; set; }
	
		[Column] public decimal? Distance { get; set; }
	
		[Column] public string DistanceRange { get; set; }
	
		[Column] public string Marker { get; set; }
	
		[Column] public string Grade { get; set; }
	
		[Column] public string Slump { get; set; }
	
		[Column] public string StoneSizeLevel { get; set; }
	
		[Column] public string SandSizeLevel { get; set; }
	
		[Column] public string SpecialRequest { get; set; }
	
		[Column] public string PouringPart { get; set; }
	
		[Column] public string PouringMode { get; set; }
	
		[Column] public decimal? PlanQuantity { get; set; }
	
		[Column] public decimal? TotalQuantity { get; set; }
	
		[Column] public int? TotalTripCount { get; set; }
	
		[Column] public int? Status { get; set; }
	
		[Column] public int? Verified { get; set; }
	
		[Column] public string Remarks { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.CNF_LINE")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class CNF_LINE : BaseModel<CNF_LINE, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public string Code { get; set; }
	
		[Column] public string Name { get; set; }
	
		[Column] public string ClientId { get; set; }
	
		[Column] public string Type { get; set; }
	
		[Column] public string Brand { get; set; }
	
		[Column] public string Model { get; set; }
	
		[Column] public string IPCBrand { get; set; }
	
		[Column] public string IPCModel { get; set; }
	
		[Column] public decimal? PlateVolume { get; set; }
	
		[Column] public decimal? Capacity { get; set; }
	
		[Column] public int? Status { get; set; }
	
		[Column] public int? Verified { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.INV_STOCK")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class INV_STOCK : BaseModel<INV_STOCK, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public string Code { get; set; }
	
		[Column] public string ClientId { get; set; }
	
		[Column] public int? Status { get; set; }
	
		[Column] public int? Verified { get; set; }
	
		[Column] public string Remarks { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.INV_STOCK_IN")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class INV_STOCK_IN : BaseModel<INV_STOCK_IN, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public string Code { get; set; }
	
		[Column] public string ClientId { get; set; }
	
		[Column] public int? Status { get; set; }
	
		[Column] public int? Verified { get; set; }
	
		[Column] public string Remarks { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.state")]
	[PrimaryKey("id")]
	[ExplicitColumns]
    public partial class state : BaseModel<state, int>
    {
		[Column] public int id { get; set; }
	
		[Column] public string type { get; set; }
	
		[Column] public string name { get; set; }
	
		[Column] public string from { get; set; }
	
		[Column] public string to { get; set; }
	
		[Column] public int? result { get; set; }
	
		[Column("readonly")] public bool? @readonly { get; set; }
		[Column] public int? company_id { get; set; }
	
	}
    
	[TableName("dbo.INV_STOCK_OUT")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class INV_STOCK_OUT : BaseModel<INV_STOCK_OUT, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public string Code { get; set; }
	
		[Column] public string ClientId { get; set; }
	
		[Column] public int? Status { get; set; }
	
		[Column] public int? Verified { get; set; }
	
		[Column] public string Remarks { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
    
	[TableName("dbo.SYS_COMPANY")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class SYS_COMPANY : BaseModel<SYS_COMPANY, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public string Name { get; set; }
	
		[Column] public string FullName { get; set; }
	
		[Column] public string AbbrName { get; set; }
	
		[Column] public string RegionCode { get; set; }
	
		[Column] public decimal? RegisteredCapital { get; set; }
	
		[Column] public decimal? NetWorth { get; set; }
	
		[Column] public string Address { get; set; }
	
		[Column] public string Contact { get; set; }
	
		[Column] public string ContactPhone { get; set; }
	
		[Column] public string Tel { get; set; }
	
		[Column] public string Fax { get; set; }
	
		[Column] public string Zip { get; set; }
	
		[Column] public string Email { get; set; }
	
		[Column] public string Website { get; set; }
	
		[Column] public string Longitude { get; set; }
	
		[Column] public string Latitude { get; set; }
	
		[Column] public string ValidRadius { get; set; }
	
		[Column] public int? Status { get; set; }
	
		[Column] public int? Verified { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
}


