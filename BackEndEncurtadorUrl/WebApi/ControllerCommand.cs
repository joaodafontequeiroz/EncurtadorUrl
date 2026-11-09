using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Domain.Entidades;
public static class ControllerCommand 
{
    public static void CommandRoutes (this WebApplication app){
        var Group = app.MapGroup("/");

        Group.MapPost("", () =>
        {
            
        });

        
    }
}