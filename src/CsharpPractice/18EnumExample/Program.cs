// See https://aka.ms/new-console-template for more information
using _18EnumExample;

User user = new User();
user.Name = "Test";
int status = (int)UserStatus.Active;
Console.WriteLine(status);
string serial = UserStatus.Verified.ToString();
Console.WriteLine(serial);



char c = (char)Gender.Male;
Console.WriteLine(c);