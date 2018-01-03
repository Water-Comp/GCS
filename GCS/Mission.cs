using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS
{
    class Mision
    {
        bool admin;
        string ServerIP;
        int MissionTime;
        int AtributsNumber;
        string name;
        string IP;
        Command command;
        DB db;
        List<string> Atributs = new List<string>();
        public Mision()
        {

        }
        public int Init(string Name, string ServerIP, bool Admin = false, List<string> atributs = null)
        {
            name = Name;
            admin = Admin;
            MissionTime = 0;
            IP = ServerIP;
            command = new Command(ServerIP, 3456);
            if (DBExist(name))
            {
                return 1;
            }
            else
            {
                if (admin)
                {
                    Atributs = atributs;
                    AtributsNumber = atributs.Count;
                    MissionTime = 0;
                    string sql;
                    db = new DB(name + ".db");

                    foreach (string element in Atributs)
                    {
                        sql = "CREATE TABLE " + element + " (time real, value real)";
                        db.Query(sql);
                    }
                    command.Create(name, Atributs);
                }
                else
                {

                    db = new DB(name + ".db");
                    Atributs = command.GetColumns(name);
                    string sql;
                    foreach (string element in Atributs)
                    {
                        sql = "CREATE TABLE " + element + " (time real, value real)";
                        db.Query(sql);
                    }
                    foreach(string atribut in Atributs) save(command.ReciveUpdate(name, 0), atribut);
                }
                return 0;
            }
        }
        void save(string value, string atribut)
        {
            string[] splited = value.Split(' ');
            List<string> values = new List<string>(splited);
            for(int i = 0; i < values.Count; i += 2)
            {
                string sql = "insert into " + atribut + " values (" + values[i] + ", " + values[i+1] + ")";
                db.Query(sql);
            }
        }
        public void ReciveUpdate()
        {
            string command = "ReciveUpdate " + name + " " + MissionTime.ToString();
            string response = TCP.Connect("127.0.0.1", command, 3456);
            save(response);
        }
        bool DBExist(string Name)
        {
            return !(db.Query("select * from dbstructure where Name = '" + Name + "'") == "");
        }
        public bool SendUpdate()
        {
            int i = 0;
            List<string> tmp = new List<string>();
            if (TXT.ReadOneLine(0, "data.txt") == "FileIsEmpty") return false;
            if (TXT.ReadOneLine(0, "data.txt") == "SomeExeption") return false;
            if (TXT.ReadOneLine(0, "picture.txt") == "FileIsEmpty") return false;
            if (TXT.ReadOneLine(0, "picture.txt") == "SomeExeption") return false;
            else
            {
                while (TXT.ReadOneLine(i, "data.txt") != null)
                {
                    tmp.Add(TXT.ReadOneLine(i, "data.txt"));
                    i++;
                }
                string picture = TXT.ReadOneLine(0, "picture.txt");
                command.SendUpdate(name, tmp, "123");
                TXT.clear();
                return true;
            }
        }
        public bool LastImage()
        {
            string respond = command.ReciveLastImage(name);
            TXT.Overwrite(respond, "picture.txt");
            return true;
        }
        public bool CheckTopicality()
        {
            return true;
        }

    }
}
