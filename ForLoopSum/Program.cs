

int sum = 0;


for(int i = 1; i < 11; i++) //i --= i - 1
{
    Console.WriteLine($"i = {i} ");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i; 
    //sum = += i;
}

Console.WriteLine($"Final total {sum}");

//Control.WriteLine($"Final total {sum}");

