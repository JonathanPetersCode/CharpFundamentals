using System;


  class Program
  {
      static void Main(string[] args)
      {
          //Bitwise Example
          byte a = 16;
          var l = a >> 5;
          Console.WriteLine(l);
          
          //Cascade Assignment
          int x, y, z;
          int result = x = y = z = 25;
          Console.WriteLine(result);

          //Conditional Operator 
          int f = 5;
          string msg1 = "f is greater than 4";
          string msg2 = "f is less than 4";
          Console.WriteLine(f > 4 ? (string)msg1 : (string)msg2);

          //Indexer
          string fakeName = "Hooofdfdfdsgssjkdssdgsd the 3rg";
          Console.WriteLine(fakeName[0]);

          //access operator .
          Console.WriteLine(DateTime.Now);
            
          //is operator 
          string title = "lost cat";
          Console.WriteLine(title is string);
          
          // ?? operator and nullable value ?
          double? myNumber = null;
          Console.WriteLine(myNumber ?? 65);

          //Type Conversion (int to long)
          int randNum = 35;
          Console.WriteLine(randNum);
          long coolNum = randNum;
          Console.WriteLine(coolNum + randNum);

          string cereal = "What";
          string myCer = cereal.Substring(cereal.Length - 1);
          char luclyChar = myCer[0];
          Console.WriteLine(luclyChar);

          long myLong = long.MaxValue;
          Console.WriteLine(myLong);


      }    
    }
