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

    
	[TableName("dbo.SYS_MENU")]
	[PrimaryKey("Id")]
	[ExplicitColumns]
    public partial class SYS_MENU : BaseModel<SYS_MENU, long>
    {
		[Column] public override long Id { get; set; }
	
		[Column] public long? ParentId { get; set; }
	
		[Column] public string Name { get; set; }
	
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
	
		[Column] public long? RoleId { get; set; }
	
		[Column] public override string CreateBy { get; set; }
	
		[Column] public override DateTime CreateDate { get; set; }
	
		[Column] public override string LastUpdateBy { get; set; }
	
		[Column] public override DateTime LastUpdateDate { get; set; }
	
		[Column] public override bool Active { get; set; }
	
		[Column] public override long UserBelongTo { get; set; }
	
		[Column] public override long CmpyBelongTo { get; set; }
	
	}
}


