using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            List<Contact> FoundRecords;
            Predicate<Contact> predicate;
            string SearchStr;
            Console.WriteLine("Записная книжка");
            while (true)
            {
                Console.WriteLine("Введите номер операции и нажмите Enter:");
                Console.WriteLine("1. Просмотр всех контактов");
                Console.WriteLine("2. Поиск контактов");
                Console.WriteLine("3. Новый контакт");
                Console.WriteLine("4. Выход");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "1":
                        FoundRecords = notebook.AllRecords;
                        foreach (var contact in FoundRecords)
                        {
                            Console.WriteLine(contact.ToString());
                        }
                        break;
                    case "2":
                        Console.WriteLine("Поиск по:");
                        Console.WriteLine("1. имени");
                        Console.WriteLine("2. фамилии");
                        Console.WriteLine("3. имени и фамилии");
                        Console.WriteLine("4. телефону");
                        Console.WriteLine("5. e-mail");
                        string choose = Console.ReadLine();
                        switch (choose)
                        {
                            case "1":
                                SearchStr = Console.ReadLine();
                                predicate = contact => contact.Name.Contains(SearchStr);
                                FoundRecords = notebook.Search(predicate);
                                if (FoundRecords.Count>0)
                                {
                                    foreach (var book in FoundRecords)
                                    {
                                        Console.WriteLine(book.ToString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Контакты не найдены!");
                                }
                                break;
                            case "2":
                                SearchStr = Console.ReadLine();
                                predicate = contact => contact.Surname.Contains(SearchStr);
                                FoundRecords = notebook.Search(predicate);
                                if (FoundRecords.Count > 0)
                                {
                                    foreach (var book in FoundRecords)
                                    {
                                        Console.WriteLine(book.ToString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Контакты не найдены!");
                                }
                                break;
                            case "3":
                                SearchStr = Console.ReadLine();
                                predicate = contact => contact.Name.Contains(SearchStr) || contact.Surname.Contains(SearchStr);
                                FoundRecords = notebook.Search(predicate);
                                if (FoundRecords.Count > 0)
                                {
                                    foreach (var book in FoundRecords)
                                    {
                                        Console.WriteLine(book.ToString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Контакты не найдены!");
                                }
                                break;
                            case "4":
                                SearchStr = Console.ReadLine();
                                predicate = contact => contact.Phone.Contains(SearchStr);
                                FoundRecords = notebook.Search(predicate);
                                if (FoundRecords.Count > 0)
                                {
                                    foreach (var book in FoundRecords)
                                    {
                                        Console.WriteLine(book.ToString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Контакты не найдены!");
                                }
                                break;
                            case "5":
                                SearchStr = Console.ReadLine();
                                predicate = contact => contact.Email.Contains(SearchStr);
                                FoundRecords = notebook.Search(predicate);
                                if (FoundRecords.Count > 0)
                                {
                                    foreach (var book in FoundRecords)
                                    {
                                        Console.WriteLine(book.ToString());
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Контакты не найдены!");
                                }
                                break;
                        }

                        break;
                    case "3":
                        Console.WriteLine("Введите имя:");
                        string Name = Console.ReadLine();
                        Console.WriteLine("Введите фамилия:");
                        string Surname = Console.ReadLine();
                        Console.WriteLine("Введите номер телефона:");
                        string Phone = Console.ReadLine();
                        Console.WriteLine("Введите e-mail:");
                        string Email = Console.ReadLine();
                        if (notebook.Add(Name, Surname, Phone, Email))
                        {
                            Console.WriteLine("Контакт добавлен");
                        }

                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный номер операции");
                        break;
                }
            }

            }
        }
}
