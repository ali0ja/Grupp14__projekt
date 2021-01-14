using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Linq;

namespace project
{
    public class History
    {
        public  History historyList;
        private List<string> history;
        public List<string> HistoryList
        {

            get
            {
                if (history == null)
                {
                    if (File.Exists("history.json"))
                    {
                        string jsondata = File.ReadAllText("history.json");
                        history = JsonSerializer.Deserialize<List<string>>(jsondata);
                    }
                    else
                    {
                        history = new List<string>();
                    }
                }
                return history;
            }
            set
            {
                history = value;
            }
        }
        public void AddToHistory(string value)
        {
            HistoryList.Add(value);
            if (history.Count > 10)
            {
                 Console.Clear();
            }
            WriteToFile();
        }
        public void WriteToFile()
        {
            string jsondata = JsonSerializer.Serialize(history);
            File.WriteAllText("history.json", jsondata);
        }
       
        
        


    }
}