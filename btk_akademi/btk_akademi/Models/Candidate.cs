using System.ComponentModel.DataAnnotations;

namespace btk_akademi.Models
{
    public class Candidate
    {
        [Required(ErrorMessage ="Email Alanı zorunlu bir alan")]
        public string? Email { get; set; } = string.Empty; //email null deger olabılır dedık ve bos degere de atadık
        [Required (ErrorMessage ="Firtname zorunlu bir alan")]
        public string? FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "LastName zorunlu bir alan")]
        public string? LastName { get; set;} = string.Empty;
      
        public string? FullName=> $"{FirstName} {LastName?.ToUpper()}";
       
        public int? Age { get; set; }
        public string SelectedCourse { get; set; } = string.Empty;// secılen kurs 
        
        public DateTime ApplyAt { get; set; }// hangi tarihte basvurdu 
         

        public Candidate()
        {
            ApplyAt = DateTime.Now;// kayıt oldugu tarihi yoksa şimdi olarak kaydet dedik
            // burada ılgılı yerler ıcın tanımlamalar yaptık yanı verı tabanı gıbı 
        }
    }
    
}
