﻿using BussinessLogicLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLibrary
{
    public class FabolousDbContext : DbContext
    {
        public DbSet<Car> cars { get; set; } 
        public DbSet<Motorcycle> motorcycles { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TestDataBase;Trusted_Connection=True;");
        }
        /// <summary>
        /// Mata databasen med testdata när den skapas för första gången
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(SeedTestData());
            modelBuilder.Entity<Motorcycle>().HasData(SeedTestDataMc());

        }
        /// <summary>
        /// Seed metod för att läsa in bilar ifrån fil
        /// </summary>
        /// <returns></returns>
        public List<Car> SeedTestData()
            {
                var cars = new List<Car>();
                using (StreamReader reader = new StreamReader(@"CarsTestData.json"))
                {
                    string json = reader.ReadToEnd();
                    cars = JsonConvert.DeserializeObject<List<Car>>(json);
                }
                return cars;
            }
            /// <summary>
            /// Seed metod för att läs in mc´s från fil
            /// </summary>
            /// <returns></returns>
            public List<Motorcycle> SeedTestDataMc()
            {
                var mc = new List<Motorcycle>();
                using (StreamReader reader = new StreamReader(@"McTestData.json"))
                {
                    string json = reader.ReadToEnd();
                    mc = JsonConvert.DeserializeObject<List<Motorcycle>>(json);
                }
                return mc;
            }
        }
}
