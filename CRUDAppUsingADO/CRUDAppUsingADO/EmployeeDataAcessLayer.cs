﻿using Microsoft.Data.SqlClient;
using CRUDAppUsingADO.Models;
using System.Data;

namespace CRUDAppUsingADO
{
    public class EmployeeDataAcessLayer
    {
        string cs = ConnectionString.dbcs;

        public List<Employees> getAllEmployees()
        {
            List<Employees> empList = new List<Employees>();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetAllEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Employees emp = new Employees();
                    emp.Id = Convert.ToInt32(reader["id"]);
                    emp.Name = reader["name"].ToString() ?? "";
                    emp.Gender = reader["gender"].ToString() ?? "";
                    emp.Age = Convert.ToInt32(reader["age"]);
                    emp.Designation = reader["designation"].ToString() ?? "";
                    emp.City = reader["city"].ToString() ?? "";
                    empList.Add(emp);
                }
            }
            return empList;
        }

        public Employees getEmployeeById(int? id)
        {
            Employees emp = new Employees();
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("select * from Employees where id = @Id", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    emp.Id = Convert.ToInt32(reader["id"]);
                    emp.Name = reader["name"].ToString() ?? "";
                    emp.Gender = reader["gender"].ToString() ?? "";
                    emp.Age = Convert.ToInt32(reader["age"]);
                    emp.Designation = reader["designation"].ToString() ?? "";
                    emp.City = reader["city"].ToString() ?? "";
                }
            }
            return emp;
        }

        public void AddEmployee(Employees emp)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spAddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", emp.Name);
                cmd.Parameters.AddWithValue("@gender", emp.Gender);
                cmd.Parameters.AddWithValue("@age", emp.Age);
                cmd.Parameters.AddWithValue("@designation", emp.Designation);
                cmd.Parameters.AddWithValue("@city", emp.City);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }


        public void UpdateEmployee(Employees emp)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spUpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", emp.Id);
                cmd.Parameters.AddWithValue("@name", emp.Name);
                cmd.Parameters.AddWithValue("@gender", emp.Gender);
                cmd.Parameters.AddWithValue("@age", emp.Age);
                cmd.Parameters.AddWithValue("@designation", emp.Designation);
                cmd.Parameters.AddWithValue("@city", emp.City);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(int id)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spDeleteEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
