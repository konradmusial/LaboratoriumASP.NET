using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class ContactController : Controller
{
    private static Dictionary<int, ContactModel> _contacts = new()
    {
        {
            1, new ContactModel()
            {
                Id = 1,
                FirstName = "Jaroslaw",
                LastName = "Kaczynski",
                Email = "jarekpis@wp.pl",
                PhoneNumber = "123 123 213",
                BirthDate = new DateOnly(year: 1949, month: 6, day:18)

            }
        },
        {
            2, new ContactModel()
            {
                Id = 1,
                FirstName = "Jakub",
                LastName = "Nowak",
                Email = "asghjghjd@ashgjghjd",
                PhoneNumber = "155 153 255",
                BirthDate = new DateOnly(year: 1999, month: 12, day: 13)

            }
        }
    };


    


private static int _currentId = 3;
    
    // Lista kontaktów
    public IActionResult Index()
    {
        return View(_contacts);
    }

    // Zwraca formularz dodania kontaktu
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    // obderanie danych z formularza zapisu kontakt i powrot d listy kntkatow
    [HttpPost]
    public IActionResult Add(ContactModel model)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        // zapisanie danych 
        model.Id = ++_currentId;
        _contacts.Add(model.Id, model);
        return View("Index", _contacts);
    }

    public IActionResult Delete(int id)
    {
        _contacts.Remove(id);
        return View("Index", _contacts);
    }
}