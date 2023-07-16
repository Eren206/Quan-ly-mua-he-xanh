using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace QLMHX
{
    internal static class Program
    {
        public static SqlConnection conn = new SqlConnection();

        public static String connstr;
        public static SqlDataAdapter da;
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String servernameTest = "";
        public static String RemoteLoginName = "HTKN";
        public static String RemotePassword = "123";
        public static String usernameDN;
        public static String passwordDN;
        public static String password;
        public static String database = "MUAHEXANH";
        public static String mlogin;
        public static String mGroup;
        public static String mHoten;
        public static String chiNhanh;
        public static String magv;
        public static String khoa;
        public static String nhom = string.Empty;
        public static BindingSource bindingSource = new BindingSource();
        public static String connstrPublisher = "Data Source=Hajku206;Initial Catalog=DMHCQG;Integrated Security=true";
        public static List<String> dsChiNhanh = new List<string>();
        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static int KetNoiTest()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servernameTest + ";Initial Catalog=" + Program.database + ";User ID=" +
                      "htkn" + ";password=" + "123";
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Không tồn tại CSDL MUAHEXANH trên servername đã nhập, Vui lòng kiểm tra lại !" , "", MessageBoxButtons.OK);
                return 0;
            }
        }
        // đọc dữ liệu (tương tự select)
        public static SqlDataReader ExecSqlDataReader(String cmd, String connectionstring)
        {
            SqlDataReader myreader;
            //Program.conn = new SqlConnection(connectionstring);
            
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = Program.conn;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlQuery(String cmd, String connectionstring)
        {
            DataTable dt1 = new DataTable();
            conn = new SqlConnection(connectionstring);
            da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt1);
            return dt1;

        }


        public static int ExecSqlNonQuery(String cmd, String connectionstring)
        {
            conn = new SqlConnection(connectionstring);
            SqlCommand Sqlcmd = new SqlCommand();
            Sqlcmd.Connection = conn;
            Sqlcmd.CommandText = cmd;
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 300;
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {

                Sqlcmd.ExecuteNonQuery(); conn.Close(); return 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return ex.ErrorCode;
            }
        }


        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists("UserGuideShown")) 
            {
                Application.Run(new UserGuide());
                File.Create("UserGuideShown");
                
            }
            else {
                String storedServerName = File.ReadAllText(Application.UserAppDataPath + "\\" + "MHXServerName.txt");
                Program.servername = storedServerName;
                Application.Run(new Login());

            }     
        }
    }
}

