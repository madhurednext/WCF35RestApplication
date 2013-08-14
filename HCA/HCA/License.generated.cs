#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using HRBlock.Library.BusinessObject.HCA;

namespace HRBlock.Library.BusinessObject.HCA	
{
	public partial class License
	{
		private int _id;
		public virtual int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		private int _candidateId;
		public virtual int CandidateId
		{
			get
			{
				return this._candidateId;
			}
			set
			{
				this._candidateId = value;
			}
		}
		
		private string _licenseNo;
		public virtual string LicenseNo
		{
			get
			{
				return this._licenseNo;
			}
			set
			{
				this._licenseNo = value;
			}
		}
		
		private string _state;
		public virtual string State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		
		private string _licenseType;
		public virtual string LicenseType
		{
			get
			{
				return this._licenseType;
			}
			set
			{
				this._licenseType = value;
			}
		}
		
		private DateTime _dateAcquired;
		public virtual DateTime DateAcquired
		{
			get
			{
				return this._dateAcquired;
			}
			set
			{
				this._dateAcquired = value;
			}
		}
		
		private DateTime? _dateExpires;
		public virtual DateTime? DateExpires
		{
			get
			{
				return this._dateExpires;
			}
			set
			{
				this._dateExpires = value;
			}
		}
		
		private DateTime? _dateRenewed;
		public virtual DateTime? DateRenewed
		{
			get
			{
				return this._dateRenewed;
			}
			set
			{
				this._dateRenewed = value;
			}
		}
		
		private int _createdById;
		public virtual int CreatedById
		{
			get
			{
				return this._createdById;
			}
			set
			{
				this._createdById = value;
			}
		}
		
		private DateTime _dateCreated;
		public virtual DateTime DateCreated
		{
			get
			{
				return this._dateCreated;
			}
			set
			{
				this._dateCreated = value;
			}
		}
		
		private int? _modifiedById;
		public virtual int? ModifiedById
		{
			get
			{
				return this._modifiedById;
			}
			set
			{
				this._modifiedById = value;
			}
		}
		
		private DateTime? _dateModified;
		public virtual DateTime? DateModified
		{
			get
			{
				return this._dateModified;
			}
			set
			{
				this._dateModified = value;
			}
		}
		
		private bool _active;
		public virtual bool Active
		{
			get
			{
				return this._active;
			}
			set
			{
				this._active = value;
			}
		}
		
		private Candidate _candidate;
		public virtual Candidate Candidate
		{
			get
			{
				return this._candidate;
			}
			set
			{
				this._candidate = value;
			}
		}
		
	}
}
#pragma warning restore 1591