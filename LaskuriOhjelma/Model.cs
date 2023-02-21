using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Spectre.Console;

public class KantaContext : DbContext
{
        public DbSet<Asiakas> Asiakas { get; set; }
        public string DbPath { get; }

        public KantaContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "k-asiakas-database.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

}

public class Asiakas
{
    public int ID { get; set; }
    public string? Name { get; set;}
    public string? Favmovie { get; set;}

}