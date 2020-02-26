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
    return add;
    }
    void Addition3()
    {
    add=(num1+num2+num3);
    return add;
    }
    void Addition4()
    {
    add=(num1+num2+num3+num4);
    return add;
    }
    void Subtraction2()
      {
      sub=(num1+num2);
      return sub;
      }
      void Subtraction3()
      {
      sub=(num1+num2+num3);
      return sub;
      }
    void Multi2()
    {
        mult=(num1*num2);
        return mult;
    }
    void Multi3()
    {
        mult=(num1*num2*num3);
        return mult;
    }
    void Mult4()
    {
        mult=(num1*num2*num3*num4);
        return mult;
    }
    void div2()
    {
        div=(num1/num2);
        return div;
    }
    void div3()
    {
        div=(num1/num2/num3);
        return div;
    }
        public void Add()
        {
            int add;
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Hello How many numbers are you trying to Add?  2 , 3 or 4?");
            add=int.Parse(Console.ReadLine());
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            switch (add)
            {
                case 2:
                    Addition2();
                    break;
                case 3:
                    Addition3();
                    break;
                case 4:
                    Addition4();
                    break;
            }
                    
                    
