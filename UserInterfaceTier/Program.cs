using ApplicationTier.Classes;

Console.WriteLine("Please enter your customer firstname?");

string firstname = Console.ReadLine();

Console.WriteLine("Please enter your customer lastname?");

string lastname = Console.ReadLine();

DateTime? dateOfBirth = DateTime.Now.AddYears(-20);


var customerMethods = new CustomerMethods();


var customer = await customerMethods.AddCustomer(firstname, lastname, dateOfBirth);


Console.WriteLine($"Your customer has been added. Customer name is {customer.FullName}, Id is {customer.Id}");

