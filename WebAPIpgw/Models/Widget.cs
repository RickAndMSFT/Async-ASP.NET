using System.Collections.Generic;

namespace WebAPIpgw.Models
{
    public class Widget
    {
        public Widget() { }    // empty ctor requried for no   [DataContract], [DataMember]
        public Widget(int cnt)
        {
            Id = cnt;
            Name = "Widget " + cnt.ToString();
            Price = .88M + cnt;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Simulate a call to a back end store such as SQL Server
        public static IEnumerable<Widget> GetWidgets()
        {
            for (int i = 1; i < 3; i++)
            {
                yield return new Widget(i);
            }
        }
    }
}