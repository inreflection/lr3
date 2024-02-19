using System;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ICalculatorController, CalcService>();
builder.Services.AddTransient<ITimeOfDayController, TimeOfDay>();

var app = builder.Build();

app.MapGet("", async context =>
{
    var calcService = app.Services.GetService<ICalculatorController>();
    var timeOfDay = app.Services.GetService<ITimeOfDayController>();
    await context.Response.WriteAsync($"Task1:\nAdd: {calcService?.Add(77, 121, 930, 10.21, 496, 57810, -10000)}\n");
    await context.Response.WriteAsync($"Sub: {calcService?.Subtract(1972.7, 210, 59.8, 1001, -10)}\n");
    await context.Response.WriteAsync($"Mult: {calcService?.Multiply(100.47, 1976, 1.38, 820.1)}\n");
    await context.Response.WriteAsync($"Div: {calcService?.Divide(973, 146.8, 9)}\n");
    await context.Response.WriteAsync($"Task2:\n{timeOfDay?.GetCurrentTimeOfDay()}\n");
});

app.Run();
