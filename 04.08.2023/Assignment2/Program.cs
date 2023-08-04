/*
double num1, num2;
int result;
Console.WriteLine("Enter Number 1");
num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Number 2");
num2 = Convert.ToDouble(Console.ReadLine());
result = (int)(num1 + num2);
Console.WriteLine("The Result is " + result);

*/
/*int num, sum = 0, num2, rem;
Console.WriteLine("Enter the Number");
num = Convert.ToInt32(Console.ReadLine());
num2 = num;
while (num != 0){
    rem = num % 10;
    sum += (rem * rem * rem);
    num = num / 10;
}
if (sum == num2)
{
    Console.WriteLine("Armstrong Number");
}
else
{
    Console.WriteLine(" Not an Armstrong Number");
}*/

/*
int num, sum = 0;
Console.WriteLine("Enter the Number");
num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= num/2; i++) { 
    if(num % i == 0) {
        sum+=i;
    }
}

if (sum == num)
{
    Console.WriteLine("Perfect Number");
}
else
{
    Console.WriteLine(" Not an Perfect Number");
}
*/

/*
int start,end;
Console.WriteLine("Enter the Starting Number");
start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Ending Number");
end = Convert.ToInt32(Console.ReadLine());
for (int i = start; i <= end; i++)
{
    int count = 0;
    for (int j = 1; j <= i / 2; j++)
    {
        if (i % j == 0)
        {
            count++;
        }
    }
    if (i == 1)
    {
        Console.WriteLine(i);
    }
    if (count == 1)
    {
        Console.WriteLine(i);
    }
}
*/

/*using SimplePrograms;

    int consumerNumber = Convert.ToInt32(Console.ReadLine());
    string? consumerName = Console.ReadLine();
    int curReading = Convert.ToInt32(Console.ReadLine());
    int prevReading = Convert.ToInt32(Console.ReadLine());
    string? consumerType = Console.ReadLine();


ElectricReading electricReading = new(consumerNumber, consumerName, curReading, prevReading, consumerType);


    int billAmt = electricReading.calculateBill();
    Console.WriteLine($"Bill Amount :  "
        + $"{electricReading.ConsumerName} "
        + $"{electricReading.ConsumerNumber} "
        + $"{billAmt}");
*/
/*using SimplePrograms;

Console.WriteLine("Enter the Account Number");
int accountNumber= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Account Holder Number");
string? accountHolderName = Console.ReadLine();
double amount = 0;
int choice = 0;
BankAccount account = new(accountNumber,accountHolderName);
while (choice != 4) {
    Console.WriteLine("Choose the option\n1.Deposit Amount\n2.Withdraw Amount\n3.Display Account Details\n4.Exit");
    choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1) { 
        Console.WriteLine("Enter the amount to be deposit");
        amount = Convert.ToDouble(Console.ReadLine());
        account.depositAmount(amount);
    }
    else if (choice == 2)
    {
        Console.WriteLine("Enter the amount to be withdraw");
        amount = Convert.ToDouble(Console.ReadLine());
        account.withdrawAmount(amount);
    }else if (choice == 3)
    {
        account.displayAccountDetails();
    }else if (choice == 4)
    {
        break;
    }


}
*/
using SimplePrograms;

Book []arr = { new Book(101, "Happy life", "Harsha", true), new Book(102, "Journey", "Sanjay", true), new Book(103, "The Lie", "Parithi", true), new Book(104, "Joyful Work", "Ranga", false) };
Library library = new Library(arr);
int choice = 0;
while (choice != 4)
{
    Console.WriteLine("Choose the option\n1.Borrow Book\n2.Return Book\n3.Display Books\n4.Exit");
    choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        Console.WriteLine("Enter the title of the book to borrow");
        string title = Console.ReadLine();
        library.BorrowBook(title);
    }
    else if (choice == 2)
    {
        Console.WriteLine("Enter the title of the book to return");
        string title = Console.ReadLine();
        library.ReturnBook(title);
    }
    else if (choice == 3)
    {
        library.DisplayBookDetails();
    }
    else if (choice == 4)
    {
        break;
    }


}


















