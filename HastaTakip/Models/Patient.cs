namespace HastaTakip.Models
{
    public class Patient : BaseModel
    {
        public int OwnerId { get; set; } // Foreign Key, nullable
        public string PatientName { get; set; } // TEXT
        public string PatientGender { get; set; } // TEXT
        public string RegistrationDate { get; set; } // DATETIME
        public string PatientNote { get; set; } // TEXT
    }
}
