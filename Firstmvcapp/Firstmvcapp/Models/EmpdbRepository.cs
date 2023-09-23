using Microsoft.Data.SqlClient;
using System.Data;

namespace Firstmvcapp.Models
{
    public class EmpdbRepository
    {
        public static List<Emptable> GetEmpList()
        {
            //proper method with no objects
            //when an class implements interface nd it dont have to have all the methods then we can have null implementation.
            //ie method is there but no logic 
            List < Emptable > emplist =new List<Emptable>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }


                SqlCommand selectempcmd = cn.CreateCommand();
                String selectAllEmps = "select * from emptbl";
                selectempcmd.CommandText = selectAllEmps; //query assigned
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    Emptable emp = new Emptable
                    {
                        eno = empdr.GetInt32(0),
                        name = empdr.GetString(1),
                        salary = empdr.GetDecimal(2),
                        city = empdr.GetString(3)
                    };
                    emplist.Add(emp);
                }
            }
    return emplist;
        }
        public static Emptable GetEmpbyId(int id) 
        {
            Emptable empFound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectempcmd = cn.CreateCommand();
                String selectAllEmps = "select * from emptbl where eno=@id"; //@id runtime we can pass the value
                //query can have more than one parameter
                selectempcmd.Parameters.Add("@id",SqlDbType.Int).Value = id;
                selectempcmd.CommandText = selectAllEmps;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {
                    empFound = new Emptable
                    {
                        eno = empdr.GetInt32(0),
                        name = empdr.GetString(1),
                        salary = empdr.GetDecimal(2),
                        city = empdr.GetString(3)
                    };
                }
            }
                    return empFound;
        }
        public static int AddNewEmp(Emptable newEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertEmpcmd = cn.CreateCommand();
                String insertNewEmpQuery = "insert into emptbl values( @id,@name,@salary,@city )";
                insertEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = newEmp.eno; //id doesnt need to same with table column
                insertEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = newEmp.name;
                insertEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = newEmp.salary;
                insertEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = newEmp.city;
                
                insertEmpcmd.CommandText = insertNewEmpQuery;
                query_result = insertEmpcmd.ExecuteNonQuery(); //not executing . tells how many records got inserted
            }
            return query_result;
           
        }
        public static int UpdateEmp(Emptable modifiedEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateEmpcmd = cn.CreateCommand();
                String updateEmpQuery = "Update emptbl set name=@name, salary=@salary, city=@city where eno=@id";
                updateEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = modifiedEmp.eno;
                updateEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = modifiedEmp.name;

                updateEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = modifiedEmp.salary;
                updateEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = modifiedEmp.city;
                updateEmpcmd.CommandText = updateEmpQuery;
                query_result = updateEmpcmd.ExecuteNonQuery();
            }
            return query_result;

         
        }
        public static int DeleteEmp(int id) 
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteEmpcmd = cn.CreateCommand();
                String deleteEmpQuery = "Delete from emptbl where eno=@id";
                deleteEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteEmpcmd.CommandText = deleteEmpQuery;
                query_result = deleteEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }
    }
}
