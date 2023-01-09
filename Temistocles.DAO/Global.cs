namespace Temistocles.DAO {
    internal class Global {
        public static string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string database = "temistocles.db";
        public static string pathDatabase = path + @"\db\" + database;
    }
}
