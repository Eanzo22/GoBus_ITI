using DAL;
using BL;
using DAL.Data.Context;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using DAL.Repos.ApplicationRoleRepo;
using DAL.Repos.ApplicationUserRepo;
using DAL.Repos.ApplicationUserRoleRepo;
using DAL.Repos.PolicyRepo;
using DAL.Repos.ReservationRepo;
using BL.Managers.ApplicationUserManagers;
using BL.Managers.ApplicationRoleManagers;
using BL.Managers.ApplicationUserRoleManagers;
using BL.Managers.PolicyManagers;
using BL.Managers.ReservationManagers;
using BL.Managers.PaymentManagers;
using DAL.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Security.Claims;
using DAL.Repos.BusClassRepo;
using DAL.Repos.BusRepo;
using DAL.Repos.ClassImageRepo;
using DAL.Repos.TermRepo;
using DAL.Repos.TicketRepo;
using BL.Managers.BusClassManagers;
using BL.Managers.BusManagers;
using BL.Managers.ClassImageManagers;
using BL.Managers.TermManagers;
using BL.Managers.TicketManagers;
using Hangfire;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;

namespace GoBusAPI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        #region Repos
        builder.Services.RegisterDALMethod();
        #endregion

        #region Managers
        builder.Services.RegisterBLMethod();
        #endregion

        #region UnitOfWork
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        #endregion


        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Ensure web root path is set
        if (string.IsNullOrEmpty(builder.Environment.WebRootPath))
        {
            builder.Environment.WebRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
        }

        #region UnitOfWork
        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        #endregion

        #region Database
        var constr = builder.Configuration.GetConnectionString("constr");
        builder.Services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(constr);
        });
        #endregion

        #region Hangfire
        builder.Services.AddHangfire(config =>
        {
            config.UseSqlServerStorage(builder.Configuration.GetConnectionString("constr"));
        });
        builder.Services.AddHangfireServer();
        #endregion

        #region Identity

        builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

        #endregion

        #region Authentication

        builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(option =>
        {
            option.SaveToken = true;
            option.TokenValidationParameters = new TokenValidationParameters()
            {
                RequireExpirationTime = true,
                ValidateIssuer = true,
                ValidIssuer = builder.Configuration["JWT:Issuer"],
                ValidateAudience = true,
                ValidAudience = builder.Configuration["JWT:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]!)),
            };
        });


        #endregion

        #region Authorization

        builder.Services.AddAuthorization(options =>
        {
            options.AddPolicy("ForUser", policy =>
            {
                policy.RequireClaim(ClaimTypes.Role, "User");
            });

            options.AddPolicy("ForAdmin", policy =>
            {
                policy.RequireClaim(ClaimTypes.Role, "Admin");
            });

            options.AddPolicy("ForDriver", policy =>
            {
                policy.RequireClaim(ClaimTypes.Role, "Driver");
            });
        });


        #endregion

        #region Files Service
        builder.Services.Configure<FormOptions>(options =>
        {
            options.MultipartBodyLengthLimit = long.MaxValue;
        });
        #endregion


        #region CORS Policy
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAllDomains", policy =>
            {
                policy.AllowAnyOrigin()
                      .AllowAnyHeader()
                      .AllowAnyMethod();
            });
        });
        #endregion

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        //if (app.Environment.IsDevelopment())
        //{
            app.UseSwagger();
            app.UseSwaggerUI();
       // }

        app.UseHangfireDashboard();
        app.UseHttpsRedirection();
        app.UseCors("AllowAllDomains");
        //app.UseStaticFiles();
        app.UseStaticFiles(new StaticFileOptions
        {
            FileProvider = new PhysicalFileProvider(builder.Environment.WebRootPath),
            RequestPath = "/Uploades"
        });

        app.UseAuthentication();
        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
