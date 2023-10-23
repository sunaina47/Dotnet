using Microsoft.AspNetCore.Components;
using System.ComponentModel;

namespace MovieSearch.Pages
{
    public class IndexBase : ComponentBase
    {
        protected string SearchTerm { get; set; }


        List<Data.Movie> Movies { get; set; } = new List<Data.Movie>
        {
            new Data.Movie { Title = "12 Angry Men", Year = "1957", Image = "12AngryMen1957.jpg" },
            new Data.Movie { Title = "2001 A Space Odyssey", Year = "1968", Image = "2001ASpaceOdyssey1968.jpg" }
        };
        protected IEnumerable<Data.Movie> SearchResults =>
            Movies.Where(p => 
             string.IsNullOrEmpty(SearchTerm) || p.Title.ToLower().Contains(SearchTerm.ToLower()));
    }
}
