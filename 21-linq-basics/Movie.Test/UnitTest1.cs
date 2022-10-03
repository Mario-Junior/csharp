namespace Movie.Test;

public class UnitTest1
{
    public static List<Movie> MockCollection()
    {
    List<Movie> _context = new(){};

    _context.Add(new Movie { title = "Star Wars: The Rise of Skywalker", premiereYear = 2017, genre = "Action", director = "J.J. Abrams", imdbRating = "8.7", imdbVotes = "1,979,872" });
    _context.Add(new Movie { title = "Star Wars: The Last Jedi", premiereYear = 2017, genre = "Action", director = "Rian Johnson", imdbRating = "8.5", imdbVotes = "1,074,927", });
    _context.Add(new Movie { title = "Star Wars: The Force Awakens", premiereYear = 2015, genre = "Action", director = "J.J. Abrams", imdbRating = "8.3", imdbVotes = "1,038,191" });

    return _context;
    }

    [Fact]
    public void HasGenre_Action()
    {
        var starWarsMovies = MockCollection();

        var result = from movies in starWarsMovies
            where movies.genre == "Action"
            select movies;

        // SEM FluentAssertions (DESCOMENTAR para ver)
        // Assert.True(result.Any());

        // COM FluentAssertions
        result.Should().NotBeEmpty();
    }
}
