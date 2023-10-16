
using SignUp.Service;

Console.WriteLine("==============================");
Console.WriteLine("=========  LOG IN   ==========");
Console.WriteLine("==============================");
Console.WriteLine("== Sign Up  =====  Sign In ===");
salom:
Console.Write(">> ");
string command = Console.ReadLine();
string res = command.ToLower();

switch (res)
{
    case "sign up":
        SignUpService signUp = new SignUpService();
        signUp.SignUpMethod();

        goto salom;
        break;
    case "sign in":
        SignInService signIn = new SignInService();
        signIn.SignInMethod();
        goto salom;
        break;
    default:
        goto salom;
        break;

}