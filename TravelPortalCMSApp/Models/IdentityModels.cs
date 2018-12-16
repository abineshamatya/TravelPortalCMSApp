using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TravelPortalCMSApp.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("TravelPortalCMSConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<AdminModel> AdminModels { get; set; }
        public DbSet<PackagesModel> PackageModels { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<ImagePath> ImagePaths { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Banner> banners { get; set; }
        public DbSet<Welcome> welcomes { get; set; }
        public DbSet<LatestNews> LatestNews { get; set; }

        //public DbSet<Image> Image { get; set; }

    }
}