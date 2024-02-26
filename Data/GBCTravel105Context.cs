using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GBCTravel105.Models;

namespace GBCTravel105.Data
{
    public class GBCTravel105Context : DbContext
    {
        public GBCTravel105Context (DbContextOptions<GBCTravel105Context> options)
            : base(options)
        {

        }

        public DbSet<GBCTravel105.Models.Booking> Booking { get; set; } = default;
        public DbSet<GBCTravel105.Models.Flight> Flight { get; set; }
        public DbSet<GBCTravel105.Models.Car> Car { get; set; }

        public DbSet<GBCTravel105.Models.Hotel> Hotel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Booking>().HasData(
                new Booking
                {
                    Id = 1,
                    BookingDate = DateOnly.FromDateTime(DateTime.Now),
                    price = 20,
                    bookingtype = "Car"
                }
                ) ;
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sobhagya",
                    Location = "Surat",
                    PricePerNight = 2333.44F,
                    ImageUrl = "https://images.pexels.com/photos/16104977/pexels-photo-16104977/free-photo-of-facade-of-hotel-in-city.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    status = true


                },
                new Hotel
                {
                    Id = 2,
                    Name = "Grand Hyatt",
                    Location = "Dubai",
                    PricePerNight = 350.00F,
                    ImageUrl = "https://images.pexels.com/photos/59924/pexels-photo-59924.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1",
                    status = true
                },
                new Hotel
                {
                    Id = 3,
                    Name = "The Ritz-Carlton",
                    Location = "New York",
                    PricePerNight = 550.00F,
                    ImageUrl = "https://images.pexels.com/photos/1813467/pexels-photo-1813467.jpeg?auto=compress&cs=tinysrgb&w=400",
                    status = true
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Mandarin Oriental",
                    Location = "Paris",
                    PricePerNight = 700.00F,
                    ImageUrl = "https://images.pexels.com/photos/2957461/pexels-photo-2957461.jpeg?auto=compress&cs=tinysrgb&w=400",
                    status = true
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Taj Mahal Palace",
                    Location = "Mumbai",
                    PricePerNight = 450.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 6,
                    Name = "Burj Al Arab",
                    Location = "Dubai",
                    PricePerNight = 1500.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 7,
                    Name = "Atlantis The Palm",
                    Location = "Dubai",
                    PricePerNight = 600.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 8,
                    Name = "Marina Bay Sands",
                    Location = "Singapore",
                    PricePerNight = 800.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 9,
                    Name = "The Plaza Hotel",
                    Location = "New York",
                    PricePerNight = 650.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 10,
                    Name = "Hotel Adlon Kempinski",
                    Location = "Berlin",
                    PricePerNight = 400.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 11,
                    Name = "The Langham",
                    Location = "London",
                    PricePerNight = 600.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 12,
                    Name = "Waldorf Astoria",
                    Location = "New York",
                    PricePerNight = 700.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 13,
                    Name = "Four Seasons Hotel",
                    Location = "Paris",
                    PricePerNight = 800.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 14,
                    Name = "The Peninsula",
                    Location = "Hong Kong",
                    PricePerNight = 900.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 15,
                    Name = "Bellagio",
                    Location = "Las Vegas",
                    PricePerNight = 600.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 16,
                    Name = "Raffles Hotel",
                    Location = "Singapore",
                    PricePerNight = 750.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 17,
                    Name = "Hotel del Coronado",
                    Location = "San Diego",
                    PricePerNight = 400.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 18,
                    Name = "MGM Grand",
                    Location = "Las Vegas",
                    PricePerNight = 550.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 19,
                    Name = "Shangri-La Hotel",
                    Location = "Bangkok",
                    PricePerNight = 650.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 20,
                    Name = "Ritz-Carlton",
                    Location = "Los Angeles",
                    PricePerNight = 700.00F,
                    ImageUrl = "",
                    status = true
                },
                new Hotel
                {
                    Id = 21,
                    Name = "InterContinental",
                    Location = "Sydney",
                    PricePerNight = 800.00F,
                    ImageUrl = "",
                    status = true
                }
                );
            modelBuilder.Entity<Flight>().HasData(
                new Flight { Id = 1, Airline = "AIR CANADA", Origin = "BOM", Destination = "YYZ", DepartureTime = DateTime.Now, ArrivalTime = DateTime.Now.AddHours(30), Price = 600.00m },
                new Flight
                {
                    Id = 6,
                    Airline = "AIR CANADA",
                    Origin = "BOM",
                    Destination = "YYZ",
                    DepartureTime = DateTime.Now,
                    ArrivalTime = DateTime.Now.AddHours(30),
                    Price = 500.00m
                },
                new Flight
                {
                    Id = 2,
                    Airline = "Emirates",
                    Origin = "DXB",
                    Destination = "JFK",
                    DepartureTime = DateTime.Now.AddDays(1),
                    ArrivalTime = DateTime.Now.AddDays(1).AddHours(14),
                    Price = 800.00m
                },
                new Flight
                {
                    Id = 3,
                    Airline = "British Airways",
                    Origin = "LHR",
                    Destination = "SFO",
                    DepartureTime = DateTime.Now.AddDays(2),
                    ArrivalTime = DateTime.Now.AddDays(2).AddHours(10),
                    Price = 700.00m
                },
                new Flight
                {
                    Id = 4,
                    Airline = "Lufthansa",
                    Origin = "FRA",
                    Destination = "MIA",
                    DepartureTime = DateTime.Now.AddDays(3),
                    ArrivalTime = DateTime.Now.AddDays(3).AddHours(12),
                    Price = 600.00m
                },
                new Flight
                {
                    Id = 5,
                    Airline = "Singapore Airlines",
                    Origin = "SIN",
                    Destination = "LAX",
                    DepartureTime = DateTime.Now.AddDays(4),
                    ArrivalTime = DateTime.Now.AddDays(4).AddHours(16),
                    Price = 900.00m
                },
                new Flight
                {
                    Id = 7,
                    Airline = "AIR CANADA",
                    Origin = "BOM",
                    Destination = "YYZ",
                    DepartureTime = DateTime.Now,
                    ArrivalTime = DateTime.Now.AddHours(30),
                    Price = 500.00m
                },
                new Flight
                {
                    Id = 8,
                    Airline = "Emirates",
                    Origin = "DXB",
                    Destination = "JFK",
                    DepartureTime = DateTime.Now.AddDays(1),
                    ArrivalTime = DateTime.Now.AddDays(1).AddHours(14),
                    Price = 800.00m
                },
                new Flight
                {
                    Id = 9,
                    Airline = "British Airways",
                    Origin = "LHR",
                    Destination = "SFO",
                    DepartureTime = DateTime.Now.AddDays(2),
                    ArrivalTime = DateTime.Now.AddDays(2).AddHours(10),
                    Price = 700.00m
                },
                new Flight
                {
                    Id = 10,
                    Airline = "Lufthansa",
                    Origin = "FRA",
                    Destination = "MIA",
                    DepartureTime = DateTime.Now.AddDays(3),
                    ArrivalTime = DateTime.Now.AddDays(3).AddHours(12),
                    Price = 600.00m
                },
                new Flight
                {
                    Id = 11,
                    Airline = "Singapore Airlines",
                    Origin = "SIN",
                    Destination = "LAX",
                    DepartureTime = DateTime.Now.AddDays(4),
                    ArrivalTime = DateTime.Now.AddDays(4).AddHours(16),
                    Price = 900.00m
                },
                new Flight
                {
                    Id = 12,
                    Airline = "AIR CANADA",
                    Origin = "BOM",
                    Destination = "YYZ",
                    DepartureTime = DateTime.Now,
                    ArrivalTime = DateTime.Now.AddHours(30),
                    Price = 500.00m
                },
                new Flight
                {
                    Id = 13,
                    Airline = "Qatar Airways",
                    Origin = "DOH",
                    Destination = "ORD",
                    DepartureTime = DateTime.Now.AddDays(5),
                    ArrivalTime = DateTime.Now.AddDays(5).AddHours(12),
                    Price = 750.00m
                },
                new Flight
                {
                    Id = 14,
                    Airline = "Cathay Pacific",
                    Origin = "HKG",
                    Destination = "LHR",
                    DepartureTime = DateTime.Now.AddDays(6),
                    ArrivalTime = DateTime.Now.AddDays(6).AddHours(13),
                    Price = 650.00m
                },
                new Flight
                {
                    Id = 15,
                    Airline = "Delta Air Lines",
                    Origin = "ATL",
                    Destination = "LGA",
                    DepartureTime = DateTime.Now.AddDays(7),
                    ArrivalTime = DateTime.Now.AddDays(7).AddHours(2),
                    Price = 400.00m
                },
                new Flight
                {
                    Id = 16,
                    Airline = "Virgin Atlantic",
                    Origin = "LAX",
                    Destination = "JFK",
                    DepartureTime = DateTime.Now.AddDays(8),
                    ArrivalTime = DateTime.Now.AddDays(8).AddHours(6),
                    Price = 550.00m
                },

                new Flight
                {
                    Id = 17,
                    Airline = "United Airlines",
                    Origin = "ORD",
                    Destination = "LAX",
                    DepartureTime = DateTime.Now.AddDays(9),
                    ArrivalTime = DateTime.Now.AddDays(9).AddHours(4),
                    Price = 450.00m
                },
                new Flight
                {
                    Id = 18,
                    Airline = "KLM Royal Dutch Airlines",
                    Origin = "AMS",
                    Destination = "JFK",
                    DepartureTime = DateTime.Now.AddDays(10),
                    ArrivalTime = DateTime.Now.AddDays(10).AddHours(8),
                    Price = 700.00m
                },
                new Flight
                {
                    Id = 19,
                    Airline = "American Airlines",
                    Origin = "DFW",
                    Destination = "SFO",
                    DepartureTime = DateTime.Now.AddDays(11),
                    ArrivalTime = DateTime.Now.AddDays(11).AddHours(4),
                    Price = 550.00m
                },
                new Flight
                {
                    Id = 20,
                    Airline = "Air France",
                    Origin = "CDG",
                    Destination = "ATL",
                    DepartureTime = DateTime.Now.AddDays(12),
                    ArrivalTime = DateTime.Now.AddDays(12).AddHours(9),
                    Price = 800.00m
                },
                new Flight
                {
                    Id = 21,
                    Airline = "Qantas",
                    Origin = "SYD",
                    Destination = "LHR",
                    DepartureTime = DateTime.Now.AddDays(13),
                    ArrivalTime = DateTime.Now.AddDays(13).AddHours(24),
                    Price = 1000.00m
                },
                new Flight
                {
                    Id = 22,
                    Airline = "Turkish Airlines",
                    Origin = "IST",
                    Destination = "JFK",
                    DepartureTime = DateTime.Now.AddDays(14),
                    ArrivalTime = DateTime.Now.AddDays(14).AddHours(11),
                    Price = 600.00m
                },
                new Flight
                {
                    Id = 23,
                    Airline = "Japan Airlines",
                    Origin = "NRT",
                    Destination = "LAX",
                    DepartureTime = DateTime.Now.AddDays(15),
                    ArrivalTime = DateTime.Now.AddDays(15).AddHours(10),
                    Price = 850.00m
                },
                new Flight
                {
                    Id = 24,
                    Airline = "Alitalia",
                    Origin = "FCO",
                    Destination = "JFK",
                    DepartureTime = DateTime.Now.AddDays(16),
                    ArrivalTime = DateTime.Now.AddDays(16).AddHours(9),
                    Price = 750.00m
                },
                new Flight
                {
                    Id = 25,
                    Airline = "Southwest Airlines",
                    Origin = "LAS",
                    Destination = "LAX",
                    DepartureTime = DateTime.Now.AddDays(17),
                    ArrivalTime = DateTime.Now.AddDays(17).AddHours(1),
                    Price = 200.00m
                }

                );
            modelBuilder.Entity<Car>().HasData(
                new Car { Id = 1, Brand = "Toyota", Model = "Corolla", Color = "White", DailyRate = 50, IsAvailable = true },
    new Car { Id = 2, Brand = "Honda", Model = "Civic", Color = "Black", DailyRate = 60, IsAvailable = true },
    new Car { Id = 3, Brand = "Ford", Model = "Focus", Color = "Blue", DailyRate = 55, IsAvailable = false },
    new Car { Id = 4, Brand = "Chevrolet", Model = "Malibu", Color = "Silver", DailyRate = 45, IsAvailable = true },
    new Car { Id = 5, Brand = "Nissan", Model = "Altima", Color = "Red", DailyRate = 48, IsAvailable = true },
    new Car { Id = 6, Brand = "BMW", Model = "3 Series", Color = "Gray", DailyRate = 70, IsAvailable = true },
    new Car { Id = 7, Brand = "Mercedes-Benz", Model = "C-Class", Color = "Black", DailyRate = 80, IsAvailable = false },
    new Car { Id = 8, Brand = "Audi", Model = "A4", Color = "White", DailyRate = 75, IsAvailable = true },
    new Car { Id = 9, Brand = "Volkswagen", Model = "Jetta", Color = "Blue", DailyRate = 52, IsAvailable = true },
    new Car { Id = 10, Brand = "Hyundai", Model = "Elantra", Color = "Silver", DailyRate = 47, IsAvailable = true },
    new Car { Id = 11, Brand = "Kia", Model = "Optima", Color = "White", DailyRate = 53, IsAvailable = true },
    new Car { Id = 12, Brand = "Subaru", Model = "Impreza", Color = "Blue", DailyRate = 55, IsAvailable = false },
    new Car { Id = 13, Brand = "Mazda", Model = "Mazda3", Color = "Red", DailyRate = 49, IsAvailable = true },
    new Car { Id = 14, Brand = "Lexus", Model = "IS", Color = "Black", DailyRate = 85, IsAvailable = true },
    new Car { Id = 15, Brand = "Infiniti", Model = "Q50", Color = "Gray", DailyRate = 78, IsAvailable = true },
    new Car { Id = 16, Brand = "Tesla", Model = "Model 3", Color = "White", DailyRate = 90, IsAvailable = true },
    new Car { Id = 17, Brand = "Porsche", Model = "911", Color = "Red", DailyRate = 150, IsAvailable = true },
    new Car { Id = 18, Brand = "Jaguar", Model = "XE", Color = "Blue", DailyRate = 120, IsAvailable = true },
    new Car { Id = 19, Brand = "Land Rover", Model = "Discovery", Color = "Green", DailyRate = 110, IsAvailable = true },
    new Car { Id = 20, Brand = "Volvo", Model = "S60", Color = "Silver", DailyRate = 65, IsAvailable = true },
    new Car { Id = 21, Brand = "Jeep", Model = "Wrangler", Color = "Yellow", DailyRate = 80, IsAvailable = true },
    new Car { Id = 22, Brand = "Toyota", Model = "Camry", Color = "Black", DailyRate = 55, IsAvailable = false },
    new Car { Id = 23, Brand = "Ford", Model = "Fusion", Color = "White", DailyRate = 58, IsAvailable = true },
    new Car { Id = 24, Brand = "Honda", Model = "Accord", Color = "Silver", DailyRate = 63, IsAvailable = true },
    new Car { Id = 25, Brand = "Chevrolet", Model = "Impala", Color = "Black", DailyRate = 70, IsAvailable = true }
                );

        }

    }
}
