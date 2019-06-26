using System.Collections.Generic;

namespace Specification.Chains.Entities
{
    public class MenuCategory : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<MenuItem> Items { get; set; }
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}