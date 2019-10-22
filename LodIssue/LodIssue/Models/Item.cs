using System;

namespace LodIssue.Models
{
    public class Item
    {
        public Item(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
}