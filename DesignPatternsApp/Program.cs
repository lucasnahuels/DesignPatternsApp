using DesignPatternsApp;
using DesignPatternsApp.Builder;
using DesignPatternsApp.Observer;
using DesignPatternsApp.Strategy;

var paymentProcessor = new PaymentProcessor();

// Create users using the Fluent Builder
var user1 = new User.Builder()
    .SetName("John Doe")
    .SetEmail("john.doe@example.com")
    .SetPhoneNumber("123-456-7890")
    .Build();

var user2 = new User.Builder()
    .SetName("Jane Smith")
    .SetEmail("jane.smith@example.com")
    .SetPhoneNumber("987-654-3210")
    .Build();

// Attach observers for the users
paymentProcessor.Attach(new EmailNotifier(user1));
paymentProcessor.Attach(new SmsNotifier(user2));


Console.WriteLine("Choose a payment method: 1. Credit Card  2. PayPal");
var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        paymentProcessor.SetPaymentStrategy(new CreditCardPayment());
        break;
    case "2":
        paymentProcessor.SetPaymentStrategy(new PayPalPayment());
        break;
    default:
        Console.WriteLine("Invalid choice.");
        return;
}

Console.WriteLine("Enter the amount to pay:");
if (decimal.TryParse(Console.ReadLine(), out var amount))
{
    paymentProcessor.ProcessPayment(amount);
}
else
{
    Console.WriteLine("Invalid amount.");
}