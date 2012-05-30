using System;
using System.Collections.Generic;

namespace WebAPIpgw.Models
{
    public class Gizmo
    {
        // empty ctor required, otherwise you must use [DataContract], [DataMember]
        public Gizmo() { }      
        public Gizmo(int cnt, int qty)
        {
            Id = cnt;
            Name = "Gizmo " + cnt.ToString();
            Quantity = qty;
            IntroducedDate = DateTime.Now.AddDays(4*cnt);
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime IntroducedDate { get; set; }
        public int Quantity { get; set; }

        // Simulate a call to a back end store such as SQL Server
        public static IEnumerable<Gizmo> GetGizmos()
        {
            var rnd1 = new System.Random();
            for (int i = 1; i < 4; i++)
            {
                yield return new Gizmo(i, rnd1.Next(3, 333));
            }
        }
    }
}