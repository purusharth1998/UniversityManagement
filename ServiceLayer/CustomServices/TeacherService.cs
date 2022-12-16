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
    public class TeacherService : ICustomService<Teacher>
    {
        private readonly IRepository<Teacher> _teacherRepository;
        public TeacherService(IRepository<Teacher> teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public void Delete(Teacher entity)
        {
            try
            {
                if (entity != null)
                {
                    _teacherRepository.Delete(entity);
                    _teacherRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Teacher Get(int Id)
        {
            try
            {
                var obj = _teacherRepository.Get(Id);
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
        public IEnumerable<Teacher> GetAll()
        {
            try
            {
                var obj = _teacherRepository.GetAll();
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
        public void Insert(Teacher entity)
        {
            try
            {
                if (entity != null)
                {
                    _teacherRepository.Insert(entity);
                    _teacherRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Remove(Teacher entity)
        {
            try
            {
                if (entity != null)
                {
                    _teacherRepository.Remove(entity);
                    _teacherRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Update(Teacher entity)
        {
            try
            {
                if (entity != null)
                {
                    _teacherRepository.Update(entity);
                    _teacherRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}