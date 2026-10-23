using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSu.Data
{
    public static class Db
    {
        private static string _resolvedConnectionString = null;

        public static string ConnectionString
        {
            get
            {
                if (!string.IsNullOrEmpty(_resolvedConnectionString))
                    return _resolvedConnectionString;

                var connSetting = ConfigurationManager.ConnectionStrings["QuanLyNhanSuDb"];
                string baseConn = connSetting != null ? connSetting.ConnectionString : null;

                // Thử connection string cấu hình trong App.config trước
                if (!string.IsNullOrWhiteSpace(baseConn))
                {
                    try
                    {
                        using (var testCn = new SqlConnection(baseConn))
                        {
                            testCn.Open();
                            _resolvedConnectionString = baseConn;
                            return _resolvedConnectionString;
                        }
                    }
                    catch { }
                }

                // Nếu không được, tự động dò tìm server instance đang chạy QuanLyNhanSuDB
                string[] serverCandidates = new string[] {
                    ".",
                    "localhost",
                    @"(localdb)\mssqllocaldb",
                    @".\SQLEXPRESS"
                };

                foreach (string srv in serverCandidates)
                {
                    string tryConn = string.Format(@"Data Source={0};Initial Catalog=QuanLyNhanSuDB;Integrated Security=True;Connect Timeout=2", srv);
                    try
                    {
                        using (var testCn = new SqlConnection(tryConn))
                        {
                            testCn.Open();
                            _resolvedConnectionString = string.Format(@"Data Source={0};Initial Catalog=QuanLyNhanSuDB;Integrated Security=True", srv);
                            return _resolvedConnectionString;
                        }
                    }
                    catch { }
                }

                // Fallback mặc định
                _resolvedConnectionString = @"Data Source=.;Initial Catalog=QuanLyNhanSuDB;Integrated Security=True";
                return _resolvedConnectionString;
            }
        }

        public static SqlConnection OpenConnection()
        {
            var cn = new SqlConnection(ConnectionString);
            cn.Open();
            return cn;
        }

        public static DataTable Query(string sql, params SqlParameter[] parameters)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                using (var da = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static int Execute(string sql, params SqlParameter[] parameters)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteNonQuery();
            }
        }

        public static object Scalar(string sql, params SqlParameter[] parameters)
        {
            using (var cn = OpenConnection())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteScalar();
            }
        }

        public static bool TestConnection(out string error)
        {
            error = string.Empty;
            try
            {
                using (var cn = OpenConnection())
                {
                    return cn.State == ConnectionState.Open;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }
    }
}
