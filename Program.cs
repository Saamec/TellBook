using TellBook;

var phoneBook = new List<Contact>();

// добавляем контакты
phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

var sortedBook = phoneBook.OrderBy(n => n.Name).ThenBy(n => n.LastName);



while (true)
{
    int value = 0;
    try
    {
        value = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
        Console.Clear();
    }
    catch (Exception ex) { Console.WriteLine("Введено не число"); }
    
    if (value == 0) break;
    var pageContent = sortedBook.Skip((value -1) * 2).Take(2);
    Console.WriteLine();
    foreach (var entry in pageContent)
    Console.WriteLine(entry.Name + " " + entry.LastName + ": " + entry.PhoneNumber);

    

}