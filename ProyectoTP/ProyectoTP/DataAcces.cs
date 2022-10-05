using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTP
{
    public class DataAcces
    {
        private SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=E:\VisualStudio\repos\ProyectoTP\ProyectoTP\ProyectoBasedeDatos.mdf;Integrated Security = True");

        public void InsertContact(Contacts contact)
        {
            try
            {
                conn.Open();
                string query = @"
                                 INSERT INTO Contacts (Apellido, Nombre , Legajo)
                                 VALUES (@Apellido, @Nombre, @Legajo)
                                 ";
                SqlParameter apellido = new SqlParameter();
                apellido.ParameterName = "@Apellido";
                apellido.Value = contact.Apellido;
                apellido.DbType = System.Data.DbType.String;

                SqlParameter nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter legajo = new SqlParameter("@Legajo", contact.Legajo);


                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(apellido);
                command.Parameters.Add(nombre);
                command.Parameters.Add(legajo);


                command.ExecuteNonQuery();//devuelve la cantidad de filas afectadas.
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }

        }
        public List<Contacts> GetContacts(string search = null)
        {
            List<Contacts> contacts = new List<Contacts>();
            try
            {
                conn.Open();
                string query = @"SELECT Id, Apellido, Nombre, Legajo
                                    FROM Contacts";
                SqlCommand command = new SqlCommand();

                if (string.IsNullOrEmpty(search))
                {
                    query += @" WHERE Apellido LIKE @Search OR Nombre LIKE @Search OR Legajo LIKE @Search ";
                    command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
                }
                command.CommandText = query;
                command.Connection = conn;
                
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    contacts.Add(new Contacts
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Apellido = reader["Apellido"].ToString(),
                        Nombre = reader["Nombre"].ToString(),
                        Legajo = reader["Legajo"].ToString()
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { conn.Close(); }
            return contacts;
        }
        public void UpdateContacts(Contacts contact) 
        {
            try
            {
                conn.Open();
                string query = @"UPDATE Contacts
                                 SET Apellido = @Apellido, Nombre = @Nombre, Legajo = @Legajo
                                   WHERE Id = @Id";
                SqlParameter id = new SqlParameter("@Id", contact.Id);
                SqlParameter apellido = new SqlParameter("@Apellido", contact.Apellido);
                SqlParameter nombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter legajo = new SqlParameter("@Legajo", contact.Legajo);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(id);
                command.Parameters.Add(apellido);
                command.Parameters.Add(nombre);
                command.Parameters.Add(legajo);

                command.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }
        public void DeleteContacts(int id)
        {
            try
            {
                conn.Open();
                string query = @"DELETE FROM Contacts WHERE Id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(new SqlParameter("@Id", id));
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally { conn.Close(); }
        }
    }
}