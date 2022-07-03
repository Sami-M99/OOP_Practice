using System;
using System.IO;


namespace Trying
{

    class Program
    {
        public static void Main()
        {

            Write_Read_File();

        }


        private static void Write_Read_File()
        {
            // Write & Read FILE

            // تحديد المكان واسم الملف الذي راح نكتب فيه
            StreamWriter xw = new StreamWriter("D:\\aa.txt");
            // نكتب الرسالة الذي نريدها 
            xw.Write("Hello Sami \n You are the boss \n 99");
            // نغلق الملف 
            xw.Close();

            // تحديد الملف الذي راح نقرأ منه
            StreamReader xr = new StreamReader("D:\\aa.txt");
            // عمل لوب لكل سطر في الملف ونطبعة
            string s;
            do
            {
                s = xr.ReadLine();
                Console.WriteLine(s);


            } while (s != null);


        }

        private static void Try_catch()
        {
            try
            {
                Console.WriteLine(9999999);
                int x = 55;
                Console.WriteLine(x / 0);
            }
            catch (Exception b)
            {
                Console.WriteLine(b.Message);
            }
            finally
            {
                Console.WriteLine(9999999);
            }

        }

        /* This methods for classes */ 
        private static void get_set_Method()
        {
            // this class for Abstract & get set in properety
            var n = new Empolyee();
            n.all();
            n.who("sami");
        }

        private static void Email_Password_Method()
        {

            Console.Write("Enter your full name :  ");
            string name = Console.ReadLine();
            Console.Write("Enter your Email :  ");
            string email = Console.ReadLine();

            var account = new Customer(name, email);
            account.CreatPassword();

        }

        private static void Files_and_Folders_Method()
        {
            // // Files_and_Folders
            // Creat Folder and Many Folders
            var folder = new Files_and_Folders();
            folder.CreatFolder("first Folder");  // We can write the path also like this "D:\\first Folder"
            folder.CreatFolders(new string[] { "1.Folder", "2.Folder" });

            // Creat File
            var file = new Files_and_Folders();
            file.CreatFile("First File.txt");

            // Creat File and write data lines inside it 
            var fileData = new Files_and_Folders();
            fileData.CreatDataFile("New Data File.txt", new string[] { "Hello", "How are you", "Thanks" });

            // Creat Many Files and write data lines inside it 
            string[] fileNames = new string[] { "1.file.txt", "2.file.txt", "3.file.txt" };
            string[] line1 = new string[] { "Hello 1 ", "1. line  Tahnks" };
            string[] line2 = new string[] { "Hello 2 ", "2. line  Tahnks" };
            string[] line3 = new string[] { "Hello 3 ", "3. line  Tahnks" };
            var filesdata = new Files_and_Folders();
            filesdata.CreatDatasFiles(fileNames, new string[][] { line1, line2, line3 });
            Console.WriteLine(filesdata.GetType().Name);


        }

        private static void Numbers_Method()
        {
            // Numbers
            var c = new Numbers();
            Console.WriteLine(c.Sum(5, 8, 2, 4));

            int[] Array1 = new int[] { 1, 2, 3, 4, 5 };
            int[] Array2 = new int[] { 6, 7, 8, 9, 10 };
            var CArray = new Numbers();
            CArray.CalculateArrays(Array1, '+', Array2);


        }
    }


}
