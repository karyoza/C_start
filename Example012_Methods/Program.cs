// Вид №1

// void Method1()
// {
//     Console.Write("@ Авторское право");
// }
//Method1(); раскомментить для выполнения


//Вид 2 

// void Method2(string msg)
// {
//     Console.Write(msg);
// }

//Method2 ("текст");

//  void Method21 (string msg, int count)
//  {
//      int i = 0;
//      while (i < count)
//      {
//      i ++;
//      Console.WriteLine(msg);
//      }
//  }

// Method21("Test",5);

//Вид 3
//  int Method3 ()
//  {
//      return DateTime.Now.Year;
//  }
//  int year = Method3();
//  Console.Write(year);
 //Вид 4

/*string Method4(int count, string c)
{
    int i = 0;
    string result = String.Empty;
    while(i < count)
    {
        i++;
        result = result + c;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.Write(res);*/



string Metod4(int count, string text)
{
string result = String.Empty;
for (int i = 0; i<count; i++)
{
result = result + text;
}
return result;
}
string res = Metod4(10, "asdf");
Console.WriteLine(res);
