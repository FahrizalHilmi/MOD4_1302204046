
namespace MOD4_1302204046_AQL
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
           
            Penjumlahan.JumlahTigaAngka<int>(13, 02, 20);
            SimpleDataBase<int> objData1 = new SimpleDataBase<int>();
            objData1.AddNewData(13);
            objData1.AddNewData(02);
            objData1.AddNewData(20);
            objData1.PrintAllData();
        }
    }
}