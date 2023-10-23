using Microsoft.AspNetCore.Components;

namespace Products.Pages
{
    public partial class Home
    {
        [Parameter]
        public string Title { get; set; }

        [Parameter]
        public RenderFragment BrowseContent { get; set; }
    }
}
