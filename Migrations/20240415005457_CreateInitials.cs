using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GBCTravel105.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Booking",
                columns: new[] { "Id", "BookingDate", "bookingtype", "price" },
                values: new object[] { 1, new DateOnly(2024, 4, 14), "Car", 20.0 });

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
                    { 1, "AIR CANADA", new DateTime(2024, 4, 16, 2, 54, 56, 753, DateTimeKind.Local).AddTicks(6723), new DateTime(2024, 4, 14, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6719), "YYZ", "BOM", 600.00m },
                    { 2, "Emirates", new DateTime(2024, 4, 16, 10, 54, 56, 753, DateTimeKind.Local).AddTicks(6745), new DateTime(2024, 4, 15, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6740), "JFK", "DXB", 800.00m },
                    { 3, "British Airways", new DateTime(2024, 4, 17, 6, 54, 56, 753, DateTimeKind.Local).AddTicks(6751), new DateTime(2024, 4, 16, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6748), "SFO", "LHR", 700.00m },
                    { 4, "Lufthansa", new DateTime(2024, 4, 18, 8, 54, 56, 753, DateTimeKind.Local).AddTicks(6756), new DateTime(2024, 4, 17, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6754), "MIA", "FRA", 600.00m },
                    { 5, "Singapore Airlines", new DateTime(2024, 4, 19, 12, 54, 56, 753, DateTimeKind.Local).AddTicks(6762), new DateTime(2024, 4, 18, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6759), "LAX", "SIN", 900.00m },
                    { 6, "AIR CANADA", new DateTime(2024, 4, 16, 2, 54, 56, 753, DateTimeKind.Local).AddTicks(6736), new DateTime(2024, 4, 14, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6734), "YYZ", "BOM", 500.00m },
                    { 7, "AIR CANADA", new DateTime(2024, 4, 16, 2, 54, 56, 753, DateTimeKind.Local).AddTicks(6767), new DateTime(2024, 4, 14, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6765), "YYZ", "BOM", 500.00m },
                    { 8, "Emirates", new DateTime(2024, 4, 16, 10, 54, 56, 753, DateTimeKind.Local).AddTicks(6843), new DateTime(2024, 4, 15, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6840), "JFK", "DXB", 800.00m },
                    { 9, "British Airways", new DateTime(2024, 4, 17, 6, 54, 56, 753, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 4, 16, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6847), "SFO", "LHR", 700.00m },
                    { 10, "Lufthansa", new DateTime(2024, 4, 18, 8, 54, 56, 753, DateTimeKind.Local).AddTicks(6854), new DateTime(2024, 4, 17, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6852), "MIA", "FRA", 600.00m },
                    { 11, "Singapore Airlines", new DateTime(2024, 4, 19, 12, 54, 56, 753, DateTimeKind.Local).AddTicks(6859), new DateTime(2024, 4, 18, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6857), "LAX", "SIN", 900.00m },
                    { 12, "AIR CANADA", new DateTime(2024, 4, 16, 2, 54, 56, 753, DateTimeKind.Local).AddTicks(6865), new DateTime(2024, 4, 14, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6863), "YYZ", "BOM", 500.00m },
                    { 13, "Qatar Airways", new DateTime(2024, 4, 20, 8, 54, 56, 753, DateTimeKind.Local).AddTicks(6870), new DateTime(2024, 4, 19, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6868), "ORD", "DOH", 750.00m },
                    { 14, "Cathay Pacific", new DateTime(2024, 4, 21, 9, 54, 56, 753, DateTimeKind.Local).AddTicks(6875), new DateTime(2024, 4, 20, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6873), "LHR", "HKG", 650.00m },
                    { 15, "Delta Air Lines", new DateTime(2024, 4, 21, 22, 54, 56, 753, DateTimeKind.Local).AddTicks(6881), new DateTime(2024, 4, 21, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6879), "LGA", "ATL", 400.00m },
                    { 16, "Virgin Atlantic", new DateTime(2024, 4, 23, 2, 54, 56, 753, DateTimeKind.Local).AddTicks(6886), new DateTime(2024, 4, 22, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6884), "JFK", "LAX", 550.00m },
                    { 17, "United Airlines", new DateTime(2024, 4, 24, 0, 54, 56, 753, DateTimeKind.Local).AddTicks(6891), new DateTime(2024, 4, 23, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6889), "LAX", "ORD", 450.00m },
                    { 18, "KLM Royal Dutch Airlines", new DateTime(2024, 4, 25, 4, 54, 56, 753, DateTimeKind.Local).AddTicks(6897), new DateTime(2024, 4, 24, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6895), "JFK", "AMS", 700.00m },
                    { 19, "American Airlines", new DateTime(2024, 4, 26, 0, 54, 56, 753, DateTimeKind.Local).AddTicks(6902), new DateTime(2024, 4, 25, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6900), "SFO", "DFW", 550.00m },
                    { 20, "Air France", new DateTime(2024, 4, 27, 5, 54, 56, 753, DateTimeKind.Local).AddTicks(6908), new DateTime(2024, 4, 26, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6906), "ATL", "CDG", 800.00m },
                    { 21, "Qantas", new DateTime(2024, 4, 28, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6913), new DateTime(2024, 4, 27, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6911), "LHR", "SYD", 1000.00m },
                    { 22, "Turkish Airlines", new DateTime(2024, 4, 29, 7, 54, 56, 753, DateTimeKind.Local).AddTicks(6918), new DateTime(2024, 4, 28, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6916), "JFK", "IST", 600.00m },
                    { 23, "Japan Airlines", new DateTime(2024, 4, 30, 6, 54, 56, 753, DateTimeKind.Local).AddTicks(6924), new DateTime(2024, 4, 29, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6922), "LAX", "NRT", 850.00m },
                    { 24, "Alitalia", new DateTime(2024, 5, 1, 5, 54, 56, 753, DateTimeKind.Local).AddTicks(6929), new DateTime(2024, 4, 30, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6927), "JFK", "FCO", 750.00m },
                    { 25, "Southwest Airlines", new DateTime(2024, 5, 1, 21, 54, 56, 753, DateTimeKind.Local).AddTicks(6934), new DateTime(2024, 5, 1, 20, 54, 56, 753, DateTimeKind.Local).AddTicks(6932), "LAX", "LAS", 200.00m }
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
