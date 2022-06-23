// See https://aka.ms/new-console-template for more information


 string[] monthsofyear =  {"january", "febrary", "march","april", "may", "june","july","august","september","october","november","december"};
string[] CopiedMonth = new string[6];
Console.WriteLine("---------------------Question1---------------");
 Console.WriteLine(monthsofyear.Length);
 Console.WriteLine("------------------Question2-------------");
 for (int M = 0; M < monthsofyear.Length; M++)
 {
     int rank = M + 1;
    Console.WriteLine($"{rank}.{monthsofyear[M]}"); 

 }
 Console.WriteLine("--------------Question3--------------");
 Console.WriteLine("------------reverse------------");

 for (int i = monthsofyear.Length - 1; i >= 0 ; i--)
 {
  int rank = i;
  Console.WriteLine($"{rank}.{monthsofyear[i]}");
 }

  Console.WriteLine("--------------OR--------------");
   
  Array.Reverse(monthsofyear);

   foreach (string value in monthsofyear) 
   {
       Console.WriteLine(value);
  }

  Console.WriteLine("-------------Question4----------------");
  Console.WriteLine("-----------alphabetical order--------------");
  Array.Sort(monthsofyear); 
  foreach(string data in monthsofyear)
  {
  Console.WriteLine(data);
  }
  Console.WriteLine("------------------OR-----------------");
  for (int M = 0; M < monthsofyear.Length; M++)
  {
    int rank = M +1;
    Console.WriteLine(rank + "." +monthsofyear[M]);
   }
   Console.WriteLine("-------------Question5-----------");
   Console.WriteLine("--------------copy of six month------------ ");
    Array.ConstrainedCopy(monthsofyear,0,CopiedMonth,0,6);
    foreach (string month in CopiedMonth)
    {
      Console.WriteLine(month);
    }
    Console.WriteLine("-------------------0R-----------------");
    
 Array.Copy(monthsofyear,0,CopiedMonth,0,6);
 for (int CM = 0; CM< CopiedMonth.Length;  CM++)
{
 Console.WriteLine(CopiedMonth[CM]);
 }

    Console.WriteLine("-----------Question6----------------");
   Console.WriteLine("----------------clone of copied months--------------");
   string[] clonedmonths = (string[])CopiedMonth.Clone();
   foreach (string clone in clonedmonths)
   {
     Console.WriteLine(clone);
   }
   Console.WriteLine("------------Question 7---------------");
     Console.WriteLine("-------------------clearing the month in the first array----------");
   Array.Clear(monthsofyear);
   foreach (string word in monthsofyear)
   {
     Console.WriteLine(word);
   }
   Console.WriteLine("-----------------Question8-------------");
   Console.WriteLine("---------------clearing the month in copied array-----------");
    Array.Clear(CopiedMonth);
    foreach (string letter in CopiedMonth)
    {
      Console.WriteLine(letter);
    }
