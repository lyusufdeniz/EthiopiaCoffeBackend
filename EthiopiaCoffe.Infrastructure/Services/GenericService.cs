using AutoMapper;
using EthiopiaCoffe.Domain.Abstract.Entities;
using EthiopiaCoffe.Repository.DTOs;
using EthiopiaCoffe.Repository.Repositories;
using EthiopiaCoffe.Repository.Services;
using EthiopiaCoffe.Repository.UnitOfWorks;
using System.Net;

namespace EthiopiaCoffe.Infrastructure.Services
{
    public class GenericService<T, TDTO> : IGenericService<T, TDTO> where T : class ,IBaseEntity,new() where TDTO : class ,new()
    {
    
        protected readonly IMapper _mapper;
        protected readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<T> _genericRepository;

        public GenericService(IMapper mapper, IGenericRepository<T> genericRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _genericRepository = genericRepository;
            _unitOfWork = unitOfWork;
        }

        public  async Task<ResponseDTO<Guid>> AddAsync(TDTO entity)
        {
            var id=await _genericRepository.AddAsync(_mapper.Map<T>(entity));
            await _unitOfWork.CommitAsync();

            return ResponseDTO<Guid>.Succes(id,HttpStatusCode.Created);

        }

        public ResponseDTO<NoContent> Delete(TDTO entity)
        {
            if (entity == null)
            {
                ResponseDTO<NoContent>.Fail($"{typeof(T).Name} Not Found ", HttpStatusCode.NotFound);
            }
       
            _genericRepository.Delete(_mapper.Map<T>(entity));
            _unitOfWork.Commit();
            return ResponseDTO<NoContent>.Succes(HttpStatusCode.NoContent);
        }

        public async Task<ResponseDTO<NoContent>> Delete(Guid id)
        {
            var entity = await _genericRepository.GetByIdAsync(id) ;
            if (entity == null)
            {
             return   ResponseDTO<NoContent>.Fail($"{typeof(T).Name} Not Found ", HttpStatusCode.NotFound);
            }
            _genericRepository.Delete(entity);
            await _unitOfWork.CommitAsync();
            return ResponseDTO<NoContent>.Succes(HttpStatusCode.NoContent);
        }

        public ResponseDTO<List<TDTO>> GetAll()=> ResponseDTO<List<TDTO>>.Succes(_mapper.Map<List<TDTO>>(_genericRepository.All()));

        public async Task<ResponseDTO<TDTO>> GetByIdAsync(Guid id)
        {
            var entity= await _genericRepository.GetByIdAsync(id);
            if(entity == null)
            {
              return  ResponseDTO<TDTO>.Fail($"{typeof(T).Name} Not Found",HttpStatusCode.NotFound);
            }
            return ResponseDTO<TDTO>.Succes(_mapper.Map<TDTO>(entity));

        }

        public ResponseDTO<NoContent> Update(TDTO entity)
        {
           _genericRepository.Update(_mapper.Map<T>(entity));
            _unitOfWork.Commit();
            return ResponseDTO<NoContent>.Succes(HttpStatusCode.NoContent);

        }
    }
}
