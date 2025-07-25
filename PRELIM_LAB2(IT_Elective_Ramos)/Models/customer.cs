namespace PRELIM_LAB2_IT_Elective_Ramos_.Models
{
    public class customer
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; } // Mr, Ms., Mrs., Sir
        public string Email { get; set; }

        // Read-only property
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}
