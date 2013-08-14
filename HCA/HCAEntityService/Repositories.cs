#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace HCAEntityService.Repositories
{
	using Telerik.OpenAccess;
	using HRBlock.Library.BusinessObject.HCA;
	using System;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.Serialization;

	
	public partial interface IRepository<TEntity>
	{
	    void Add(TEntity entity);
	    void Remove(TEntity entity);
	
	    TEntity Get(ObjectKey objectKey);
	    
	    IQueryable<TEntity> GetAll();
	
	    IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
	}
	
	public partial class Repository<TEntity> : IRepository<TEntity>
	        where TEntity : class
	{
	    protected IUnitOfWork unitOfWork;
	
	    public Repository(IUnitOfWork unitOfWork)
	    {
	        this.unitOfWork = unitOfWork;
	    }
	
	    public void Add(TEntity entity)
	    {
			this.unitOfWork.Add(entity);
	    }
	
	    public void Remove(TEntity entity)
	    {
	        this.unitOfWork.Delete(entity);
	    }
	
	    public IQueryable<TEntity> GetAll()
	    {
	        return this.unitOfWork.GetAll<TEntity>();
	    }
	
	    public TEntity Get(ObjectKey objectKey)
	    {
	        return this.unitOfWork.GetObjectByKey<TEntity>(objectKey);
	    }
	
	    public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
	    {
	        return this.unitOfWork.GetAll<TEntity>().Where(predicate);
	    }
	}
	
	public partial interface ILicenseRepository : IRepository<License>
	{ 
	
	}
	
	public partial class LicenseRepository : Repository<License>, ILicenseRepository
	{
	    public LicenseRepository(IHCAEntityModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface ICarrierAssignmentRepository : IRepository<CarrierAssignment>
	{ 
	
	}
	
	public partial class CarrierAssignmentRepository : Repository<CarrierAssignment>, ICarrierAssignmentRepository
	{
	    public CarrierAssignmentRepository(IHCAEntityModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface ICandidateRepository : IRepository<Candidate>
	{ 
	
	}
	
	public partial class CandidateRepository : Repository<Candidate>, ICandidateRepository
	{
	    public CandidateRepository(IHCAEntityModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
	
	public partial interface ICertificationRepository : IRepository<Certification>
	{ 
	
	}
	
	public partial class CertificationRepository : Repository<Certification>, ICertificationRepository
	{
	    public CertificationRepository(IHCAEntityModelUnitOfWork unitOfWork)
	        : base(unitOfWork)
	    {
	    }
	}
}
#pragma warning restore 1591
