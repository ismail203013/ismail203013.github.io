﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp1.Server.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData( 
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 1, "plug", "Plugs", "plugs" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 2, "cable", "Cables", "cables" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[] { 3, "phone", "Phones", "phones" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[] { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "GUARANTEED 55% CHARGE FOR IPHONE/IPAD (DEPENDENT IF CABLE IS POWER DELIVERY COMPATIBLE) • USB Wall Charger: Simply plug into any wall adapter and charge your devices • Ultra-Portable:  Carry your plug everywhere, it is perfect for both homes & offices • Safe & Reliable: Extremely safe & dependable, features Over-current, over-voltage and short-circuit protection • Heat Resistant: It is made using fireproof ABS plastic which has a high melting and heating point, protecting your connected devices. • Smart Current Detection: Smart current detection which enables swift & safe charging Output – 20W Fast Charging USB port The built-in safety systems protect your devices from overcharging and short-circuit. With Smart IC functionality, it recognizes the attached gadget and automatically delivers the correct amount of power.", "https://cdn.shopify.com/s/files/1/0314/9738/8165/products/DEV-20WPD-PLUG-WHT_md_720x.jpg?v=1612450879", false, false, 12.99m, 9.99m, "Devia – 20W Type C Power Delivery 3-Pin UK Charging Plug – White" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[] { 2, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guaranteed 50% charge in 30 minutes charged for all iOS devices (This cable can only provide this result along with using the Power Delivery Plug) – Power Delivery: Use this cable with your USB-C Power Delivery charger (including Apple 29W, 30W, 61W, or 87W USB-C Power Adapter) to charge your iOS device, and access fast charging for iPhone 8, 8 Plus, X, XS, XR, XS Max, iPads, and more. – Staying Power: Lasts 30× longer than ordinary cables. Proven in a laboratory environment to withstand 30,000 bends. – MFi: MFi certification and strict quality testing ensure your Apple devices are charged safely, at their fastest possible speed. – With this Lightning to USB C cable, you can not only use a PD Power Adapter but also the mobile power supply to recharge your iPhone. It’s worth mentioning that it also supports fast charge and data transfer your iPhone from a USB-C laptop or desktop directly. And the data transfer rates up to 480Mbps, 1G large files will be finished in 25s. Perfect choice to take advantage of fast charging with existing USB-C PD charger for your newest Apple devices.", "https://armafone.com/wp-content/uploads/2020/10/Devia-1.5m-18W-Power-Delivery-Type-C-to-MFI-Lightning-Cable-White-1-1.jpg", false, false, 0m, 7.45m, "Devia – 1.5m (18W) Power Delivery – Type C to MFI Lightning Cable – White" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
