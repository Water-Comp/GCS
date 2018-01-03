using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS
{
    class TXT
    {
        

        // Read the file and display it line by line.  
         
        public TXT()
        {

        }
        static public string ReadOneLine(int number, string name)
        {
            try
            {
                int counter = 0;
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(name);
                while ((line = file.ReadLine()) != null && counter <= number)
                {
                    counter++;
                }
                file.Close();
                if (counter != number + 1) return "IndexOutOfRange";
                if (counter == 0) return "FileIsEmpty";
                return line;
            }
            catch
            {
                return "SomeExeption";
            }
        }
        public static void Overwrite(string txt, string place)
        {
            System.IO.File.WriteAllText(place, txt);
        }
        public static void clear()
        {
            System.IO.File.WriteAllText(@"data.txt", "");
        }
    }
}
