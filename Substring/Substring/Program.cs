

string str = "hello world";
string newstr = "";

Console.WriteLine(Substring(str, 0, 2));
string Substring(string str, int j, int length)
{
    for (int i = j; i <= length; i++)
{
    newstr += str[i];
}   return newstr;
}


