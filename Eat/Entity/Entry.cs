using System;

namespace Eat.Entity
{
    public class Entry
    {
        public int? EntryId { get; set; }
        public int DayId { get; set; }
        public virtual Day Day { get; set; }
        public int FoodId { get; set; }
        public virtual Food Food { get; set; }
    }
}