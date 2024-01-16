using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Contact
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }

    public Contact(string Name, string Surname, string Phone, string Email)
    {
        this.Name = Name;
        this.Surname = Surname;
        this.Phone = Phone;
        this.Email = Email;
    }

    public override string ToString()
    {
        return this.Name + " " + this.Surname + " " + this.Phone + " " + this.Email;
    }
}
public class Notebook
{
    private List<Contact> Contacts = new List<Contact>();
    public bool Add(string Name, string Surname, string Phone, string Email){
        if (Name.Length == 0 || Surname.Length == 0)
        {
            return false;
        }
        Contacts.Add(new Contact(Name, Surname, Phone, Email));
        return true;
    }

    public List<Contact> Search(Predicate<Contact> predicate)
    {
        return Contacts.FindAll(predicate);
    }

    public List<Contact> AllRecords
    {
        get { return Contacts; }
    }


}
