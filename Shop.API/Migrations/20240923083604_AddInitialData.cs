using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Shop.API.Migrations
{
    /// <inheritdoc />
    public partial class AddInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "CreatedDate", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "4135803517878", new DateTime(2024, 2, 5, 0, 45, 36, 16, DateTimeKind.Local).AddTicks(8669), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Wooden Chair", 369.23094862803396 },
                    { 2, "8030065369189", new DateTime(2024, 8, 17, 10, 8, 58, 731, DateTimeKind.Local).AddTicks(5061), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handcrafted Steel Shoes", 136.24926863901749 },
                    { 3, "7003075034317", new DateTime(2023, 12, 6, 12, 19, 46, 726, DateTimeKind.Local).AddTicks(9), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handmade Granite Table", 654.6719201783053 },
                    { 4, "5416944442618", new DateTime(2024, 7, 7, 14, 35, 37, 387, DateTimeKind.Local).AddTicks(4946), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handmade Wooden Table", 152.71991566741835 },
                    { 5, "6506593104131", new DateTime(2024, 1, 8, 3, 59, 57, 39, DateTimeKind.Local).AddTicks(6582), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Steel Salad", 746.66057369143732 },
                    { 6, "9006862241217", new DateTime(2024, 7, 22, 4, 38, 45, 363, DateTimeKind.Local).AddTicks(3935), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Handcrafted Rubber Bike", 917.39893700526977 },
                    { 7, "2881384031594", new DateTime(2024, 2, 20, 17, 51, 9, 643, DateTimeKind.Local).AddTicks(170), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Unbranded Steel Car", 805.77746175126049 },
                    { 8, "0963435288224", new DateTime(2024, 5, 15, 14, 39, 31, 489, DateTimeKind.Local).AddTicks(2883), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Tasty Plastic Cheese", 914.85762121428627 },
                    { 9, "4771273064520", new DateTime(2023, 11, 4, 17, 59, 59, 152, DateTimeKind.Local).AddTicks(7651), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handcrafted Fresh Sausages", 963.08984293839421 },
                    { 10, "9845610580792", new DateTime(2024, 8, 27, 5, 8, 33, 626, DateTimeKind.Local).AddTicks(2523), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Fantastic Frozen Gloves", 54.201508391742365 },
                    { 11, "9878036066984", new DateTime(2024, 6, 25, 18, 16, 54, 875, DateTimeKind.Local).AddTicks(2081), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Generic Steel Ball", 372.33782553641959 },
                    { 12, "5916169237490", new DateTime(2024, 7, 3, 23, 21, 10, 51, DateTimeKind.Local).AddTicks(1976), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonomic Rubber Car", 981.4625697482669 },
                    { 13, "0081854460875", new DateTime(2024, 6, 3, 2, 33, 12, 419, DateTimeKind.Local).AddTicks(8891), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Generic Steel Pizza", 318.46874374359322 },
                    { 14, "9361989867338", new DateTime(2023, 11, 28, 3, 26, 19, 286, DateTimeKind.Local).AddTicks(9372), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Small Metal Sausages", 682.18336528967291 },
                    { 15, "2406179936436", new DateTime(2024, 6, 18, 9, 51, 56, 845, DateTimeKind.Local).AddTicks(4992), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Fantastic Soft Pants", 12.461428898601527 },
                    { 16, "5810198703141", new DateTime(2023, 10, 6, 8, 59, 23, 910, DateTimeKind.Local).AddTicks(9226), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Gorgeous Frozen Towels", 894.2250182457384 },
                    { 17, "4328104333418", new DateTime(2024, 5, 15, 13, 55, 10, 534, DateTimeKind.Local).AddTicks(2892), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Tasty Steel Cheese", 715.82718336015341 },
                    { 18, "7220837679658", new DateTime(2024, 5, 12, 15, 26, 18, 637, DateTimeKind.Local).AddTicks(451), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Gorgeous Granite Cheese", 790.25541884929657 },
                    { 19, "7671585538993", new DateTime(2023, 10, 6, 12, 22, 9, 667, DateTimeKind.Local).AddTicks(2813), "The Football Is Good For Training And Recreational Purposes", "Sleek Rubber Chicken", 121.02393029864129 },
                    { 20, "0358152578992", new DateTime(2024, 2, 27, 23, 21, 15, 641, DateTimeKind.Local).AddTicks(3368), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Intelligent Wooden Salad", 992.13880285766857 },
                    { 21, "4664420868945", new DateTime(2024, 5, 7, 15, 18, 15, 238, DateTimeKind.Local).AddTicks(3083), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handcrafted Wooden Sausages", 43.559941660407901 },
                    { 22, "0951801753339", new DateTime(2023, 12, 19, 1, 32, 32, 966, DateTimeKind.Local).AddTicks(3523), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Granite Car", 655.64677436353952 },
                    { 23, "8592729452441", new DateTime(2024, 4, 19, 3, 22, 58, 386, DateTimeKind.Local).AddTicks(9498), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Small Wooden Car", 477.23973976924998 },
                    { 24, "5286377652096", new DateTime(2024, 5, 20, 22, 4, 19, 477, DateTimeKind.Local).AddTicks(1677), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Sleek Steel Shirt", 881.80228072814759 },
                    { 25, "8812144820985", new DateTime(2024, 6, 6, 0, 36, 33, 45, DateTimeKind.Local).AddTicks(1000), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Frozen Mouse", 231.27664836648694 },
                    { 26, "5122506636813", new DateTime(2024, 3, 31, 13, 51, 27, 86, DateTimeKind.Local).AddTicks(7724), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Wooden Chair", 481.1636281261051 },
                    { 27, "9203244677972", new DateTime(2023, 12, 21, 19, 18, 34, 85, DateTimeKind.Local).AddTicks(6575), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Gorgeous Plastic Chips", 603.96496611319719 },
                    { 28, "7631650700663", new DateTime(2024, 3, 15, 3, 16, 17, 19, DateTimeKind.Local).AddTicks(4020), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Incredible Fresh Bacon", 639.02985308320717 },
                    { 29, "0198782966956", new DateTime(2024, 6, 7, 19, 20, 18, 557, DateTimeKind.Local).AddTicks(7182), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Soft Computer", 68.019930013930392 },
                    { 30, "7865344300260", new DateTime(2023, 10, 3, 3, 57, 26, 221, DateTimeKind.Local).AddTicks(635), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handcrafted Rubber Bike", 193.52063540160685 },
                    { 31, "0984868484793", new DateTime(2024, 8, 29, 0, 4, 55, 4, DateTimeKind.Local).AddTicks(7226), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Handcrafted Concrete Tuna", 702.7774551775201 },
                    { 32, "5585438269625", new DateTime(2024, 6, 8, 14, 32, 5, 727, DateTimeKind.Local).AddTicks(1595), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Gorgeous Wooden Fish", 313.11708069225637 },
                    { 33, "1399786951996", new DateTime(2024, 3, 16, 9, 29, 47, 912, DateTimeKind.Local).AddTicks(6800), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Handcrafted Frozen Keyboard", 174.63402698684206 },
                    { 34, "6545660875116", new DateTime(2023, 10, 13, 16, 36, 55, 608, DateTimeKind.Local).AddTicks(5311), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Intelligent Plastic Chair", 98.709883321407204 },
                    { 35, "2579847727442", new DateTime(2023, 10, 31, 22, 41, 2, 474, DateTimeKind.Local).AddTicks(7167), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Unbranded Wooden Pizza", 614.77223599179285 },
                    { 36, "7673981084104", new DateTime(2023, 11, 20, 18, 33, 0, 658, DateTimeKind.Local).AddTicks(6711), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Gorgeous Rubber Bacon", 467.51950786193811 },
                    { 37, "3770783333684", new DateTime(2024, 2, 16, 15, 52, 1, 433, DateTimeKind.Local).AddTicks(6529), "The Football Is Good For Training And Recreational Purposes", "Handcrafted Rubber Shirt", 759.76310902077853 },
                    { 38, "2869876351887", new DateTime(2023, 11, 28, 8, 37, 45, 315, DateTimeKind.Local).AddTicks(3101), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rustic Granite Shoes", 82.488060594763638 },
                    { 39, "9788064749806", new DateTime(2024, 2, 22, 21, 56, 32, 462, DateTimeKind.Local).AddTicks(6584), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Granite Chair", 403.20283056246245 },
                    { 40, "8499343245513", new DateTime(2024, 5, 11, 23, 53, 57, 515, DateTimeKind.Local).AddTicks(5405), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Incredible Rubber Soap", 143.57838060640654 },
                    { 41, "1489403745555", new DateTime(2024, 6, 24, 9, 50, 8, 217, DateTimeKind.Local).AddTicks(5750), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Awesome Soft Fish", 589.62004119838593 },
                    { 42, "8933482922527", new DateTime(2024, 6, 15, 20, 27, 27, 535, DateTimeKind.Local).AddTicks(9533), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Intelligent Cotton Tuna", 145.62097877432637 },
                    { 43, "0809669868323", new DateTime(2023, 12, 8, 23, 46, 41, 293, DateTimeKind.Local).AddTicks(3731), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Refined Soft Bike", 422.75872662419391 },
                    { 44, "9790757012272", new DateTime(2023, 12, 12, 21, 42, 30, 356, DateTimeKind.Local).AddTicks(6794), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handmade Cotton Bacon", 925.07466158181182 },
                    { 45, "9836461369483", new DateTime(2023, 11, 20, 16, 21, 27, 353, DateTimeKind.Local).AddTicks(529), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Small Soft Tuna", 613.52794189542897 },
                    { 46, "8915255768136", new DateTime(2024, 3, 25, 5, 17, 34, 341, DateTimeKind.Local).AddTicks(3327), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Practical Frozen Computer", 280.04287884945182 },
                    { 47, "2233848753373", new DateTime(2023, 11, 28, 16, 34, 43, 915, DateTimeKind.Local).AddTicks(7092), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Rustic Wooden Mouse", 883.87747143203273 },
                    { 48, "1467160313439", new DateTime(2024, 1, 10, 16, 16, 9, 115, DateTimeKind.Local).AddTicks(4431), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Handcrafted Metal Mouse", 828.79833626691175 },
                    { 49, "2506649138046", new DateTime(2024, 2, 23, 23, 52, 34, 425, DateTimeKind.Local).AddTicks(8628), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Handcrafted Rubber Salad", 840.99831578927035 },
                    { 50, "3416252522677", new DateTime(2024, 7, 12, 22, 12, 6, 315, DateTimeKind.Local).AddTicks(8129), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Incredible Plastic Shoes", 36.028621714575507 },
                    { 51, "5582893227719", new DateTime(2023, 9, 28, 2, 55, 16, 565, DateTimeKind.Local).AddTicks(492), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Unbranded Soft Fish", 903.58063168198828 },
                    { 52, "8524302656618", new DateTime(2024, 1, 30, 7, 59, 37, 758, DateTimeKind.Local).AddTicks(694), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Gorgeous Rubber Computer", 540.61067063902078 },
                    { 53, "6161303580232", new DateTime(2024, 8, 23, 2, 59, 37, 567, DateTimeKind.Local).AddTicks(1446), "The Football Is Good For Training And Recreational Purposes", "Refined Cotton Chair", 861.54531531946054 },
                    { 54, "1118914751082", new DateTime(2023, 12, 28, 14, 33, 40, 460, DateTimeKind.Local).AddTicks(1431), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Ergonomic Cotton Shoes", 828.60533404471596 },
                    { 55, "6721181141552", new DateTime(2023, 12, 30, 6, 37, 50, 357, DateTimeKind.Local).AddTicks(3361), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Tasty Cotton Computer", 481.52617973299988 },
                    { 56, "3815754149328", new DateTime(2024, 9, 21, 22, 38, 14, 95, DateTimeKind.Local).AddTicks(6670), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Intelligent Steel Computer", 899.10140674240017 },
                    { 57, "0993677210387", new DateTime(2023, 11, 19, 17, 8, 4, 718, DateTimeKind.Local).AddTicks(5375), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Tasty Rubber Chips", 778.88751567056761 },
                    { 58, "2106693181151", new DateTime(2023, 10, 11, 15, 15, 40, 646, DateTimeKind.Local).AddTicks(3669), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Generic Steel Tuna", 711.08651894381569 },
                    { 59, "8013854475179", new DateTime(2024, 7, 8, 8, 49, 5, 421, DateTimeKind.Local).AddTicks(7419), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Cotton Chips", 99.117536574656867 },
                    { 60, "0329049506060", new DateTime(2024, 3, 26, 14, 51, 29, 480, DateTimeKind.Local).AddTicks(5999), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", "Fantastic Plastic Sausages", 744.52879473079406 },
                    { 61, "4835221701988", new DateTime(2024, 6, 12, 18, 58, 13, 465, DateTimeKind.Local).AddTicks(4903), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Unbranded Granite Keyboard", 814.83999403465532 },
                    { 62, "6807424731022", new DateTime(2024, 7, 13, 7, 56, 48, 260, DateTimeKind.Local).AddTicks(496), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Small Steel Cheese", 910.83703496858334 },
                    { 63, "2500724862307", new DateTime(2024, 1, 30, 20, 31, 49, 753, DateTimeKind.Local).AddTicks(406), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Rubber Soap", 494.04385483918895 },
                    { 64, "6741048067986", new DateTime(2024, 6, 27, 8, 35, 11, 868, DateTimeKind.Local).AddTicks(7251), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Frozen Cheese", 472.22565057604834 },
                    { 65, "7507355242534", new DateTime(2024, 6, 14, 2, 51, 43, 987, DateTimeKind.Local).AddTicks(2964), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Granite Keyboard", 488.74166859907177 },
                    { 66, "4145275688969", new DateTime(2024, 2, 26, 8, 59, 6, 650, DateTimeKind.Local).AddTicks(6542), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Practical Rubber Soap", 974.50585199683246 },
                    { 67, "9848580553544", new DateTime(2024, 7, 1, 3, 3, 26, 986, DateTimeKind.Local).AddTicks(3105), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Sleek Concrete Soap", 54.502270389582158 },
                    { 68, "8132167627799", new DateTime(2024, 8, 4, 8, 18, 6, 278, DateTimeKind.Local).AddTicks(8105), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Generic Metal Fish", 712.63407267333662 },
                    { 69, "3556572214637", new DateTime(2023, 10, 3, 13, 11, 23, 376, DateTimeKind.Local).AddTicks(3737), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Handcrafted Cotton Fish", 684.43849226619977 },
                    { 70, "5667185285186", new DateTime(2024, 8, 17, 21, 55, 51, 827, DateTimeKind.Local).AddTicks(5114), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Refined Soft Salad", 716.42358648237939 },
                    { 71, "7155095308883", new DateTime(2024, 7, 18, 16, 11, 57, 148, DateTimeKind.Local).AddTicks(8432), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Sleek Frozen Towels", 382.32254860378919 },
                    { 72, "4646139602317", new DateTime(2024, 5, 4, 4, 58, 30, 708, DateTimeKind.Local).AddTicks(6133), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Intelligent Frozen Table", 142.4809324873988 },
                    { 73, "4957188649391", new DateTime(2023, 11, 7, 4, 42, 14, 284, DateTimeKind.Local).AddTicks(9043), "The Football Is Good For Training And Recreational Purposes", "Fantastic Cotton Tuna", 204.71544998731252 },
                    { 74, "7001638309445", new DateTime(2024, 4, 16, 18, 14, 47, 620, DateTimeKind.Local).AddTicks(5299), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Handcrafted Cotton Salad", 124.32340843059281 },
                    { 75, "5755849031368", new DateTime(2023, 12, 31, 17, 53, 11, 91, DateTimeKind.Local).AddTicks(6167), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Awesome Steel Table", 42.994053510480583 },
                    { 76, "4231878819487", new DateTime(2023, 10, 15, 9, 5, 48, 199, DateTimeKind.Local).AddTicks(1059), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Sleek Concrete Fish", 909.74176722147592 },
                    { 77, "2116260793298", new DateTime(2024, 7, 28, 2, 46, 0, 195, DateTimeKind.Local).AddTicks(5241), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Practical Rubber Bike", 364.24190835852266 },
                    { 78, "8387792955193", new DateTime(2024, 9, 9, 20, 42, 37, 787, DateTimeKind.Local).AddTicks(6832), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Handmade Rubber Bacon", 17.030882716658933 },
                    { 79, "0796118461870", new DateTime(2024, 7, 9, 13, 41, 54, 686, DateTimeKind.Local).AddTicks(2963), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Sleek Wooden Salad", 500.19197839181498 },
                    { 80, "5441420559375", new DateTime(2023, 11, 12, 23, 6, 41, 965, DateTimeKind.Local).AddTicks(1524), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Ergonomic Cotton Cheese", 388.41101128254599 },
                    { 81, "8127822017206", new DateTime(2024, 3, 11, 21, 17, 54, 757, DateTimeKind.Local).AddTicks(3457), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", "Gorgeous Concrete Salad", 790.18422065870107 },
                    { 82, "2836556819357", new DateTime(2024, 3, 12, 8, 17, 36, 290, DateTimeKind.Local).AddTicks(4119), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", "Gorgeous Wooden Keyboard", 359.85921197657439 },
                    { 83, "7852841324400", new DateTime(2024, 2, 20, 18, 38, 14, 34, DateTimeKind.Local).AddTicks(7415), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Incredible Plastic Keyboard", 918.91680194992421 },
                    { 84, "9256100365292", new DateTime(2023, 12, 24, 6, 42, 50, 635, DateTimeKind.Local).AddTicks(5980), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", "Handmade Frozen Mouse", 609.57094184428968 },
                    { 85, "4098423130363", new DateTime(2024, 2, 4, 3, 11, 1, 932, DateTimeKind.Local).AddTicks(476), "The Football Is Good For Training And Recreational Purposes", "Fantastic Plastic Pizza", 346.4543799690224 },
                    { 86, "7165157502708", new DateTime(2023, 12, 30, 12, 56, 41, 182, DateTimeKind.Local).AddTicks(8731), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Incredible Metal Shirt", 219.69463843558665 },
                    { 87, "9072296990991", new DateTime(2024, 6, 17, 2, 8, 59, 439, DateTimeKind.Local).AddTicks(4320), "The Football Is Good For Training And Recreational Purposes", "Handmade Cotton Pants", 771.37464212690236 },
                    { 88, "8893182042362", new DateTime(2024, 7, 8, 5, 17, 41, 24, DateTimeKind.Local).AddTicks(7424), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Fantastic Wooden Soap", 168.63343464472959 },
                    { 89, "0487815661938", new DateTime(2023, 10, 18, 5, 55, 19, 666, DateTimeKind.Local).AddTicks(6900), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", "Gorgeous Rubber Mouse", 383.80313230576138 },
                    { 90, "5688025363864", new DateTime(2024, 5, 12, 22, 13, 15, 409, DateTimeKind.Local).AddTicks(6549), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", "Ergonomic Rubber Mouse", 487.67439399877298 },
                    { 91, "3107752100327", new DateTime(2024, 8, 15, 12, 47, 32, 211, DateTimeKind.Local).AddTicks(523), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Ergonomic Frozen Chips", 605.73248992056233 },
                    { 92, "3146155279780", new DateTime(2024, 5, 15, 21, 38, 53, 554, DateTimeKind.Local).AddTicks(9417), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Small Soft Chicken", 572.13452711335128 },
                    { 93, "8883591493282", new DateTime(2023, 11, 8, 19, 9, 49, 824, DateTimeKind.Local).AddTicks(6982), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Tasty Granite Pizza", 835.07818786943244 },
                    { 94, "2794257231741", new DateTime(2023, 12, 28, 16, 51, 35, 358, DateTimeKind.Local).AddTicks(798), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", "Handcrafted Granite Bike", 669.1514615426546 },
                    { 95, "9965575108104", new DateTime(2024, 5, 10, 23, 18, 28, 920, DateTimeKind.Local).AddTicks(4542), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Gorgeous Concrete Table", 808.69116524545996 },
                    { 96, "3352535975696", new DateTime(2024, 1, 23, 9, 42, 40, 357, DateTimeKind.Local).AddTicks(9320), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", "Rustic Plastic Computer", 561.68517456282166 },
                    { 97, "7711914812858", new DateTime(2024, 8, 8, 1, 27, 31, 47, DateTimeKind.Local).AddTicks(84), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", "Practical Fresh Cheese", 239.76816976571837 },
                    { 98, "2642950951261", new DateTime(2024, 7, 12, 11, 42, 10, 788, DateTimeKind.Local).AddTicks(4517), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", "Generic Metal Car", 59.559374826755082 },
                    { 99, "9133862211404", new DateTime(2024, 7, 3, 6, 32, 29, 603, DateTimeKind.Local).AddTicks(4147), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", "Generic Fresh Soap", 323.8241613888294 },
                    { 100, "2476106364021", new DateTime(2024, 1, 18, 19, 28, 11, 724, DateTimeKind.Local).AddTicks(6428), "The Football Is Good For Training And Recreational Purposes", "Generic Cotton Table", 508.81764639300189 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
