using HotelManagement.Data;
using HotelManagement.Interfaces;
using HotelManagement.Models;
using HotelManagement.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();

builder.Services.AddScoped<ITypeRoomService, TypeRoomService>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IBookingService, HotelManagement.Services.BookingService>();
builder.Services.AddScoped<IBookingServicesService, BookingServicesService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IRoomBookedService, RoomBookedService>();
builder.Services.AddScoped<IServicesManagementService, ServiceManagementService>();

//Register DbContext
builder.Services.AddDbContext<HotelManagementDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors(option => option.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseHttpsRedirection();
app.UseRouting();

app.UseEndpoints(endpoints =>
endpoints.MapControllers());

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
