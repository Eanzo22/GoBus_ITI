
namespace GoBusAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            #region Repos
            builder.Services.AddScoped<IQuestionRepo, QuestionRepo>();
            #endregion

            #region Managers
            builder.Services.AddScoped<IQuestionManager, QuestionManager>();
            #endregion

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

            //get the connection string 
            var constr = builder.Configuration.GetConnectionString("constr");

            // add data base configration
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(constr);
            });

            // register the services from the different projects 
            builder.Services.RegisterDALMethod();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
