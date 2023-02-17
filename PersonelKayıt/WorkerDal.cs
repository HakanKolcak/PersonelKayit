using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelKayıt
{
    public class WorkerDal
    {
        readonly SqlConnection _connection = new SqlConnection(@"Server=localhost;Database=PersonelVT;User Id=SA;Password=mssql*2023; connection timeout=30;");
        public List<Worker> GetAll(string tableName)
        {
            ConnectionControl();
            //SqlCommand command = new SqlCommand(cmdText: "SELECT Personel.Id, Personel.Ad, Personel.Soyad, Personel.Cınsıyet, Personel.Durum, Personel.Sehır, Personel.Maas, Personel.TelNo, Personel.Meslek, \r\nAvans.Id AS AvansId, Avans.PersonelId, Avans.AvansTarıhı, Avans.AvansMıktarı, \r\n   Avans.KalanTutar\r\nFROM     Personel INNER JOIN\r\n     Avans ON Personel.Id = Avans.PersonelId", _connection);
            SqlCommand command = new SqlCommand(cmdText: "SELECT * from '"+ tableName +"'", _connection);
            SqlDataReader reader = command.ExecuteReader();
            
            List<Worker> workers = new List<Worker>();

            while (reader.Read())
            {
                Worker worker = new Worker
                {
                    Id = Convert.ToInt16(reader["Id"]),
                    Ad = reader["Ad"].ToString(),
                    Soyad = reader["Soyad"].ToString(),
                    Cınsıyet = reader["Cınsıyet"].ToString(),
                    Durum = reader["Durum"].ToString(),
                    Sehır = reader["Sehır"].ToString(),
                    Maas = Convert.ToDecimal(reader["Maas"]),
                    TelNo = reader["TelNo"].ToString(),
                    Meslek = reader["Meslek"].ToString()
                };
                worker._avans.Id = Convert.ToInt16(reader["Id"]);
                workers.Add(worker);
            }
            List<Avans> avanss = new List<Avans>();

            while (reader.Read())
            {
                Avans avans = new Avans
                {
                    Id = Convert.ToInt16(reader["Id"]),
                    PersonelId = Convert.ToInt16(reader["PersonelId"]),
                    AvansTarıhı = Convert.ToDateTime(reader["AvansTarıhı"]),
                    AvansMıktarı = Convert.ToDecimal(reader["AvansMıktarı"]),
                    KalanTutar = Convert.ToDecimal(reader["KalanTutar"])
                };
                avanss.Add(avans);
            }
            reader.Close();
            _connection.Close();
            return workers;
        }
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public DataTable GetAll2()
        {
            SqlConnection connection = new SqlConnection(@"Server=localhost;Database=PersonelVT;User Id=SA;Password=mssql*2023; connection timeout=30;");

            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Personel", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }
        public void Add(Worker worker)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Personel values(@Ad,@Soyad,@Cınsıyet,@Durum,@Sehır,@Maas,@TelNo,@Meslek)", _connection);
            command.Parameters.AddWithValue("@Ad", worker.Ad);
            command.Parameters.AddWithValue("@Soyad", worker.Soyad);
            command.Parameters.AddWithValue("@Cınsıyet", worker.Cınsıyet);
            command.Parameters.AddWithValue("@Durum", worker.Durum);
            command.Parameters.AddWithValue("@Sehır", worker.Sehır);
            command.Parameters.AddWithValue("@Maas", worker.Maas);
            command.Parameters.AddWithValue("@TelNo", worker.TelNo);
            command.Parameters.AddWithValue("@Meslek", worker.Meslek);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Update(Worker worker)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Personel set Ad=@Ad, Soyad=@Soyad, Cınsıyet=@Cınsıyet, Durum=@Durum, Sehır=@Sehır, Maas=@Maas, TelNo=@TelNo, Meslek=@Meslek where Id=@id", _connection);
            command.Parameters.AddWithValue("@Ad", worker.Ad);
            command.Parameters.AddWithValue("@Soyad", worker.Soyad);
            command.Parameters.AddWithValue("@Cınsıyet", worker.Cınsıyet);
            command.Parameters.AddWithValue("@Durum", worker.Durum);
            command.Parameters.AddWithValue("@Sehır", worker.Sehır);
            command.Parameters.AddWithValue("@Maas", worker.Maas);
            command.Parameters.AddWithValue("@TelNo", worker.TelNo);
            command.Parameters.AddWithValue("@Meslek", worker.Meslek);
            command.Parameters.AddWithValue("id", worker.Id);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Personel where Id=@id", _connection);
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Avans(Avans avans)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Personel values(@AvansTarıhı, @AvansMıktarı, @KalanTutar, @PersonelId)", _connection);
            command.Parameters.AddWithValue("@PersonelId", avans.PersonelId);
            command.Parameters.AddWithValue("@AvansTarıhı", avans.AvansTarıhı);
            command.Parameters.AddWithValue("@AvansMıktarı", avans.AvansMıktarı);
            command.Parameters.AddWithValue("@KalanTutar", avans.KalanTutar);
            command.ExecuteNonQuery();

            _connection.Close();
        }
    }
}
