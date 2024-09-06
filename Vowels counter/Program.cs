Console.Write("Skriv en mening här : ");
string input = Console.ReadLine();

int vowels = 0;
int consonants = 0;

foreach (char tecken in input)
{
    char lowerChar = char.ToLower(tecken);

    if ("aeiou".Contains(lowerChar))
    {
        vowels++;
    }
    else if(char.IsLetter(lowerChar)) 
    {
        consonants++;
    }
}

Console.WriteLine("Antalet vokaler : " + vowels);
Console.WriteLine("Antalet Konsonanter : " +  consonants);