for ( int i = 1; i <= 255; i++){
    Console.WriteLine(i);
}
Random rand = new Random();
int sum = 0;
for (int i = 0; i < 5; i++){
    // Console.WriteLine(rand.Next(10, 21));
    int randomNum = rand.Next(10, 21);
    sum += randomNum;
}
Console.WriteLine(sum);
for (int i = 1; i <= 100; i++){
    if (i % 3 == 0 && i % 5 == 0){
        Console.WriteLine("FizzBuzz");
    } else if (i % 3 == 0){
        // Console.WriteLine(i);
        Console.WriteLine("Fizz");
    } else if (i % 5 == 0){
        // Console.WriteLine(i);
        Console.WriteLine("Buzz");
    }
}
int j = 1;
while (j <= 100){
    string result = "";
    if (j % 3==0){
        result += "Fizz";
    }
    if (j % 5==0) {
        result += "Buzz";
    }
    if (result != "") Console.WriteLine(result);
    j++;
}