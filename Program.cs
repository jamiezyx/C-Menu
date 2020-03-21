using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;



namespace Openproject
{
   class Menu
 {
    public int add;
    public int sub;
    public int mult;
    public int div;
    public int num1;
    public int num2;
    public int num3;
    public int num4;
    
    void Addition2()
    {
    add=(num1+num2);
    Console.WriteLine(add);
    }
    void Addition3()
    {
    add=(num1+num2+num3);
    Console.WriteLine(add);
    }
    void Addition4()
    {
    add=(num1+num2+num3+num4);
    Console.WriteLine(add);
    }
    void Subtraction2()
      {
      sub=(num1+num2);
      Console.WriteLine(sub);
      }
      void Subtraction3()
      {
      sub=(num1+num2+num3);
      Console.WriteLine(sub);
      }
    void Multi2()
    {
        mult=(num1*num2);
        Console.WriteLine(mult);
    }
    void Multi3()
    {
        mult=(num1*num2*num3);
        Console.WriteLine(mult);
    }
    void Multi4()
    {
        mult=(num1*num2*num3*num4);
        Console.WriteLine(mult);
    }
    void div2()
    {
        div=(num1/num2);
        Console.WriteLine(div);
    }
    void div3()
    {
        div=(num1/num2/num3);
        Console.WriteLine(div);
    }
        public void Add()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Hello How many numbers are you trying to Add?  2 , 3 or 4?");
            add=int.Parse(Console.ReadLine());
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            switch (add)
            {
                case 2:
                 getdata2();
                    Addition2();
                    break;
                case 3:
                 getdata3();
                    Addition3();
                    break;
                case 4:
                 getdata4();
                    Addition4();
                    break;
            }
        }
    public void subtract()
    {
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine(" Hello, How many numbers are you trying to subract? 2, 3");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        sub=int.Parse(Console.ReadLine());
        switch (sub)
        {
            case 2:
             getdata2();
                Subtraction2();
                break;
            case 3:
             getdata3();
                Subtraction3();
                break;
        }
    }
       void getdata2()
     {
       Console.WriteLine("Please enter the first number");
       num1=int.Parse(Console.ReadLine());
      Console.WriteLine("Please enter the second number");
       num2=int.Parse(Console.ReadLine());
       }
       void getdata3()
     {
       Console.WriteLine("Please enter the first number");
       num1=int.Parse(Console.ReadLine());
      Console.WriteLine("Please enter the second number");
       num2=int.Parse(Console.ReadLine());
       Console.WriteLine("Please enter the third number");
       num3=int.Parse(Console.ReadLine());
       }
       void getdata4()
     {
       Console.WriteLine("Please enter the first number");
       num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number");
       num2=int.Parse(Console.ReadLine());
       Console.WriteLine("Please enter the third number");
       num3=int.Parse(Console.ReadLine());
       Console.WriteLine("Please enter the fourth number");
       num4=int.Parse(Console.ReadLine());
       }
         
      public void Multiply()
     {
       Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine(" Hello, How many numbers are you trying to Multiply 2, 3 or 4");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        mult=int.Parse(Console.ReadLine());
        switch (mult)
        {
            case 2:
             getdata2();
                Multi2();
                break;
            case 3:
             getdata2();
                Multi3();
                break;
            case 4:
             getdata4();
                Multi4();
                break;
            
        }
    }
     public void Divide()
     {
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine(" Hello, How many numbers are you trying to Divide 2, 3");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        div=int.Parse(Console.ReadLine());
       switch (div)
        {
            case 2:
            getdata2();
                div2();
                break;
            case 3:
            getdata3();
                div3();
                break;
       }
     }
     class Pro
     {
       
       static void Main(String []args)
       {
         string Choice;
         Menu MenuProgram = new Menu();
         
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        Console.WriteLine(" Hello, Are you trying to Multiply, Divide, Add, subract numbers?");
        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
         Choice=Console.ReadLine();
        switch (Choice)
        {
          case "Multiply":
            MenuProgram.Multiply();
            break;
          case "Divide":
            MenuProgram.Divide();
            break;
          case "Add":
            MenuProgram.Add();
            break;
          case "subract":
            MenuProgram.subtract();
            break;
        }
       }
     }
   }
}
}
