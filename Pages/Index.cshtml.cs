using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Zodiac.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public int Birthyear { get; set; }

    public string ZodiacImageUrl { get; set; } = "/images/questionmark.png";

    public string ZodiacAnimal {get; set;} = "";

    public void OnPost()
    {
        ZodiacImageUrl = GetZodiacAnimalImage(Birthyear);
        ZodiacAnimal = GetZodiacAnimal(Birthyear);
    }

    private string GetZodiacAnimalImage(int birthyear)
    {
        // Logic to calculate Zodiac animal based on birthyear
        // Here we return the corresponding image URL based on the year
        int zodiacIndex = (birthyear - 1900) % 12;
        string[] zodiacImages = {
            "/images/rat.png", "/images/ox.png", "/images/tiger.png",
            "/images/rabbit.png", "/images/dragon.png", "/images/snake.png",
            "/images/horse.png", "/images/goat.png", "/images/monkey.png",
            "/images/rooster.png", "/images/dog.png", "/images/pig.png"
        };

        return zodiacImages[zodiacIndex];
    }

    private string GetZodiacAnimal(int birthyear)
    {
        // Logic to calculate Zodiac animal based on birthyear
        // Here we return the corresponding animal based on the year
        int zodiacIndex = (birthyear - 1900) % 12;
        string[] zodiac = {
            "Rat", "Ox", "Tiger",
            "Rabbit", "Dragon", "Snake",
            "Horse", "Goat", "Monkey",
            "Rooster", "Dog", "Pig"
        };

        return zodiac[zodiacIndex];
    }
}

