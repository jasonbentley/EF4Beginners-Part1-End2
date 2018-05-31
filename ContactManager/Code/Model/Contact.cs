namespace ContactManager.Code.Model
{
    public class Contact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public bool IsActive { get; set; }
        public string EmailAddress { get; set; }
    }
}