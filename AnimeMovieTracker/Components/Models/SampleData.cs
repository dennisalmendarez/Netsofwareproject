namespace AnimeMovieTracker.Components.Models;

public static class SampleData
{
    public static List<MediaItem> Items = new()
    {
        new MediaItem
        {
            Id = 1,
            Title = "Demon Slayer",
            Type = "Anime",
            Genre = "Action",
            Year = 2019,
            Rating = 8.7,
            ImageUrl = "https://placehold.co/300x450?text=Demon+Slayer",
            Description = "A young swordsman fights demons while protecting his sister."
        },
        new MediaItem
        {
            Id = 2,
            Title = "Solo Leveling",
            Type = "Anime",
            Genre = "Fantasy",
            Year = 2024,
            Rating = 8.5,
            ImageUrl = "https://placehold.co/300x450?text=Solo+Leveling",
            Description = "A weak hunter gains the power to level up alone."
        },
        new MediaItem
        {
            Id = 3,
            Title = "Interstellar",
            Type = "Movie",
            Genre = "Sci-Fi",
            Year = 2014,
            Rating = 8.7,
            ImageUrl = "https://placehold.co/300x450?text=Interstellar",
            Description = "A space mission searches for humanity's future."
        },
        new MediaItem
        {
            Id = 4,
            Title = "The Dark Knight",
            Type = "Movie",
            Genre = "Action",
            Year = 2008,
            Rating = 9.0,
            ImageUrl = "https://placehold.co/300x450?text=Dark+Knight",
            Description = "Batman faces the Joker in Gotham City."
        }
    };
}