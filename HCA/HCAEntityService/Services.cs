#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace HCAEntityService.Services
{
	using Telerik.OpenAccess;
	using System.Linq.Dynamic;
	using HRBlock.Library.BusinessObject.HCA;
	using HCAEntityService.Dto;
	using HCAEntityService.Assemblers;
	using HCAEntityService.Repositories;
	using HCAEntityService.Converters;
	using System;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.Serialization;

	
	public partial interface IService<TDto, TEntity>
	    where TEntity : class
		where TDto : IDtoWithKey
	{
	    IAssembler<TDto, TEntity> Assembler { get; }
	    IRepository<TEntity> Repository { get; }
	
	    IEnumerable<TDto> Find(Expression<Func<TEntity, bool>> filter);
	    IEnumerable<TDto> GetAll();
		
		IEnumerable<TDto> Find(int startRowIndex, int maximumRows);
	    IEnumerable<TDto> Find(string sortExpression, string filterExpression);
	    IEnumerable<TDto> Find(int? startRowIndex, int? maximumRows, string sortExpression, string filterExpression);
	    
		int Count();
	    int Count(string filterExpression);
		
		TDto GetByKey(string dtoKey);
	    string Add(TDto dto);
		void Update(TDto dto);
	    void Delete(TDto dto);	
	}
	
	public abstract partial class Service<TDto, TEntity> : IService<TDto, TEntity>
	    where TEntity : class
		where TDto : IDtoWithKey
	{
	    IAssembler<TDto, TEntity> assembler;
	    IRepository<TEntity> repository;
	
	    public Service(IAssembler<TDto, TEntity> assembler,
	        IRepository<TEntity> repository)
	    {
	        this.assembler = assembler;
	        this.repository = repository;
	    }
	
	    public IAssembler<TDto, TEntity> Assembler 
	    { 
	        get 
	        {
	            return this.assembler; 
	        } 
	    }
	
	    public IRepository<TEntity> Repository 
	    { 
	        get 
	        {
	            return this.repository; 
	        }
	    }
		
		public virtual IEnumerable<TDto> GetAll()
	    {
	        return this.assembler.Assemble(this.Repository.GetAll());
	    }
	
	    public virtual IEnumerable<TDto> Find(Expression<Func<TEntity, bool>> filter)
	    {
	        return this.Assembler.Assemble(this.Repository.Find(filter));
	    }
	
	    public virtual IEnumerable<TDto> Find(int startRowIndex, int maximumRows)
	    {
	        return this.Find(startRowIndex, maximumRows, null, null);
	    }
	
	    public virtual IEnumerable<TDto> Find(string sortExpression, string filterExpression)
	    {
	        return this.Find(null, null, sortExpression, filterExpression);
	    }
	
	    public virtual IEnumerable<TDto> Find(int? startRowIndex, int? maximumRows, string sortExpression, string filterExpression)
	    {
	        IQueryable<TEntity> query = this.Repository.GetAll();
	
	        if (!string.IsNullOrEmpty(filterExpression))
	        {
	            query = query.Where(filterExpression);
	        }
	        if (!string.IsNullOrEmpty(sortExpression))
	        {
	            query = query.OrderBy(sortExpression);
	        }
	        if (startRowIndex.HasValue)
	        {
	            query = query.Skip(startRowIndex.Value);
	        }
	        if (maximumRows.HasValue)
	        {
	            query = query.Take(maximumRows.Value);
	        }
	
	        return this.Assembler.Assemble(query);
	    }
	
	    public virtual int Count()
	    {
	        return this.Count(string.Empty);
	    }
	
	    public virtual int Count(string filterExpression)
	    {
	        IQueryable<TEntity> query = this.Repository.GetAll();
	
	        if (!string.IsNullOrEmpty(filterExpression))
	        {
	            query = query.Where(filterExpression);    
	        }
	
	        return query.Count();
	    }
	
	    
	    public virtual TDto GetByKey(string dtoKey)
	    {
	        ObjectKey key = KeyUtility.Instance.Convert<TEntity>(dtoKey);
			
	        return this.assembler.Assemble(this.Repository.Get(key));
	    }
	
	    public virtual string Add(TDto dto)
	    {
	        TEntity entity = this.assembler.Assemble(null, dto);
	
	        this.repository.Add(entity);
	
	        ObjectKey key = KeyUtility.Instance.Create(entity);
	
	        return KeyUtility.Instance.Convert(key);
	    }
	
	    public virtual void Update(TDto dto)
	    {
	        ObjectKey key = KeyUtility.Instance.Convert<TEntity>(dto.DtoKey);
	        TEntity entity = this.repository.Get(key);
	
	        this.assembler.Assemble(entity, dto);
	    }
	
	    public virtual void Delete(TDto dto)
	    {
			ObjectKey key = KeyUtility.Instance.Convert<TEntity>(dto.DtoKey);
	        TEntity entity = this.repository.Get(key);
	
	        this.Repository.Remove(entity);
	    }
	}
	
	public partial interface ILicenseService : IService<LicenseDto, License>
	{
	
	}
	
	public partial class LicenseService : Service<LicenseDto, License>, ILicenseService
	{
	    public LicenseService(ILicenseAssembler assembler, ILicenseRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface ICarrierAssignmentService : IService<CarrierAssignmentDto, CarrierAssignment>
	{
	
	}
	
	public partial class CarrierAssignmentService : Service<CarrierAssignmentDto, CarrierAssignment>, ICarrierAssignmentService
	{
	    public CarrierAssignmentService(ICarrierAssignmentAssembler assembler, ICarrierAssignmentRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface ICandidateService : IService<CandidateDto, Candidate>
	{
	
	}
	
	public partial class CandidateService : Service<CandidateDto, Candidate>, ICandidateService
	{
	    public CandidateService(ICandidateAssembler assembler, ICandidateRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
	
	public partial interface ICertificationService : IService<CertificationDto, Certification>
	{
	
	}
	
	public partial class CertificationService : Service<CertificationDto, Certification>, ICertificationService
	{
	    public CertificationService(ICertificationAssembler assembler, ICertificationRepository repository)
	        : base(assembler, repository)
	    {
	
	    }
	}
}
#pragma warning restore 1591
