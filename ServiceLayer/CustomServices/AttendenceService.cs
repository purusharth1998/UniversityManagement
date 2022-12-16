using DomainLayer.Model;
using DomainLayer.Models;
using RepositoryLayer.IRepository;
using ServiceLayer.ICustomServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.CustomServices
{
    public class AttendenceService: ICustomService<Attendence>
    {
        private readonly IRepository<Attendence> _attendenceRepository;
        public AttendenceService(IRepository<Attendence> attendenceRepository)
        {
            _attendenceRepository = attendenceRepository;
        }
        public void Delete(Attendence entity)
        {
            try
            {
                if (entity != null)
                {
                    _attendenceRepository.Delete(entity);
                    _attendenceRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Attendence Get(int Id)
        {
            try
            {
                var obj = _attendenceRepository.Get(Id);
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<Attendence> GetAll()
        {
            try
            {
                var obj = _attendenceRepository.GetAll();
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Insert(Attendence entity)
        {
            try
            {
                if (entity != null)
                {
                    _attendenceRepository.Insert(entity);
                    _attendenceRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Remove(Attendence entity)
        {
            try
            {
                if (entity != null)
                {
                    _attendenceRepository.Remove(entity);
                    _attendenceRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Update(Attendence entity)
        {
            try
            {
                if (entity != null)
                {
                    _attendenceRepository.Update(entity);
                    _attendenceRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

