using System;
using System.Collections.Generic;

public class Dec2Fact {

  public static string dec2FactString(long nb) {
    string result = string.Empty;
    string enc = "";
    
    long r = 0;
    int counter = 1;
    
    while (nb != 0)
    {
      r = nb % counter;
      nb /= counter++;
      
      if(r == 10)
        enc = "A";
      else if(r == 11)
        enc = "B";
       else if(r == 12)
        enc = "C";
       else if(r == 13)
        enc = "D";
       else if(r == 14)
        enc = "E";
       else if(r == 15)
        enc = "F";
       else 
        enc = r.ToString();
      
      result = enc + result;
    }

    return result;
  }
  Dictionary<int,long> fac = new Dictionary<int,long>();
  public static long factString2Dec(string str) {
    int l = str.Length - 1;
    int dec = 0;
    
    long result = 0;
    long fac = factorial(l);
    
    for(int i = 0;i < str.Length; i++)
    {
      if(str[i] == 'A')
        dec = 10;
      else if(str[i] == 'B')
        dec = 11;
      else if(str[i] == 'C')
        dec = 12;
      else if(str[i] == 'D')
        dec = 13;
      else if(str[i] == 'E')
        dec = 14;
      else if(str[i] == 'F')
        dec = 15;
      else
       dec = Convert.ToInt16(str[i].ToString());
      
      result += dec * fac;
      
      if(l != 0)
       fac = fac /(l--);
    }
    
    return result;
  }
  public static long factorial(int n) {
     long res = 1;
     while (n != 1) {
        res = res * n;
        n = n - 1;
     }
     return res;
  }
}
