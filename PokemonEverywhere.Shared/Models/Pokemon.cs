using System.Text.Json.Serialization;

namespace PokemonEverywhere.Shared.Models;

public class Pokemon
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public Name Name { get; set; }

    [JsonPropertyName("type")]
    public List<string> Type { get; set; }

    [JsonPropertyName("base")]
    public Base Base { get; set; }

    [JsonPropertyName("species")]
    public string Species { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("evolution")]
    public Evolution Evolution { get; set; }

    [JsonPropertyName("profile")]
    public Profile Profile { get; set; }

    [JsonPropertyName("image")]
    public Image Image { get; set; }
}

public class Base
{
    [JsonPropertyName("HP")]
    public int HP { get; set; }

    [JsonPropertyName("Attack")]
    public int Attack { get; set; }

    [JsonPropertyName("Defense")]
    public int Defense { get; set; }

    [JsonPropertyName("Sp. Attack")]
    public int SpAttack { get; set; }

    [JsonPropertyName("Sp. Defense")]
    public int SpDefense { get; set; }

    [JsonPropertyName("Speed")]
    public int Speed { get; set; }
}

public class Evolution
{
    [JsonPropertyName("next")]
    public List<List<string>> Next { get; set; }

    [JsonPropertyName("prev")]
    public List<string> Prev { get; set; }
}

public class Image
{
    [JsonPropertyName("sprite")]
    public string Sprite { get; set; }

    [JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; }

    [JsonPropertyName("hires")]
    public string Hires { get; set; }
}

public class Name
{
    [JsonPropertyName("english")]
    public string English { get; set; }

    [JsonPropertyName("japanese")]
    public string Japanese { get; set; }

    [JsonPropertyName("chinese")]
    public string Chinese { get; set; }

    [JsonPropertyName("french")]
    public string French { get; set; }
}

public class Profile
{
    [JsonPropertyName("height")]
    public string Height { get; set; }

    [JsonPropertyName("weight")]
    public string Weight { get; set; }

    [JsonPropertyName("egg")]
    public List<string> Egg { get; set; }

    [JsonPropertyName("ability")]
    public List<List<string>> Ability { get; set; }

    [JsonPropertyName("gender")]
    public string Gender { get; set; }
}
