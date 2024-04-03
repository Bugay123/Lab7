using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MusicCollection.Data;

namespace Lab7
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var dbContext = new MusicDbContext(new DbContextOptionsBuilder<MusicDbContext>().UseNpgsql("Host=localhost;Port=5432;Database=lab7;Username=postgres;Password=postgres;").Options))
            {
                dbContext.Database.EnsureCreated();
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MusicCollection.Form1());


        }
    }
}

