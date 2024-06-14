using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS.Models
{
    public class Equipment
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Count { get; set; }
        public DateTime EntryDate { get; set; }

        public static List<Equipment> ListEquipment()
        {
            var list = new List<Equipment>();
            Random random = new Random();

            Equipment equipment;
            for (int i = 0; i < 30; i++)
            {
                equipment = new Equipment();
                equipment.Id=i.ToString();
                equipment.Name = "Item"+i.ToString();
                equipment.Count = random.Next(100).ToString();
                equipment.EntryDate = DateTime.Now;
                list.Add(equipment);
            }
            
            return list;
        }


    }
}