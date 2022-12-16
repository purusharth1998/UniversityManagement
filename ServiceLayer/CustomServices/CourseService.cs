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
    public class CourseService : ICustomService<Course>
    {
        private readonly IRepository<Course> _courseRepository;
        public CourseService(IRepository<Course> courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public void Delete(Course entity)
        {
            try
            {
                if (entity != null)
                {
                    _courseRepository.Delete(entity);
                    _courseRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Course Get(int Id)
        {
            try
            {
                var obj = _courseRepository.Get(Id);
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
        public IEnumerable<Course> GetAll()
        {
            try
            {
                var obj = _courseRepository.GetAll();
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
        public void Insert(Course entity)
        {
            try
            {
                if (entity != null)
                {
                    _courseRepository.Insert(entity);
                    _courseRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Remove(Course entity)
        {
            try
            {
                if (entity != null)
                {
                    _courseRepository.Remove(entity);
                    _courseRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Update(Course entity)
        {
            try
            {
                if (entity != null)
                {
                    _courseRepository.Update(entity);
                    _courseRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}