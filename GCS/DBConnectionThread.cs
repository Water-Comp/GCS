using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace GCS
{
    class DBConnectionThread
    {
        string IP;
        string name;
        bool IsAdmin;
        Mision mission = new Mision();
        public DBConnectionThread(string Name, string ip, bool isAdmin)
        {
            IsAdmin = isAdmin;
            name = Name;
            IP = ip;
        }
        public void Run()
        {
            List<string> list = new List<string>();
            list.Add("Temp");
            list.Add("Pressure");
            list.Add("Altitude");
            mission.Init(name, IP, IsAdmin, list);
            if(IsAdmin)
            {
                while(true)
                {
                    mission.SendUpdate();
                    Thread.Sleep(100);
                }
                
            }
            else
            {
                while(true)
                {
                    mission.ReciveUpdate();
                    Thread.Sleep(100);
                }
            }
        }
    }
}
