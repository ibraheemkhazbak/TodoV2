using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TodoV2.Application.Interfaces;
using TodoV2.Application.People.Command;
using TodoV2.Application.People.Query;
using TodoV2.Application.TodoItems.Command;
using TodoV2.Application.TodoItems.Command.Factories;
using TodoV2.Data;
using TodoV2.Presentation;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup();

startup.AddServices(builder.Services, builder.Configuration.GetConnectionString("todoDb"));

var app = builder.Build();

 if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
