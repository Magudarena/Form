using System.ComponentModel.DataAnnotations;

namespace Form.Models
{
    public class Dane
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podaj imię")]
        [MinLength(2, ErrorMessage = "Imię musi mieć co najmniej 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Proszę podaj nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi mieć co najmniej 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Proszę podaj adres e-mail")]
        [EmailAddress(ErrorMessage = "Proszę podaj poprawny adres e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podaj hasło")]
        [MinLength(8, ErrorMessage = "Hasło musi mieć co najmniej 8 znaków")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).+$", ErrorMessage = "Hasło musi zawierać co najmniej jedną dużą literę, jedną małą literę i jedną cyfrę")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Proszę potwierdzić hasło")]
        [Compare("Haslo", ErrorMessage = "Hasła muszą być takie same")]
        public string PotwierdzenieHasla { get; set; }

        [Phone(ErrorMessage = "Proszę podaj poprawny numer telefonu")]
        public string NrTelefonu { get; set; }

        [Range(10, 80, ErrorMessage = "Wiek musi być pomiędzy 10 a 80 lat")]
        public int Wiek { get; set; }

        [Required(ErrorMessage = "Proszę wybierz miasto")]
        public string Miasto { get; set; }

        [Required(ErrorMessage = "Prosze podaj Temat")]
        public string Temat { get; set; }
        [Required(ErrorMessage = "Proszę podaj treść wiadomosci")]
        [MinLength(10), MaxLength(50)]
        public string Tresc { get; set; }
        public string Info { get; set; }





    }
}
