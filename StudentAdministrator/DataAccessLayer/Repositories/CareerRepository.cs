using DataAccessLayer.DBConection;
using Microsoft.Data.SqlClient;
using PresentationLayer.Career;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CareerRepository
    {
        private SqldataAccess _dbConection;
        public CareerRepository() { 
            _dbConection = new SqldataAccess();
        }
        public DataTable GetCareers()
        {
            DataTable careerTable = new DataTable();
            using (var conection = _dbConection.GetConection())
            {
                string query = "SELECT * FROM career";
                SqlCommand command = new SqlCommand(query, conection);
                conection.Open();

                SqlDataReader reader = command.ExecuteReader();
                careerTable.Load(reader);
            }

            return careerTable;
        }

        public void AddCareer(Career career)
        {
            using (var conection = _dbConection.GetConection())
            {
                string query = "INSERT INTO career VALUES(@NameCareer, @DescriptionCareer)";
                SqlCommand command = new SqlCommand(query, conection);
                command.Parameters.AddWithValue("@NameCareer", career.nameCareer);
                command.Parameters.AddWithValue("@DescriptionCareer", career.descriptionCareer);
                conection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
