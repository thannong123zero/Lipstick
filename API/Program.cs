using API.ContextObject;
using API.Helpers;
using API.IRepositories;
using API.Repositories;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
                      policy =>
                      {
                          policy.WithOrigins("http://127.0.0.1:5500/",
                                              "http://www.contoso.com");
                      });
});
string connection = builder.Configuration.GetConnectionString("SqlConnection");
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlServer(connection));

// Add services to the container.
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<DatabaseContext>();
builder.Services.AddTransient<UnitOfWork>();
builder.Services.AddTransient<MenuGroupHelper>();
builder.Services.AddTransient<MenuItemHelper>();
builder.Services.AddTransient<UnitHelper>();
builder.Services.AddTransient<TopicHelper>();
builder.Services.AddTransient<BrandHelper>();
builder.Services.AddTransient<ArticleHelper>();
builder.Services.AddTransient<ProductHelper>();
// sign up database context

//builder.Services.AddScoped<IMenuGroupRepository, MenuGroupRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
