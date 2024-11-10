using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq.Expressions;

namespace ExaminationSystem.Data.Repository
{
    public class InstructorRepository
    {
        Context _context;

        public InstructorRepository()
        {
            _context = new Context();
        }

        public void Add(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
        }

        public void Update(Instructor updatedInstructor)
        {
            //var oldInstructor = _context.Instructors.AsTracking().FirstOrDefault(x => x.ID == updatedInstructor.ID);

            //oldInstructor.Name = updatedInstructor.Name;
            //oldInstructor.Mobile = updatedInstructor.Mobile;

            _context.Instructors.Update(updatedInstructor);
            _context.SaveChanges();
        }

        public IQueryable<Instructor> GetAll()
        {
            return _context.Instructors;
        }

        public IQueryable<Instructor> Get(Expression<Func<Instructor, bool>> predicate)
        {
            return _context.Instructors.Where(predicate);
        }

        public Instructor GetByID(int id)
        {
            return _context.Instructors.FirstOrDefault(x => x.ID == id);
        }

    }
}
