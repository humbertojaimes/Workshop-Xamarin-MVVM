using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkshopXamarinFormsApi.Migrations
{
    public partial class DataMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 1, "Av. Paseo de la Reforma 483, Cuauhtémoc, 06500 Ciudad de México, CDMX ", "Reforma" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 131, "GUERRERO SUR 506, CENTRO, 26530 Coahuila de Zaragoza. México ", "CIUDAD ALLENDE" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 132, "PRESIDENTE CARRANZA  SUR 101,  CENTRO, 25600 Coahuila de Zaragoza. México ", "CIUDAD FRONTERA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 133, "5 DE MAYO  110-A OTE, CENTRO, 26340 Coahuila de Zaragoza. México ", "CIUDAD MELCHOR MUZQUIZ" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 134, "FCO I MADERO  152, CENTRO, 26700 Coahuila de Zaragoza. México ", "CIUDAD SABINAS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 136, "BELISARIO DOMÍNGUEZ   650, BENITO JUÁREZ, 26215 Coahuila de Zaragoza. México ", "COLONIA BENITO JUÁREZ DE CIUDAD ACUÑA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 137, "AVENIDA PERIODISTAS 712, LAS FUENTES, 26010 Coahuila de Zaragoza. México ", "AVENIDA PERIODISTAS DE PIEDRAS NEGRAS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 138, "SECUNDARIA #1 744, OBRERA SUR, 25790 Coahuila de Zaragoza. México ", "COLONIA OBRERA SUR DE MONCLOVA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 139, "BLVD FCO COSS, SORIANA , CENTRO , 25000 Coahuila de Zaragoza. México ", "COLONIA REPÚBLICA NORTE DE SALTILLO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 130, "GUERRERO  535, CENTRO, 26200 Coahuila de Zaragoza. México ", "CIUDAD ACUÑA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 140, "MELCHOR OCAMPO  105, CUATROCIÉNEGAS DE CARRANZA CENTRO , 27640 Coahuila de Zaragoza. México ", "CUATROCIÉNEGAS DE CARRANZA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 142, "HIDALGO  S/N, CENTRO, 25950 Coahuila de Zaragoza. México ", "GENERAL CEPEDA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 143, "BLVD. FRANCISCO COSS  1102, CENTRO, 25000 Coahuila de Zaragoza. México ", "GENERAL COSS DE SALTILLO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 144, "MORELOS  44, CENTRO, 27750 Coahuila de Zaragoza. México ", "SACRAMENTO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 145, "VENUSTIANO CARRANZA S/N, CENTRO, 27610 Coahuila de Zaragoza. México ", "LA ESMERALDA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 146, "LA NEGRA  108, COL IINDUSTRIAL, 27545 Coahuila de Zaragoza. México ", "LAGUNA DEL REY" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 147, "BLVD CONSTITUCIÓN (SORIANA) 1111, AMPLIACIÓN LAS MARGARITAS , 27130 Coahuila de Zaragoza. México ", "BOULEVARD CONSTITUCIÓN DE TORREÓN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 148, "LIBERTAD  110 BIS , MATAMOROS DE LA LAGUNA CENTRO, 27440 Coahuila de Zaragoza. México ", "MATAMOROS DE LA LAGUNA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 149, "BLVD. MUZQUIZ, EDIFICIO COMISARIA  S/N, CENTRO, 26370 Coahuila de Zaragoza. México ", "MINAS DE BARROTERAN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 141, "AVENIDA LOPEZ MATEOS 318, NUEVO LINARES DEL SUR, 27900 Coahuila de Zaragoza. México ", "FRANCISCO I.  MADERO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 129, "HIDALGO  39, NADADORES CENTRO , 27550 Coahuila de Zaragoza. México ", "NADADORES " });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 128, "HIDALGO  100, CENTRO, 25870 Coahuila de Zaragoza. México ", "CASTAÑOS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 127, "MIGUEL HIDALGO  407, CENTRO, 25570 Coahuila de Zaragoza. México ", "CANDELA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 107, "CALLE 20 EDIFICIO FEDERAL S/N, CENTRO, 24800 Campeche. México ", "HECELCHAKAN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 108, "CALLE 19  74, CENTRO, 24600 Campeche. México ", "HOPELCHEN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 109, "AV. 20 DE NOVIEMBRE  S/N, CENTRO, 24314 Campeche. México ", "MAMANTEL" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 110, "CALLE MARINA  23, ISLA AGUADA CENTRO, 24327 Campeche. México ", "ISLA AGUADA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 111, "CALLE 10  EDIFICIO CASA DE LA CULTURA S/N, CENTRO, 24700 Campeche. México ", "TENABO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 112, "MIGUEL HIDALGO  EDIFICIO DIF 30, CENTRO, 24200 Campeche. México ", "PALIZADA " });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 113, "CALLE 22  S/N, CENTRO, 24570 Campeche. México ", "ALFREDO V. BONFIL" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 114, "MANUEL J. LÓPEZ  HERNÁNDEZ  2, CENTRO, 24300 Campeche. México ", "SABANCUY" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 115, "CALLE 23, BAJOS DEL PALACIO MUNICIPAL S/N, CENTRO, 24460 Campeche. México ", "SEYBAPLAYA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 116, "CALLE 2 S/N, JARDINES, 24640 Campeche. México ", "XPUJIL" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 117, "AV. CONCORDIA 90, AMPLIACIÓN ESPERANZA, 24085 Campeche. México ", "COLONIA CIUDAD CONCORDIA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 118, "CARMEN SUR S/N, EL AGUACATAL CENTRO , 24317 Campeche. México ", "AGUACATAL" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 119, "ERMITA  S/N, SIHOCHAC CENTRO, 24450 Campeche. México ", "SIHOCHAC" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 121, "CALLE 14  S/N, CENTRO POMUCH, 24810 Campeche. México ", "POMUCH" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 122, "CALLE 25 BAJOS DEL PALACIO EJIDAL S/N, DZITBALCHÉ CENTRO, 24920 Campeche. México ", "DZITBALCHÉ" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 123, "VERACRUZ  202, SANTA ANA, 24050 Campeche. México ", "COLONIA LOMAS " });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 124, "CARRETERA FEDERAL CHAMPOTÓN-ESCARCEGA K.M. 38, XBACAB CENTRO, 24416 Campeche. México ", "XBACAB" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 125, "LIC. RAÚL LÓPEZ SÁNCHEZ  7, CENTRO, 26640 Coahuila de Zaragoza. México ", "GUERRERO   " });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 126, "HIDALGO 2, CENTRO, 25350 Coahuila de Zaragoza. México ", "ARTEAGA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 150, " DE LA FUENTE  103 NTE, CENTRO, 25700 Coahuila de Zaragoza. México ", "MONCLOVA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 151, "JUÁREZ   308, CENTRO, 26500 Coahuila de Zaragoza. México ", "MORELOS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 152, "ZARAGOZA, INTERIOR DE LA PRESIDENCIA MUNICIPAL S/N, CENTRO, 26170 Coahuila de Zaragoza. México ", "NAVA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 153, "BLVD. INDEPENDENCIA, IPERMART INDEPENDENCIA 1100, CENTRO, 27000 Coahuila de Zaragoza. México ", "NIÑOS HEROES DE TORREÓN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 182, "FRANCISCO I. MADERO  243, CENTRO, 28000 Colima. México ", "COLIMA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 183, "AND PLAYA LA AUDIENCIA 310, LAS BRISAS, 28210 Colima. México ", "COLONIA LAS BRISAS DE MANZANILLO " });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 184, "GUILLERMO PRIETO  100 N, CENTRO, 28450 Colima. México ", "COMALA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 185, "BENITO JUÁREZ  349, CENTRO, 28400 Colima. México ", "COQUIMATLAN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 186, "MIGUEL HIDALGO, INTERIOR H. AYUNTAMIENTO  5, CENTRO, 28500 Colima. México ", "CUAUHTÉMOC" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 187, "LA PAZ  12, CENTRO, 28350 Colima. México ", "CUYUTLAN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 188, "VENUSTIANO CARRANZA S/N, CENTRO, 28800 Colima. México ", "EL COLOMO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 189, "CALLE MORELOS, INTERIOR H. AYUNTAMIENTO  1, CENTRO, 28700 Colima. México ", "IXTLAHUACAN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 190, "CARRILLO PUERTO 135, CENTRO, 28200 Colima. México ", "MANZANILLO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 191, "FRANCISCO I. MADERO 38-A, CENTRO, 28600 Colima. México ", "LOS TEPAMES" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 192, "INDEPENDENCIA  27, CENTRO, 28750 Colima. México ", "MINATITLÁN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 193, "MOCTEZUMA   1-D, CENTRO, 28510 Colima. México ", "QUESERÍA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 194, "ALDAMA 230, CENTRO, 28100 Colima. México ", "TECOMÁN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 195, "ARGENTINA, PRESIDENCIA MUNICIPAL 109, CENTRO, 28910 Colima. México ", "MADRID" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 196, "AV. J. MERCED CABRERA  84, CENTRO, 28950 Colima. México ", "VILLA DE ÁLVAREZ " });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 197, "AV. PRIMAVERA  MZ 53, VALLE DE LAS GARZAS BARRIO II, 28219 Colima. México ", "COLONIA VALLE DE LAS GARZAS " });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 198, "AV. INSURGENTES, P.B. 680, CAMINO REAL, 28040 Colima. México ", "COLONIA CAMINO REAL DE COLIMA " });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 199, "AV. NIÑOS HÉROES 353 P.B., JUAN JOSÉ RÍOS II, 28984 Colima. México ", "JUAN JOSÉ RÍOS " });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 200, "MIRTO 4, SUCHITLÁN CENTRO, 28459 Colima. México ", "SUCHITLÁN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 181, "ALLENDE 30, CENTRO, 28350 Colima. México ", "COFRADIA DE JUÁREZ " });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 106, "CALLE 31-B  S/N, CENTRO, 24350 Campeche. México ", "ESCARCEGA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 180, "AV. REVOLUCIÓN  PALACIO MUNICIPAL S/N, CENTRO, 28900 Colima. México ", "CERRO DE ORTEGA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 178, "VENUSTIANO CARRANZA  4, SANTIAGO, 28860 Colima. México ", "ABELARDO L. RODRÍGUEZ " });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 154, "AVENIDA LÓPEZ MATEOS  S/N, CENTRO, 26800 Coahuila de Zaragoza. México ", "NUEVA ROSITA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 155, "VENUSTIANO CARRANZA  05 OTE, CENTRO, 26350 Coahuila de Zaragoza. México ", "PALAU" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 156, "LIC. ARNULFO R. GARCIA  S/N, CENTRO, 25910 Coahuila de Zaragoza. México ", "PAREDÓN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 157, "RAMOS ARÍZPE 123, CENTRO, 27980 Coahuila de Zaragoza. México ", "PARRAS DE LA FUENTE" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 158, "DE LA FUENTE OTE. Y MORELOS  S/N, CENTRO, 26000 Coahuila de Zaragoza. México ", "PIEDRAS NEGRAS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 159, "JOSÉ A. VILLARREAL 203, CENTRO, 25900 Coahuila de Zaragoza. México ", "RAMOS ARÍZPE" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 160, "GUADALUPE VICTORIA  289 PTE, CENTRO, 25000 Coahuila de Zaragoza. México ", "SALTILLO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 161, "FRANCISCO I MADERO  264, CENTRO, 25500 Coahuila de Zaragoza. México ", "SAN BUENAVENTURA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 162, " LERDO  11 OTE, CENTRO, 27800 Coahuila de Zaragoza. México ", "SAN PEDRO DE LAS COLONIAS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 163, "BLVD. JUÁREZ  6, EL PUEBLO, 25730 Coahuila de Zaragoza. México ", "SECTOR EL PUEBLO DE MONCLOVA, COAHUILA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 164, "AV. JUÁREZ, INTERIOR 3 DEL PALACIO FEDERAL  S/N, CENTRO, 27000 Coahuila de Zaragoza. México ", "TORREÓN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 166, "AV. 5 DE MAYO  14, CENTRO, 27480 Coahuila de Zaragoza. México ", "VIESCA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 167, "CALLE HIDALGO 101 SUR , VILLA DE FUENTE, 26090 Coahuila de Zaragoza. México ", "VILLA DE FUENTE" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 168, "ZARAGOZA 211, CENTRO, 27500 Coahuila de Zaragoza. México ", "VILLA OCAMPO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 170, "ALLENDE  106, CENTRO, 26450 Coahuila de Zaragoza. México ", "ZARAGOZA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 172, "DOMICILIO CONOCIDO , EJIDO LUCHANA, 27940 Coahuila de Zaragoza. México ", "LUCHANA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 174, "CALLE PRINCIPAL  S/N, CENTRO, 27450 Coahuila de Zaragoza. México ", "EJIDO EL COYOTE" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 175, "AVENIDA MORELOS 765 PTE, CENTRO, 27000 Coahuila de Zaragoza. México ", "AVENIDA MORELOS DE TORREÓN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 176, "POSEIDÓN  S/N, CENTRO, 27603 Coahuila de Zaragoza. México ", "HÉRCULES" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 179, "CHIHUAHUA  3, CENTRO, 28300 Colima. México ", "ARMERIA " });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 105, "CARRETERA FEDERAL KM. 70 S/N, CENTRO, 24658 Campeche. México ", "CONSTITUCIÓN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 104, "CALLE 30 BAJOS PALACIO MUNICIPAL S/N, CENTRO, 24611 Campeche. México ", "DZIBALCHEN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 103, "CALLE 32  4, CENTRO, 24400 Campeche. México ", "CHAMPOTON" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 29, "AV. ESTADO 29  24, CENTRO, 22910 Baja California. México ", "CAMALÚ" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 30, "JOSÉ MARÍA MORELOS Y PAVÓN 521, ZONA CENTRO, 21960 Baja California. México ", "CIUDAD MORELOS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 31, "BAHÍA DE LOS ÁNGELES S/N, BAJA CALIFORNIA, 21130 Baja California. México ", "COLONIA BAJA CALIFORNIA DE MEXICALI" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 32, "CALLE CORTES  1983, HIDALGO, 22880 Baja California. México ", "COLONIA HIDALGO DE ENSENADA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 33, "CALZ. INDEPENDENCIA  S/N, INDEPENDENCIA, 21290 Baja California. México ", "COLONIA INDEPENDENCIA DE MEXICALI" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 34, "BLVD. DÍAZ ORDAZ,  CENTRO COMERCIAL 5 Y 10 14517, LAS FUENTES, 22115 Baja California. México ", "COLONIA LAS BRISAS DE TIJUANA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 35, "CARRETERA TRANSPENINSULAR KM 195 , EJIDO NUEVO BAJA CALIFORNIA, 22930 Baja California. México ", "COLONIA LÁZARO CÁRDENAS DEL VALLE DE SAN QUINTÍN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 36, "BAHIA DE KINO S/N, LOMAS DEL PORVENIR, 22535 Baja California. México ", "COLONIA LOMAS DEL PORVENIR DE TIJUANA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 37, "PASEO DE ENSENADA  1845, JARDINES DEL SOL, 22504 Baja California. México ", "COLONIA PLAYAS DE TIJUANA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 38, "MÁRTIRES DE CHICAGO 2DA. SECCION S/N, OBRERA, 22625 Baja California. México ", "COLONIA PRIMERO DE MAYO DE TIJUANA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 40, "AV. OBREGÓN  658, PRIMERA SECCION, 21100 Baja California. México ", "COLONIA NUEVA DE MEXICALI" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 42, "CALLE HIDALGO  106, EL SAUZAL, 22760 Baja California. México ", "EL SAUZAL DE RODRÍGUEZ" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 43, "CALLE FLORESTA  300, OBRERA, 22800 Baja California. México ", "ENSENADA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 44, "CALLE CUARTA  S/N, COLONIAS NUEVAS, 21800 Baja California. México ", "ESTACIÓN COAHUILA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 45, "AV. JOSEFA ORTIZ DE DOMINGUEZ  S/N, ESTACIÓN DELTA, 21700 Baja California. México ", "ESTACIÓN DELTA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 46, "CALLE QUINTA  367, GUADALUPE VICTORIA KM 43, 21720 Baja California. México ", "ESTACIÓN VICTORIA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 47, "BLVD. GRAL. VENUSTIANO CARRANZA  673, FRACCIONAMIENTO PASEOS DEL SOL, 21399 Baja California. México ", "GONZÁLEZ ORTEGA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 48, "CALLE DEL ARROYO  S/N, VISTA AL MAR, 22990 Baja California. México ", "ISLA DE CEDROS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 49, "BOULEVARD INDUSTRIAL 1100, LA MESA DE OTAY, 22436 Baja California. México ", "OTAY DE TIJUANA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 27, "PLAZA JUÁREZ  4, ZONA CENTRO, 20600 Aguascalientes. México ", "TEPEZALÁ" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 51, "AV. BENITO JUÁREZ  S/N, LUIS ECHEVERRÍA ÁLVAREZ, 21505 Baja California. México ", "EL HONGO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 26, "AV. DE LOS MAESTROS  102, INSURGENTES, 20287 Aguascalientes. México ", "DELEGACIÓN INSURGENTES  DE AGUASCALIENTES" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 24, "AV. JESÚS MACIAS RANGEL  120 PTE., CENTRO, 20700 Aguascalientes. México ", "VILLA JUÁREZ" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 2, "Calz. Vallejo 1090, Sta Cruz de las Salinas, Azcapotzalco, 02300 Ciudad de México, CDMX ", "Vallejo" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 3, "Av. Central Alta Tensión Del, Alfonso XIII, 01460 Ciudad de México ", "AV. Central" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 4, "Atlixcáyotl 2501, Reserva Territorial Atlixcáyotl, 72830 Puebla, Pue. ", "Puebla" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 5, "Prol Corregidora Sur # 3, Centro, 76000 Santiago de Querétaro, Qro. ", "Querétaro" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 6, "Matucana 501, Santiago, Región Metropolitana, Chile ", "Santiago de Chile" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 7, "Av. Mcal. López 3350, Asunción, Paraguay", "Asunción" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 8, "PEDRO PARGA  , ZONA CENTRO , 20000 Aguascalientes. México ", "AGUASCALIENTES" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 9, "PEDRO PARGA  231, ZONA CENTRO , 20000 Aguascalientes. México ", "AGUASCALIENTES" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 10, "ZARAGOZA  212 BIS, CENTRO, 20800 Aguascalientes. México ", "CALVILLO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 11, "MIGUEL RUELAS  108, MIRAVALLE, 20400 Aguascalientes. México ", "COLONIA MIRAVALLE DE AGUASCALIENTES" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 12, "JUÁREZ  23, CENTRO, 20460 Aguascalientes. México ", "COSÍO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 13, "ARAGÓN  103-B, FRACCIONAMIENTO ESPAÑA, 20210 Aguascalientes. México ", "FRACCIONAMIENTO ESPAÑA DE AGUASCALIENTES" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 14, "JULIO DÍAZ TORRE 110, CIUDAD INDUSTRIAL, 20290 Aguascalientes. México ", "CENTRO S.C.T. AGUASCALIENTES" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 15, "EMILIO RANGEL  201, CENTRO, 20320 Aguascalientes. México ", "JOSE MARÍA MORELOS Y PAVON" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 16, "PINO SUÁREZ 18, CENTRO, 20670 Aguascalientes. México ", "PABELLÓN DE ARTEAGA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 17, "PRIMO VERDAD  101, CENTRO, 20400 Aguascalientes. México ", "RINCÓN DE ROMOS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 18, "REPÚBLICA DE BRASIL  608, FRACCIONAMIENTO JARDINES DE SANTA ELENA, 20236 Aguascalientes. México ", "CENTRAL CAMIONERA DE AGUASCALIENTES" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 19, "SAN MIGUEL  202, CENTRO, 20900 Aguascalientes. México ", "JESÚS MARÍA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 23, "PLAZA JUÁREZ  110, CENTRO, 20710 Aguascalientes. México ", "ASIENTOS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 25, "JUAN  DOMINGUEZ  101, SAN JOSÉ DE GRACIA CENTRO , 20500 Aguascalientes. México ", "SAN JOSÉ DE GRACIA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 201, "AV. CENTRAL  BAJOS PALACIO MUNICIPAL. S/N, CENTRO, 30580 Chiapas. México ", "ACAPETAHUA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 53, "AV. MADERO  491, CENTRO, 21100 Baja California. México ", "MADERO DE MEXICALI" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 56, "DERECHO DE VIA PÚBLICA C.F.E. 2091, FRACCIONAMIENTO CHULAVISTA, 22710 Baja California. México ", "PLAYAS DE ROSARITO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 84, "PUERTO JUÁREZ  S/N, CENTRO, 23740 Baja California Sur. México ", "PUERTO SAN CARLOS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 85, "MIGUEL HIDALGO  S/N, CENTRO, 23970 Baja California Sur. México ", "PUNTA ABREOJOS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 86, "MORELOS 23, CENTRO, 23930 Baja California Sur. México ", "SAN IGNACIO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 87, "20 DE NOVIEMBRE  S/N, CENTRO, 23810 Baja California Sur. México ", "SAN ISIDRO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 88, "BLVD. MIJAREZ  MZA 60, CENTRO, 23400 Baja California Sur. México ", "SAN JOSÉ DEL CABO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 89, "PEDRO ALTAMIRANO 7, CENTRO, 23920 Baja California Sur. México ", "SANTA ROSALÍA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 90, "FRANCISCO VILLA  S/N, CHAMETLA, 23205 Baja California Sur. México ", "CHAMETLA " });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 91, "CENTENARIO, EDIFICIO DE LA MUNICIPALIDAD S/N, CENTRO, 23300 Baja California Sur. México ", "TODOS SANTOS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 92, "LÓPEZ MATEOS Y ALLENDE INT. EDIFICIO DELEG. MUNICIPAL  , CENTRO, 23700 Baja California Sur. México ", "VILLA INSURGENTES" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 93, "GUILLERMO PRIETO  S/N, CENTRO, 23000 Baja California Sur. México ", "MUSEO DE LA PAZ" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 94, "MADERO  INTERIOR DE LA SUBDELEGACIÓN S/N, CENTRO, 23200 Baja California Sur. México ", "SAN JUAN DE LOS PLANES" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 95, "PADRE JAIME BRAVO  S/N, LIENZO CHARRO, 23030 Baja California Sur. México ", "COL. LIENZO CHARRO DE LA PAZ" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 96, "VICENTE GUERRERO  98, CENTRO, 24326 Campeche. México ", "ATASTA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 97, "CALLE 33  193, CENTRO, 24930 Campeche. México ", "BECAL" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 98, "CALLE 10  S/N, CENTRO, 24620 Campeche. México ", "BOLONCHÉN DE REJÓN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 99, "CALLE 20 129, CENTRO, 24900 Campeche. México ", "CALKINI" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 100, "AVENIDA 16 DE DE SEPTIEMBRE, PALACIO FEDERAL PLANTA BAJA S/N, CENTRO, 24000 Campeche. México ", "CAMPECHE" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 101, "CALLE 18  8, CENTRO, 24330 Campeche. México ", "CANDELARIA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 102, "CALLE 20  208, CENTRO, 24100 Campeche. México ", "CIUDAD DEL CARMEN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 83, "LA ALMEJA  S/N, CENTRO, 23973 Baja California Sur. México ", "LA BOCANA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 54, "CARRETERA TRANSPENINSULAR  1400, PARTE ALTA, 22790 Baja California. México ", "MANEADERO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 82, "MOCTEZUMA 73, CENTRO, 23900 Baja California Sur. México ", "MULEGÉ" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 80, "DEPORTIVA  12, CENTRO, 23880 Baja California Sur. México ", "LORETO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 57, "AV. MAR NEGRO   S/N, CENTRO SECCIÓN 2, 21850 Baja California. México ", "SAN FELIPE" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 58, "PRESIDENTE PASCUAL ORTIZ RUBIO  145, ZONA CENTRO, 21430 Baja California. México ", "TECATE" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 59, "AV. LÁZARO CÁRDENAS  1000, ALAMAR, 22540 Baja California. México ", "TERMINAL DE AUTOBUSES DE TIJUANA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 60, "AV.  NEGRETE  2050, CENTRO, 22000 Baja California. México ", "TIJUANA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 64, "CARRETERA MEXICALI-TIJUANA KM 69.5  S/N, CENTRO, 21510 Baja California . México ", "LA RUMOROSA " });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 65, "CARRETERA TECATE-ENSENADA KM 13.5  S/N, NUEVA HINDÚ SECC. CERRO AZUL, 21507 Baja California . México ", "COLONIA HINDÚ" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 66, "AVE. BENITO JUÁREZ  S/N, VALLE DE LAS PALMAS , 21500 Baja California. México ", "VALLE DE LAS PALMAS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 68, "PESCADORES  S/N, CENTRO, 23960 Baja California Sur. México ", "BAHÍA ASUNCIÓN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 69, "AV BENITO JUÁREZ 52, CENTRO, 23950 Baja California Sur. México ", "BAHÍA TORTUGAS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 70, "BLVD. LÁZARO CÁRDENAS  MANZ 16, CENTRO, 23450 Baja California Sur. México ", "CABO SAN LUCAS" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 71, "BENITO JUÁREZ  S/N, CENTRO, 23600 Baja California Sur. México ", "CIUDAD CONSTITUCIÓN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 72, "ANDADOR SEBASTIAN VIZCAINO   S/N, FOVISSSTE SUDCALIFORNIA, 23080 Baja California Sur. México ", "COLONIA FOVISSSTE DE LA PAZ" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 73, "JALISCO  S/N, INFONAVIT, 23070 Baja California Sur. México ", "COLONIA INFONAVIT DE LA PAZ" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 74, "NIÑOS HÉROES  S/N, PUEBLO NUEVO, 23670 Baja California Sur. México ", "COLONIA PUEBLO NUEVO DE CIUDAD CONSTITUCIÓN" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 75, "CARRETERA TRANSPENINSULAR KM 7 , CENTRO, 23580 Baja California Sur. México ", "BUENAVISTA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 76, "MORELOS MANZ 173, INFONAVIT SALINEROS, 23940 Baja California Sur. México ", "GUERRERO NEGRO" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 77, "ALFREDO V. BONFIL  7 LOTE 7 MANZ E , CENTRO, 23938 Baja California Sur. México ", "VILLA ALBERTO ANDRÉS ALVARADO ARÁMBURU" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 78, "CONSTITUCIÓN ALTOS , CENTRO, 23000 Baja California Sur. México ", "LA PAZ" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 79, "GUILLERMO PRIETO S/N, SANTA ROSA, 23428 Baja California Sur. México ", "SANTA ROSA" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 81, "UNIÓN 11, CENTRO, 23520 Baja California Sur. México ", "MIRAFLORES" });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Location", "Name" },
                values: new object[] { 202, "CALLE CENTRAL 5, AMATÁN CENTRO, 29700 Chiapas. México ", "AMATÁN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 202);
        }
    }
}
