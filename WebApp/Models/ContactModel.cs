using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Models;

public class ContactModel
{
    [HiddenInput]
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Musisz wpisac imię!")]
    [MaxLength(length: 20, ErrorMessage = "Imię nie może być dłuższe niż 20 znaków")]
    [MinLength(length: 2, ErrorMessage = "Imię musi miec co najmniej 2 znaki")]
    public string FirstName { get; set; }
    
    [Required(ErrorMessage = "Musisz wpisac nazwisko!")]
    [MaxLength(length: 20, ErrorMessage = "Nazwisko nie może być dłuższe niż 20 znaków")]
    [MinLength(length: 2, ErrorMessage = "Nazwisko musi miec co najmniej 2 znaki")]
    public string LastName { get; set; }
    
    [EmailAddress]
    public string Email { get; set; }
    
    [Phone]
    [RegularExpression(pattern:"\\d{3} \\d{3} \\d{3}", ErrorMessage = "Wpisz numer wedlug wzoru xxx xxx xxx")]
    public string PhoneNumber { get; set; }
    
    [DataType(DataType.Date)]
    public DateOnly BirthDate { get; set; }
}