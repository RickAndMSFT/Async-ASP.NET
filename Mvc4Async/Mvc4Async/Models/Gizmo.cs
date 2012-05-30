using System;
using System.ComponentModel.DataAnnotations;

namespace Mvc4Async.Models
{
    public class Gizmo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime IntroducedDate { get; set; }
        public int Quantity { get; set; }
    }
}