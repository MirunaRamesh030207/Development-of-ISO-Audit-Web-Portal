using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
namespace PROJECT_CVRDE_FINAL.Models
{   
    public class Complaint 
    {        
        public int ComplaintID { get; set; }
        public int EmployeeID { get; set; }
        public int DepartmentID { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentName { get; set; }
        public string ComplaintDescription { get; set; }
        public DateTime RaisedDate { get; set; }
        public DateTime ExpectedResolutionDate { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public string ComplaintType { get; set; }
        private MySqlConnection OpenConnection()
        {
            MySqlConnection conn = DBHelper.GetConnection();
            conn.Open();
            return conn;
        }
        private Complaint MapRowToComplaint(MySqlDataReader dr)
        {
            Complaint c = new Complaint();

            c.ComplaintID = Convert.ToInt32(dr["ComplaintID"]);
            c.EmployeeID = Convert.ToInt32(dr["EmployeeID"]);
            c.DepartmentID = Convert.ToInt32(dr["DepartmentID"]);
            c.EmployeeName = dr["EmployeeName"].ToString();
            c.DepartmentName = dr["DepartmentName"].ToString();
            c.ComplaintDescription = dr["ComplaintDescription"].ToString();
            c.RaisedDate = Convert.ToDateTime(dr["RaisedDate"]);
            c.ExpectedResolutionDate = Convert.ToDateTime(dr["ExpectedResolutionDate"]);
            c.Status = dr["Status"].ToString();
            c.Priority = dr["Priority"].ToString();
            c.ComplaintType = dr["ComplaintType"].ToString();

            return c;
        }
        public List<Complaint> GetAllComplaints()
        {
            List<Complaint> list = new List<Complaint>();

            MySqlConnection conn = OpenConnection();

            string query = @"SELECT
complaints.*,
employees.EmployeeName,
departments.DepartmentName
FROM complaints
INNER JOIN employees
ON complaints.EmployeeID = employees.EmployeeID
INNER JOIN departments
ON complaints.DepartmentID = departments.DepartmentID";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Complaint c = MapRowToComplaint(dr);
                list.Add(c);
            }
            conn.Close();

            return list;
        }
        public Complaint GetComplaintById(int id)
        {
            Complaint c = new Complaint();

            MySqlConnection conn = OpenConnection();

            string query = @"SELECT
complaints.*,
employees.EmployeeName,
departments.DepartmentName
FROM complaints
INNER JOIN employees
ON complaints.EmployeeID = employees.EmployeeID
INNER JOIN departments
ON complaints.DepartmentID = departments.DepartmentID
WHERE complaints.ComplaintID=" + id;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                c = MapRowToComplaint(dr);
            }
            conn.Close();
            return c;
        }
        public void InsertComplaint()
        {
            MySqlConnection conn = OpenConnection();

            string query = "INSERT INTO complaints(EmployeeID,DepartmentID,ComplaintDescription,ComplaintType,RaisedDate,ExpectedResolutionDate,Status,Priority) VALUES("
                + EmployeeID + ","
                + DepartmentID + ","
                + "'" + ComplaintDescription + "',"
                + "'" + ComplaintType + "',"
                + "'" + RaisedDate.ToString("yyyy-MM-dd") + "',"
                + "'" + ExpectedResolutionDate.ToString("yyyy-MM-dd") + "',"
                + "'" + Status + "',"
                + "'" + Priority + "')";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void UpdateComplaint()
        {
            MySqlConnection conn = OpenConnection();

            string query = "UPDATE complaints SET "
                + "EmployeeID=" + EmployeeID + ","
                + "DepartmentID=" + DepartmentID + ","
                + "ComplaintDescription='" + ComplaintDescription + "',"
                + "ComplaintType='" + ComplaintType + "',"
                + "RaisedDate='" + RaisedDate.ToString("yyyy-MM-dd") + "',"
                + "ExpectedResolutionDate='" + ExpectedResolutionDate.ToString("yyyy-MM-dd") + "',"
                + "Status='" + Status + "',"
                + "Priority='" + Priority + "' "
                + "WHERE ComplaintID=" + ComplaintID;

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public void DeleteComplaint()
        {
            MySqlConnection conn = OpenConnection();

            string query = "DELETE FROM complaints WHERE ComplaintID=" + ComplaintID;

            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
        public List<Complaint> SearchComplaint(string search)
        {
            List<Complaint> list = new List<Complaint>();

            MySqlConnection conn = OpenConnection();

            string query = "SELECT complaints.*, employees.EmployeeName, departments.DepartmentName " +
               "FROM complaints " +
               "INNER JOIN employees ON complaints.EmployeeID = employees.EmployeeID " +
               "INNER JOIN departments ON complaints.DepartmentID = departments.DepartmentID " +
               "WHERE employees.EmployeeName LIKE '%" + search +
               "%' OR departments.DepartmentName LIKE '%" + search +
               "%' OR complaints.ComplaintDescription LIKE '%" + search +
               "%' OR complaints.ComplaintType LIKE '%" + search + "%'";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Complaint c = MapRowToComplaint(dr);
                list.Add(c);
            }

            conn.Close();

            return list;
        }
        public List<Complaint> FilterComplaint(string status)
        {
            List<Complaint> list = new List<Complaint>();

            MySqlConnection conn = OpenConnection();

            string query = @"SELECT
complaints.*,
employees.EmployeeName,
departments.DepartmentName
FROM complaints
INNER JOIN employees
ON complaints.EmployeeID = employees.EmployeeID
INNER JOIN departments
ON complaints.DepartmentID = departments.DepartmentID
WHERE complaints.Status='" + status + "'";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Complaint c = MapRowToComplaint(dr);
                list.Add(c);
            }

            conn.Close();

            return list;
        }
        public List<Complaint> FilterComplaintByType(string type)
        {
            List<Complaint> list = new List<Complaint>();

            MySqlConnection conn = OpenConnection();

            string query = @"SELECT
complaints.*,
employees.EmployeeName,
departments.DepartmentName
FROM complaints
INNER JOIN employees
ON complaints.EmployeeID = employees.EmployeeID
INNER JOIN departments
ON complaints.DepartmentID = departments.DepartmentID
WHERE complaints.ComplaintType='" + type + "'";

            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Complaint c = MapRowToComplaint(dr);
                list.Add(c);
            }

            conn.Close();

            return list;
        }
        public int GetCount(string query)
        {
            MySqlConnection conn = OpenConnection();

            MySqlCommand cmd = new MySqlCommand(query, conn);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count;
        }
    }
}