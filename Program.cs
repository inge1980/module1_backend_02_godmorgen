//Console.Clear();

string userName = ReadWhileNotEmpty("Vennligst skriv inn navnet ditt:");

int userAge;
while (true)
{
    var ageInput = ReadWhileNotEmpty("Vennligst skriv inn alderen din (heltall):");
    if (int.TryParse(ageInput, out userAge) && userAge > 0) break;
    Console.WriteLine("Ugyldig alder. Skriv et positivt heltall.");
}

string userFavoriteColor = ReadWhileNotEmpty("Vennligst skriv inn favorittfargen din:");

var now = DateTime.Now;
string timestamp = now.ToString("HH:mm:ss");

// Lage en custom hilsen basert på tidspunktet på dagen
int hour = now.Hour;
string timeOfDay;
switch (hour) {
    case >= 5 and < 12:
        timeOfDay = "Morgen";
        break;
    case >= 12 and < 18:
        timeOfDay = "Ettermiddag";
        break;
    case >= 18 and < 23:
        timeOfDay = "Kveld";
        break;
    default:
        timeOfDay = "Natt";
        break;
}
string baseGreeting = "God" + timeOfDay.ToLower();
string ageSuffix = userAge < 18 ? "Ha en flott dag på skolen!" : "Ha en fin dag videre!";

Console.WriteLine($"{baseGreeting}, {userName}! Klokken er {timestamp} ({timeOfDay}).");
Console.WriteLine($"Du er {userAge} år gammel og liker fargen {userFavoriteColor}. {ageSuffix}");

// Gjentagende input prompt-funksjon
string ReadWhileNotEmpty(string prompt)
{
    while (true)
    {
        Console.WriteLine(prompt);
        var input = Console.ReadLine() ?? string.Empty;
        if (!string.IsNullOrWhiteSpace(input)) return input.Trim();
        Console.WriteLine("Input kan ikke være tom. Vennligst prøv igjen.");
    }
}