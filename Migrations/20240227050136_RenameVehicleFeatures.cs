using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace netan.Migrations
{
    /// <inheritdoc />
    public partial class RenameVehicleFeatures : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeatureVehicle_Features_FeaturesId",
                table: "FeatureVehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_FeatureVehicle_Vehicle_VehiclesId",
                table: "FeatureVehicle");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Models_ModelId",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FeatureVehicle",
                table: "FeatureVehicle");

            migrationBuilder.RenameTable(
                name: "Vehicle",
                newName: "Vehicles");

            migrationBuilder.RenameTable(
                name: "FeatureVehicle",
                newName: "VehicleFeatures");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicle_ModelId",
                table: "Vehicles",
                newName: "IX_Vehicles_ModelId");

            migrationBuilder.RenameIndex(
                name: "IX_FeatureVehicle_VehiclesId",
                table: "VehicleFeatures",
                newName: "IX_VehicleFeatures_VehiclesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VehicleFeatures",
                table: "VehicleFeatures",
                columns: new[] { "FeaturesId", "VehiclesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleFeatures_Features_FeaturesId",
                table: "VehicleFeatures",
                column: "FeaturesId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleFeatures_Vehicles_VehiclesId",
                table: "VehicleFeatures",
                column: "VehiclesId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Models_ModelId",
                table: "Vehicles",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VehicleFeatures_Features_FeaturesId",
                table: "VehicleFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleFeatures_Vehicles_VehiclesId",
                table: "VehicleFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Models_ModelId",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VehicleFeatures",
                table: "VehicleFeatures");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "Vehicle");

            migrationBuilder.RenameTable(
                name: "VehicleFeatures",
                newName: "FeatureVehicle");

            migrationBuilder.RenameIndex(
                name: "IX_Vehicles_ModelId",
                table: "Vehicle",
                newName: "IX_Vehicle_ModelId");

            migrationBuilder.RenameIndex(
                name: "IX_VehicleFeatures_VehiclesId",
                table: "FeatureVehicle",
                newName: "IX_FeatureVehicle_VehiclesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FeatureVehicle",
                table: "FeatureVehicle",
                columns: new[] { "FeaturesId", "VehiclesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureVehicle_Features_FeaturesId",
                table: "FeatureVehicle",
                column: "FeaturesId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FeatureVehicle_Vehicle_VehiclesId",
                table: "FeatureVehicle",
                column: "VehiclesId",
                principalTable: "Vehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Models_ModelId",
                table: "Vehicle",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
