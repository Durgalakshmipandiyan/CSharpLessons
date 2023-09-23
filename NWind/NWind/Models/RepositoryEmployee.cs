namespace NWind.Models
{
    public class RepositoryEmployee
    {//for dependency injection static is an issue so constructor is enough 
        private NorthwindContext _context;
        public RepositoryEmployee(NorthwindContext context)
        {
            _context = context;
        }
        public  List<Employee> AllEmployee()
        { 
        
            return _context.Employees.ToList();
            
        }
    }
}
