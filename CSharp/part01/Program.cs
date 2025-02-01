// A literal value is literally a hard-coded value that never changes.

Console.WriteLine("a");     // string literal
Console.WriteLine('a');     // character literal
Console.WriteLine(100_000); // integer literal
Console.WriteLine(100_000); // floating-point literal (float, 32 bits)
Console.WriteLine(100_000); // floating-point literal (double, 64 bits)
Console.WriteLine(100_000); // floating-point literal (decimal, 128 bits)
Console.WriteLine(false);   // boolean literal
Console.WriteLine(true);    // boolean literal

// Declare variables

string firstName;            // a string variabl
char userOption;             // a character variabl
int gameScore;               // a integer variabl
decimal particlesPerMillion; // a decimal variabl
bool processedCustomer;      // a boolean variabl

firstName = "Bob";                 // set a value of a string variable
userOption = 'A';                  // set a value of a character variable
gameScore = 100_000;               // set a value of a integer variable
particlesPerMillion = 100_000.00M; // set a value of a decimal variable
processedCustomer = true;          // set a value of a boolean variable

var message = "Hello, World!"; // set a value of a implicitly typed local variable
