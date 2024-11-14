using System;
using System.Collections.Generic;
namespace MyBank
{
    public class DummyData
    {

        public Dictionary<int, List<object>> AdminData    = new Dictionary<int, List<object>>();
        public Dictionary<int, List<object>> EmployeeData = new Dictionary<int, List<object>>();
        public Dictionary<int, List<object>> UsersData    = new Dictionary<int, List<object>>();
        public DummyData(string? Level)
        {
            if (Level == "ADMIN")
            {
                AdminData.Add(1, new List<object> { "Ahmed",    22, "Cairo" });
                AdminData.Add(3, new List<object> { "Ali",      25, "Alex"  });
                AdminData.Add(2, new List<object> { "Mohammed", 32, "Giza"  });
            }
            else if (Level == "EMPLOYEE")
            {
                EmployeeData.Add(1, new List<object> { "Mohammed",    20, "Giza"          });
                EmployeeData.Add(2, new List<object> { "Ahmed",       30, "Aelx"          });
                EmployeeData.Add(3, new List<object> { "Khaled",      25, "Alex"          });
                EmployeeData.Add(4, new List<object> { "Ibrahem",     32, "Tanta"         });
                EmployeeData.Add(5, new List<object> { "Mosaad",      38, "Behera"        });
                EmployeeData.Add(6, new List<object> { "AddElrahman", 32, "BaniSuif"      });
                EmployeeData.Add(7, new List<object> { "Mohammed",    24, "Ismaealia"     });
                EmployeeData.Add(8, new List<object> { "Elsaid",      42, "Cairo"         });
                EmployeeData.Add(9, new List<object> { "Eissa",       39, "Kafr-Elsheikh" });
                EmployeeData.Add(10, new List<object> { "Youssef",    28, "Giza"          });               
            }
            else if(Level =="USERS")
            {
                UsersData.Add(1, new List<object> { "Mohammed",   20, "Giza"         ,20000m});
                UsersData.Add(2, new List<object> { "Ahmed",      30, "Aelx"         ,20000m});
                UsersData.Add(3, new List<object> { "Khaled",     25, "Alex"         ,20000m});
                UsersData.Add(4, new List<object> { "Ibrahem",    32, "Tanta"        ,20000m});
                UsersData.Add(5, new List<object> { "Mosaad",     38, "Behera"       ,20000m});
                UsersData.Add(6, new List<object> { "AddElrahman",32, "BaniSuif"     ,20000m});
                UsersData.Add(7, new List<object> { "Mohammed",   24, "Ismaealia"    ,20000m});
                UsersData.Add(8, new List<object> { "Elsaid",     42, "Cairo"        ,20000m});
                UsersData.Add(9, new List<object> { "Eissa",      39, "Kafr-Elsheikh",20000m});
                UsersData.Add(10,new List<object> { "Youssef" ,   28, "Giza"         ,20000m});
            }
        }
        public DummyData(){}
    };
}
