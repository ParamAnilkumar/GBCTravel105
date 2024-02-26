using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GBCTravel105.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bookingtype = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    BookingDate = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DailyRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Airline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePerNight = table.Column<float>(type: "real", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingDate", "bookingtype", "price" },
                values: new object[] { 1, new DateOnly(2024, 2, 25), "Car", 20.0 });

            migrationBuilder.InsertData(
                table: "Car",
                columns: new[] { "Id", "Brand", "Color", "DailyRate", "IsAvailable", "Model" },
                values: new object[,]
                {
                    { 1, "Toyota", "White", 50m, true, "Corolla" },
                    { 2, "Honda", "Black", 60m, true, "Civic" },
                    { 3, "Ford", "Blue", 55m, false, "Focus" },
                    { 4, "Chevrolet", "Silver", 45m, true, "Malibu" },
                    { 5, "Nissan", "Red", 48m, true, "Altima" },
                    { 6, "BMW", "Gray", 70m, true, "3 Series" },
                    { 7, "Mercedes-Benz", "Black", 80m, false, "C-Class" },
                    { 8, "Audi", "White", 75m, true, "A4" },
                    { 9, "Volkswagen", "Blue", 52m, true, "Jetta" },
                    { 10, "Hyundai", "Silver", 47m, true, "Elantra" },
                    { 11, "Kia", "White", 53m, true, "Optima" },
                    { 12, "Subaru", "Blue", 55m, false, "Impreza" },
                    { 13, "Mazda", "Red", 49m, true, "Mazda3" },
                    { 14, "Lexus", "Black", 85m, true, "IS" },
                    { 15, "Infiniti", "Gray", 78m, true, "Q50" },
                    { 16, "Tesla", "White", 90m, true, "Model 3" },
                    { 17, "Porsche", "Red", 150m, true, "911" },
                    { 18, "Jaguar", "Blue", 120m, true, "XE" },
                    { 19, "Land Rover", "Green", 110m, true, "Discovery" },
                    { 20, "Volvo", "Silver", 65m, true, "S60" },
                    { 21, "Jeep", "Yellow", 80m, true, "Wrangler" },
                    { 22, "Toyota", "Black", 55m, false, "Camry" },
                    { 23, "Ford", "White", 58m, true, "Fusion" },
                    { 24, "Honda", "Silver", 63m, true, "Accord" },
                    { 25, "Chevrolet", "Black", 70m, true, "Impala" }
                });

            migrationBuilder.InsertData(
                table: "Flight",
                columns: new[] { "Id", "Airline", "ArrivalTime", "DepartureTime", "Destination", "Origin", "Price" },
                values: new object[,]
                {
                    { 1, "AIR CANADA", new DateTime(2024, 2, 27, 0, 53, 33, 940, DateTimeKind.Local).AddTicks(6906), new DateTime(2024, 2, 25, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6904), "YYZ", "BOM", 600.00m },
                    { 2, "Emirates", new DateTime(2024, 2, 27, 8, 53, 33, 940, DateTimeKind.Local).AddTicks(6920), new DateTime(2024, 2, 26, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6917), "JFK", "DXB", 800.00m },
                    { 3, "British Airways", new DateTime(2024, 2, 28, 4, 53, 33, 940, DateTimeKind.Local).AddTicks(6924), new DateTime(2024, 2, 27, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6922), "SFO", "LHR", 700.00m },
                    { 4, "Lufthansa", new DateTime(2024, 2, 29, 6, 53, 33, 940, DateTimeKind.Local).AddTicks(6927), new DateTime(2024, 2, 28, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6926), "MIA", "FRA", 600.00m },
                    { 5, "Singapore Airlines", new DateTime(2024, 3, 1, 10, 53, 33, 940, DateTimeKind.Local).AddTicks(6930), new DateTime(2024, 2, 29, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6929), "LAX", "SIN", 900.00m },
                    { 6, "AIR CANADA", new DateTime(2024, 2, 27, 0, 53, 33, 940, DateTimeKind.Local).AddTicks(6914), new DateTime(2024, 2, 25, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6913), "YYZ", "BOM", 500.00m },
                    { 7, "AIR CANADA", new DateTime(2024, 2, 27, 0, 53, 33, 940, DateTimeKind.Local).AddTicks(6934), new DateTime(2024, 2, 25, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6933), "YYZ", "BOM", 500.00m },
                    { 8, "Emirates", new DateTime(2024, 2, 27, 8, 53, 33, 940, DateTimeKind.Local).AddTicks(6937), new DateTime(2024, 2, 26, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6936), "JFK", "DXB", 800.00m },
                    { 9, "British Airways", new DateTime(2024, 2, 28, 4, 53, 33, 940, DateTimeKind.Local).AddTicks(6940), new DateTime(2024, 2, 27, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6939), "SFO", "LHR", 700.00m },
                    { 10, "Lufthansa", new DateTime(2024, 2, 29, 6, 53, 33, 940, DateTimeKind.Local).AddTicks(6944), new DateTime(2024, 2, 28, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6942), "MIA", "FRA", 600.00m },
                    { 11, "Singapore Airlines", new DateTime(2024, 3, 1, 10, 53, 33, 940, DateTimeKind.Local).AddTicks(6947), new DateTime(2024, 2, 29, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6945), "LAX", "SIN", 900.00m },
                    { 12, "AIR CANADA", new DateTime(2024, 2, 27, 0, 53, 33, 940, DateTimeKind.Local).AddTicks(6950), new DateTime(2024, 2, 25, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6949), "YYZ", "BOM", 500.00m },
                    { 13, "Qatar Airways", new DateTime(2024, 3, 2, 6, 53, 33, 940, DateTimeKind.Local).AddTicks(6953), new DateTime(2024, 3, 1, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6952), "ORD", "DOH", 750.00m },
                    { 14, "Cathay Pacific", new DateTime(2024, 3, 3, 7, 53, 33, 940, DateTimeKind.Local).AddTicks(6956), new DateTime(2024, 3, 2, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6955), "LHR", "HKG", 650.00m },
                    { 15, "Delta Air Lines", new DateTime(2024, 3, 3, 20, 53, 33, 940, DateTimeKind.Local).AddTicks(6959), new DateTime(2024, 3, 3, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6958), "LGA", "ATL", 400.00m },
                    { 16, "Virgin Atlantic", new DateTime(2024, 3, 5, 0, 53, 33, 940, DateTimeKind.Local).AddTicks(6963), new DateTime(2024, 3, 4, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6961), "JFK", "LAX", 550.00m },
                    { 17, "United Airlines", new DateTime(2024, 3, 5, 22, 53, 33, 940, DateTimeKind.Local).AddTicks(6967), new DateTime(2024, 3, 5, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6965), "LAX", "ORD", 450.00m },
                    { 18, "KLM Royal Dutch Airlines", new DateTime(2024, 3, 7, 2, 53, 33, 940, DateTimeKind.Local).AddTicks(6971), new DateTime(2024, 3, 6, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6969), "JFK", "AMS", 700.00m },
                    { 19, "American Airlines", new DateTime(2024, 3, 7, 22, 53, 33, 940, DateTimeKind.Local).AddTicks(6975), new DateTime(2024, 3, 7, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6973), "SFO", "DFW", 550.00m },
                    { 20, "Air France", new DateTime(2024, 3, 9, 3, 53, 33, 940, DateTimeKind.Local).AddTicks(6978), new DateTime(2024, 3, 8, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6977), "ATL", "CDG", 800.00m },
                    { 21, "Qantas", new DateTime(2024, 3, 10, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6981), new DateTime(2024, 3, 9, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6980), "LHR", "SYD", 1000.00m },
                    { 22, "Turkish Airlines", new DateTime(2024, 3, 11, 5, 53, 33, 940, DateTimeKind.Local).AddTicks(6984), new DateTime(2024, 3, 10, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6983), "JFK", "IST", 600.00m },
                    { 23, "Japan Airlines", new DateTime(2024, 3, 12, 4, 53, 33, 940, DateTimeKind.Local).AddTicks(6987), new DateTime(2024, 3, 11, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6986), "LAX", "NRT", 850.00m },
                    { 24, "Alitalia", new DateTime(2024, 3, 13, 3, 53, 33, 940, DateTimeKind.Local).AddTicks(6991), new DateTime(2024, 3, 12, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6989), "JFK", "FCO", 750.00m },
                    { 25, "Southwest Airlines", new DateTime(2024, 3, 13, 19, 53, 33, 940, DateTimeKind.Local).AddTicks(6994), new DateTime(2024, 3, 13, 18, 53, 33, 940, DateTimeKind.Local).AddTicks(6993), "LAX", "LAS", 200.00m }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "ImageUrl", "Location", "Name", "PricePerNight", "RoomNumber", "status" },
                values: new object[,]
                {
                    { 1, "https://images.pexels.com/photos/16104977/pexels-photo-16104977/free-photo-of-facade-of-hotel-in-city.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Surat", "Sobhagya", 2333.44f, 0, true },
                    { 2, "https://images.pexels.com/photos/59924/pexels-photo-59924.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Dubai", "Grand Hyatt", 350f, 0, true },
                    { 3, "https://images.pexels.com/photos/1813467/pexels-photo-1813467.jpeg?auto=compress&cs=tinysrgb&w=400", "New York", "The Ritz-Carlton", 550f, 0, true },
                    { 4, "https://images.pexels.com/photos/2957461/pexels-photo-2957461.jpeg?auto=compress&cs=tinysrgb&w=400", "Paris", "Mandarin Oriental", 700f, 0, true },
                    { 5, "", "Mumbai", "Taj Mahal Palace", 450f, 0, true },
                    { 6, "", "Dubai", "Burj Al Arab", 1500f, 0, true },
                    { 7, "", "Dubai", "Atlantis The Palm", 600f, 0, true },
                    { 8, "", "Singapore", "Marina Bay Sands", 800f, 0, true },
                    { 9, "", "New York", "The Plaza Hotel", 650f, 0, true },
                    { 10, "", "Berlin", "Hotel Adlon Kempinski", 400f, 0, true },
                    { 11, "", "London", "The Langham", 600f, 0, true },
                    { 12, "", "New York", "Waldorf Astoria", 700f, 0, true },
                    { 13, "", "Paris", "Four Seasons Hotel", 800f, 0, true },
                    { 14, "", "Hong Kong", "The Peninsula", 900f, 0, true },
                    { 15, "", "Las Vegas", "Bellagio", 600f, 0, true },
                    { 16, "", "Singapore", "Raffles Hotel", 750f, 0, true },
                    { 17, "", "San Diego", "Hotel del Coronado", 400f, 0, true },
                    { 18, "", "Las Vegas", "MGM Grand", 550f, 0, true },
                    { 19, "", "Bangkok", "Shangri-La Hotel", 650f, 0, true },
                    { 20, "", "Los Angeles", "Ritz-Carlton", 700f, 0, true },
                    { 21, "", "Sydney", "InterContinental", 800f, 0, true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "Hotel");
        }
    }
}
