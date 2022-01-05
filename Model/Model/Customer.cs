

namespace Model.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string WAPhonenumber { get; set; }
        public CollaborationType collaborationType { get; set; }
        public ApplicationUser applicationUser { get; set; }
        public string Description { get; set; }

        public int applicationUserId { get; set; }
    }
}
