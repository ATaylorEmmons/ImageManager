

using Microsoft.EntityFrameworkCore;

namespace ImageManager.Models
{
    public class ImageStoreContext : DbContext
    {
        public DbSet<ImageModel> Images { get; set; }

        public ImageStoreContext(DbContextOptions<ImageStoreContext> options): base(options) { }
    }
}
