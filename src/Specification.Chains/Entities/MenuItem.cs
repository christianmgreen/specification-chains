namespace Specification.Chains.Entities
{
    public class MenuItem : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MenuCategoryId { get; set; }
        public MenuCategory Category { get; set; }
    }
}