using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Projekt.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Owners (Name,Surname,Phone) VALUES ('Jacek','Kempa','123456789')");
            migrationBuilder.Sql("INSERT INTO Owners (Name,Surname,Phone) VALUES ('Kamil','Nowak','224667885')");
            migrationBuilder.Sql("INSERT INTO Owners (Name,Surname,Phone) VALUES ('Leszek','Len','2213344557')");

            migrationBuilder.Sql("INSERT INTO Addresses (Street,City) VALUES ('Rzeszow','Lwowska')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street,City) VALUES ('Warszawa','Pilsudzkiego')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street,City) VALUES ('Wroclaw','Warszawska')");

            migrationBuilder.Sql("INSERT INTO Properties (Type,Description,Rooms,Area,Washer,Refrigerator,Iron,AddressId,OwnerId) VALUES (0,'Opis1',7,160,1,1,1,1,1)");
            migrationBuilder.Sql("INSERT INTO Properties (Type,Description,Rooms,Area,Washer,Refrigerator,Iron,AddressId,OwnerId) VALUES (0,'Opis2',3,120,1,0,1,2,2)");
            migrationBuilder.Sql("INSERT INTO Properties (Type,Description,Rooms,Area,Washer,Refrigerator,Iron,AddressId,OwnerId) VALUES (1,'Opis3',2,70,1,1,0,3,3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Owners");
            migrationBuilder.Sql("DELETE FROM Addresses");
            migrationBuilder.Sql("DELETE FROM Properties");
        }
    }
}
