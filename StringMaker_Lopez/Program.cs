// Clarissa Lopez
// IT113
// NOTES: notes the instructor should read
// BEHAVIORS NOT IMPLIMENTED AND WHY: 

using StringMaker_Lopez;

StringManager sm = new StringManager();

Console.WriteLine($"Reversed: {sm.Reverse("Sunbeam Tiger")}");
Console.WriteLine($"ToString: {sm.ToString()}");
Console.WriteLine($"Reversed Preserve Case: {sm.Reverse("Sunbeam Tiger", true)}");
Console.WriteLine($"Equals: {sm.Equals("Sunbeam Tiger")}");
Console.WriteLine($"Symmetric: {sm.Symmetric("ABBA")}");
Console.WriteLine($"Symmetric: {sm.Symmetric("ABA")}");
Console.WriteLine($"Symmetric: {sm.Symmetric("ABba")}");
Console.WriteLine(sm.Reverse("heLlo WorlD"));   
Console.WriteLine(sm.Reverse("heLlo WorlD", true));