using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Computer_Component_Store.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Computer_Component_Store
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            //look here for Entity Framework
            //OPTIONS FOR DATABASE

            services.AddDbContext<ApplicationDbContext>(options =>
            //Great for Unit Testing!
            //options.UseInMemoryDatabase("fake_database");     
            //For MySQL, I've preferred to the Pomelo.EntityFrameworkCore.MySql NuGet Package,
            //longer term, the MySql.Data.EntityFrameworkCore is probably going to be used more often.
            //options.UseMySql(Configuration.GetConnectionString("MySqlConnection")));

            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            services.AddIdentity<ComputerUser, IdentityRole>()
                .AddDefaultUI()
                .AddRoles<IdentityRole>()
                .AddRoleManager<RoleManager<IdentityRole>>()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddTransient((s) => {
                return new SendGrid.SendGridClient(Configuration.GetValue<string>("SendGridApiKey"));
            });


            services.AddTransient<Microsoft.AspNetCore.Identity.UI.Services.IEmailSender>((s) =>
            {
                return new Computer_Component_Store.Services.EmailSender(s.GetService<SendGrid.SendGridClient>());
            });


            services.AddTransient<Braintree.IBraintreeGateway>(
                (s) =>
                {
                    return new Braintree.BraintreeGateway(
                        Configuration.GetValue<string>("Braintree:Environment"),
                        Configuration.GetValue<string>("Braintree:MerchantId"),
                        Configuration.GetValue<string>("Braintree:PublicKey"),
                        Configuration.GetValue<string>("Braintree:PrivateKey")
                    );
                }
            );

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            //STARTUP PAGE HERE
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Products}/{action=AllProducts}/{id?}");
            });
        }
    }
}
