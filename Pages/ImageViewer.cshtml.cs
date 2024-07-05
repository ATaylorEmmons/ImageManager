using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ImageManager.Pages
{
    public class ImageViewerModel : PageModel
    {
        public List<String>? ImageSrcs { get; set; }


        public void OnGet()
        {
        }
    }
}
