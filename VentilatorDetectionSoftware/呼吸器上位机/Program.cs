using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using ADOX;
using System.Collections;

namespace 呼吸器上位机
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new 登录());
        }
    }
    public static class 数据库参数
    {
        public static string sql_测试记录 = "select*from data1";
        public static string sql_用户管理 = "select*from data2";
        public static string sql_呼吸器管理 = "select*from data3";
        public static OleDbConnection mycon = null;
    }
    public static class 数据库行数
    {
        public static bool 查询 = false;
        public static int row = 0;
    }
    public static class 数据库更新
    {
        public static bool flag_update = false;
        public static int 编辑_Row = 0;
    }

    public static class 扫描参数
    {
        public static bool 主界面 = false;
        public static bool 单个界面 = false;
    }
    public static class 用户
    {
        public static string 初始用户名 = "broer";
        public static string 初始密码 = "123456";
    }
    public static class 当前呼吸器
    {
        public static int ID = 0;
    }
    public static class 呼吸器信息
    {
        public static string 呼吸器型号;
        public static string 呼吸器编号;
        public static string 检测日期;
        public static string 检验员;
        public static string 状况;
        public static string 面罩;
        public static string 压力表;
        public static string 报警器;
        public static string 呼吸阻力;
        public static string 气密性;
        public static string 使用者;
        public static string 使用单位;
        public static string 出厂日期;
        public static string 入库日期;
        public static string 制造商;
        
   
    }
    public static class 耗气量测试
    { 
      public static float Mpa_4;
      public static float Mpa_3;
      public static float Mpa_2;
      public static float Mpa_1;
      public static float Mpa;
    }
    public static class 呼吸器测试串口全局
    {
        public static bool 开启静压测试停止 = false;
    }

    //页面链表，记录开着的页面
    public static class PageList
    {
        public static ArrayList pageList=new ArrayList();
        public static  int  nowPageId=0;
    }


}
