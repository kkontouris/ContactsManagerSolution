using _16CrudExample.Filters.ActionFilters;
using ContactsManager.Core.Domain.IdentityEntities;
using DinkToPdf.Contracts;
using DinkToPdf;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Repositories;
using RepositoryContracts;
using ServiceContracts;
using Services;

namespace _16CrudExample.StartupExtensions
{
	public static class ConfigureServicesExtensions
	{

		public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
		{
			//it adds controllers and views as services
			services.AddControllersWithViews(options =>
			{

            options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
            });


            //Add Services into Ioc Container
            services.AddScoped<ICountriesRepository, CountriesRepository>();
			services.AddScoped<IPersonsRepository, PersonsRepository>();
			services.AddScoped<ICountriesService, CountriesService>();
			services.AddScoped<IPersonGetterService, PersonGetterService>();
			services.AddScoped<IPersonAdderService, PersonAdderService>();
			services.AddScoped<IPersonUpdaterService, PersonUpdaterService>();
			services.AddScoped<IPersonDeleterService, PersonDeleterService>();
			services.AddScoped<IPersonSorterService, PersonSorterService>();


            services.AddTransient<PersonsListActionFilter>();

			services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

			services.AddDbContext<ApplicationDbContext>(options => { options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")); });

            //Enable Identity in this project
            services.AddIdentity<ApplicationUser, ApplicationRole>(options=>
				{
					options.Password.RequiredLength = 5;
					options.Password.RequireNonAlphanumeric = false ;
					options.Password.RequireUppercase = false;
					options.Password.RequireLowercase = true;
					options.Password.RequireDigit = false;
					options.Password.RequiredUniqueChars = 3;
				})

				.AddEntityFrameworkStores<ApplicationDbContext>()

				.AddDefaultTokenProviders()

				.AddUserStore<UserStore<ApplicationUser, ApplicationRole, ApplicationDbContext, Guid>>()

				.AddRoleStore<RoleStore<ApplicationRole, ApplicationDbContext, Guid>>();

			services.AddAuthorization(options =>
			{
			options.FallbackPolicy= new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                //enforces authorization policy(user must be authenticated ) for all th action methods

                options.AddPolicy("NotAuthorized", policy =>
                {
                    policy.RequireAssertion(context =>
                    {
                        return !context.User.Identity.IsAuthenticated;
                    });
                });

            });

			//whenever user is not authorized to an action it has to redirect to this particular url
			services.ConfigureApplicationCookie(options =>
			{
				options.LoginPath = "/Account/Login";
			});
			services.AddHttpLogging(options =>
			{
				options.LoggingFields = Microsoft.AspNetCore.HttpLogging.HttpLoggingFields.RequestProperties;
			});
		}
	}
}
