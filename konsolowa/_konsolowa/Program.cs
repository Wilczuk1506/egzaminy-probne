// See https://aka.ms/new-console-template for more information

using System;

int numberOfThrows = 0;
bool playAgain = true;

while (numberOfThrows > 10 || numberOfThrows < 3)
{
    Console.WriteLine("Ile kostek chcesz rzucić?(3 - 10)");
    numberOfThrows = Int32.Parse(Console.ReadLine());
}

Dictionary<int, int> numbers;
while (playAgain)
{
    numbers = new Dictionary<int, int>();

    for (int i = 0; i < numberOfThrows; i++)
    {
        int rand = GetRandomNumber();
        Console.WriteLine("Kostka " + (i + 1) + ": " + rand);

        if (numbers.ContainsKey(rand))
        {
            numbers[rand]++;
        }
        else
        {
            numbers.Add(rand, 1);
        }
    }

    Console.WriteLine("Liczba uzyskanych punktów: " + CountDiceThrowsResult());
    Console.WriteLine("Jeszcze raz? (t/n)");
    
    string answer = Console.ReadLine();

    if(answer == "t")
    {
        playAgain = true;
    }
    if(answer == "n")
    {
        playAgain = false;
    }

}
//************************************************
// nazwa: GetRandomNumber
// opis: Losuje liczbę z przedział od 1 do 6 włącznie
// parametry: brak
// zwracany typ i opis: int, wylosowaną liczbę
// autor: Ilczuk Wiktor
//************************************************
int GetRandomNumber()
{
    Random random = new Random();

    return random.Next(1, 7);
}

int CountDiceThrowsResult()
{
    int counter = 0;

    foreach (KeyValuePair<int, int> pair in numbers)
    {
        int miniCounter = 0;
        if (pair.Value >= 2)
        {
            for (int i = 0; i < pair.Value; i++)
            {
                miniCounter += pair.Key;
            }
        }
        counter += miniCounter;
    }

    return counter;
}
