using Api_CRUD_GestionTareas.Models;
using Microsoft.Data.SqlClient;

namespace Api_CRUD_GestionTareas.Data
{
    public class TasksData
    {
        public List<TasksModel> TasksList()
        {
            List<TasksModel> olist = new List<TasksModel>();
            using (SqlConnection oConnection = new Connection().getConnection)
            {
                SqlCommand cmd = new SqlCommand("Get_Task", oConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    oConnection.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while(sdr.Read())
                        {
                            olist.Add(new TasksModel()
                            {
                                taskId = Convert.ToInt32(sdr["TaskID"]),
                                taskCode = sdr["Code"].ToString(),
                                taskTitulo = sdr["Tittle"].ToString(),
                                StatusName = sdr["StatusName"].ToString(),
                                EndDate = DateTime.Parse(sdr["EndDate"].ToString()),
                                taskCategory = sdr["CategoryName"].ToString(),
                                taskDescription = sdr["Description"].ToString() 
                            });                            
                        }
                    }
                    return olist;
                }
                catch (Exception ex) 
                {
                    throw new Exception("error", ex);
                }

            }
        }

        public string CreateNewTask(TasksModel task)
        {
            string msj = "";

            using (SqlConnection oConnection = new Connection().getConnection)
            {
                try 
                {
                    oConnection.Open();
                    SqlCommand cmd = new SqlCommand("Create_Task", oConnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Code", task.taskCode));
                    cmd.Parameters.Add(new SqlParameter("@Tittle", task.taskTitulo));
                    cmd.Parameters.Add(new SqlParameter("@StatusName", task.StatusName));
                    cmd.Parameters.Add(new SqlParameter("@CategoryName", task.taskCategory));
                    cmd.Parameters.Add(new SqlParameter("@EndDate", task.EndDate));
                    cmd.Parameters.Add(new SqlParameter("@Description", task.taskDescription));
                    cmd.ExecuteNonQuery();
                    msj = "Registro exitoso!";
                }
                catch(Exception ex)
                {
                    msj = ex.Message;
                }
                finally { oConnection.Close(); }
            }
            return msj;
        }

        public string UpdateTask(TasksModel task)
        {
            string msj = "";

            using (SqlConnection oConnection = new Connection().getConnection)
            {
                try
                {
                    oConnection.Open();
                    SqlCommand cmd = new SqlCommand("Edit_Task", oConnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Code", task.taskCode));
                    cmd.Parameters.Add(new SqlParameter("@Tittle", task.taskTitulo));
                    cmd.Parameters.Add(new SqlParameter("@StatusName", task.StatusName));
                    cmd.Parameters.Add(new SqlParameter("@CategoryName", task.taskCategory));
                    cmd.Parameters.Add(new SqlParameter("@EndDate", task.EndDate));
                    cmd.Parameters.Add(new SqlParameter("@Description", task.taskDescription));
                    cmd.ExecuteNonQuery();
                    msj = "Registro Actualizado exitosamente!";
                }
                catch (Exception ex)
                {
                    msj = ex.Message;
                }
                finally { oConnection.Close(); }
            }
            return msj;
        }

        public string DeleteTask(string codeTask)
        {
            string msj = "";

            using (SqlConnection oConnection = new Connection().getConnection)
            {
                try
                {
                    oConnection.Open();
                    SqlCommand cmd = new SqlCommand("Delete_Task", oConnection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Code", codeTask));
                    cmd.ExecuteNonQuery();
                    msj = "Registro Eliminado";
                }
                catch (Exception ex)
                {
                    msj = ex.Message;
                }
                finally { oConnection.Close(); }
            }
            return msj;
        }

        public List<TasksModel> TasksListCategory(string categoryName)
        {
            List<TasksModel> olist = new List<TasksModel>();
            using (SqlConnection oConnection = new Connection().getConnection)
            {

                SqlCommand cmd = new SqlCommand("Get_TaskCategory", oConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CategoryName", categoryName));
                try
                {
                    oConnection.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            olist.Add(new TasksModel()
                            {
                                taskId = Convert.ToInt32(sdr["TaskID"]),
                                taskCode = sdr["Code"].ToString(),
                                taskTitulo = sdr["Tittle"].ToString(),
                                StatusName = sdr["StatusName"].ToString(),
                                EndDate = DateTime.Parse(sdr["EndDate"].ToString()),
                                taskCategory = sdr["CategoryName"].ToString(),
                                taskDescription = sdr["Description"].ToString()
                            });
                        }
                    }
                    return olist;
                }
                catch (Exception ex)
                {
                    throw new Exception("error", ex);
                }

            }
        }
    }
}
