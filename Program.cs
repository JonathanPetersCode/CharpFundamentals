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

          
          Console.WriteLine(double.MaxValue);
          double sweetNum = 5e9d;
          //int igloo = checked((int)sweetNum);
          //Console.WriteLine(igloo);

          string k = "Corn Flakes ";
          double lp = 543232.56;
          Console.WriteLine(k + lp);

          int qwe = 8232;
          Console.WriteLine(qwe.ToString());

          // Write an expression that checks whether an integer is odd or even. 
        
          for(int h = 0; h <= 50; h++)
          {
              if (h % 2 != 0)
              {
                  Console.WriteLine(h + ": is odd.");
              }
              else
              {
                  Console.WriteLine(h + ": is even.");
              }
          }
          
          

      }    
    }
