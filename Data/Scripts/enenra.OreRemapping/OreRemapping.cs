using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sandbox.Common;
using Sandbox.Common.ObjectBuilders;
using Sandbox.Common.ObjectBuilders.Definitions;
using Sandbox.Definitions;
using Sandbox.Game;
using Sandbox.Game.Entities;
using Sandbox.Game.EntityComponents;
using Sandbox.Game.GameSystems;
using Sandbox.ModAPI;
using Sandbox.ModAPI.Interfaces;
using Sandbox.ModAPI.Weapons;
using SpaceEngineers.Game.ModAPI;
using VRage.Game;
using VRage.Game.Components;
using VRage.Game.Entity;
using VRage.Game.ModAPI;
using VRage.ModAPI;
using VRage.ObjectBuilders;
using VRage.Utils;
using VRageMath;

// --- Ore Remapping for Finding Paradiso Season 2 ---
// --- Modified from AQD - Vanilla Ore Distribution Mod with permission ---
// --- Original mod link: https://steamcommunity.com/sharedfiles/filedetails/?id=1845977557 ---
// --- Github link: https://github.com/enenra/aqdse/blob/cf2bca7d4e3871d44d87affaa129415503abc6cd/AQD%20-%20Vanilla%20Ore%20Distribution/Content/Data/Scripts/enenra.OreRemapping/OreRemapping.cs
// --- Original Author: Enenra ---
// --- Thank you Enenra for allowing me to modify and use this script! ---

namespace enenra.OreRemapping
{

    [MySessionComponentDescriptor(MyUpdateOrder.BeforeSimulation)]
    public class OreRemapping : MySessionComponentBase
    {

        public override void LoadData()
        {

            var allPlanets = MyDefinitionManager.Static.GetPlanetsGeneratorsDefinitions();

            foreach (var def in allPlanets)
            {

                var planet = def as MyPlanetGeneratorDefinition;
                var oreList = new List<MyPlanetOreMapping>(planet.OreMappings.ToList());

                if (planet.Id.SubtypeName == "Satreus")
                {
                    for (int i = 0; i < oreList.Count; i++)
                    {
                        var oreMap = planet.OreMappings[i];

                        if (oreMap.Value == 10 && oreMap.Type.Contains("Iron_02") == true) { oreMap.Type = "Hapekite_01"; oreMap.Start = 7; oreMap.Depth = 5; }
                        if (oreMap.Value == 20 && oreMap.Type.Contains("Iron_02") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 9; oreMap.Depth = 7; }
                        if (oreMap.Value == 30 && oreMap.Type.Contains("Iron_02") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 12; oreMap.Depth = 9; }
                        if (oreMap.Value == 40 && oreMap.Type.Contains("Iron_02") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 18; oreMap.Depth = 12; }
                        if (oreMap.Value == 50 && oreMap.Type.Contains("Iron_02") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 24; oreMap.Depth = 6; }
                        if (oreMap.Value == 60 && oreMap.Type.Contains("Nickel_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 11; oreMap.Depth = 8; }
                        if (oreMap.Value == 70 && oreMap.Type.Contains("Nickel_01") == true) { oreMap.Type = "Cooperite_01"; oreMap.Start = 18; oreMap.Depth = 6; }
                        if (oreMap.Value == 80 && oreMap.Type.Contains("Silicon_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 12; oreMap.Depth = 7; }
                        if (oreMap.Value == 90 && oreMap.Type.Contains("Silicon_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 17; oreMap.Depth = 5; }
                        if (oreMap.Value == 100 && oreMap.Type.Contains("Cobalt_01") == true) { oreMap.Type = "Cattierite_01"; oreMap.Start = 16; oreMap.Depth = 6; }
                        if (oreMap.Value == 110 && oreMap.Type.Contains("Cobalt_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 23; oreMap.Depth = 8; }
                        if (oreMap.Value == 120 && oreMap.Type.Contains("Cobalt_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 28; oreMap.Depth = 10; }
                        if (oreMap.Value == 130 && oreMap.Type.Contains("Cobalt_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 36; oreMap.Depth = 5; }
                        if (oreMap.Value == 140 && oreMap.Type.Contains("Magnesium_01") == true) { oreMap.Type = "Coal"; oreMap.Start = 16; oreMap.Depth = 7; }
                        if (oreMap.Value == 150 && oreMap.Type.Contains("Magnesium_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 24; oreMap.Depth = 9; }
                        if (oreMap.Value == 160 && oreMap.Type.Contains("Magnesium_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 27; oreMap.Depth = 5; }
                        if (oreMap.Value == 170 && oreMap.Type.Contains("Silver_01") == true) { oreMap.Type = "Galena_01"; oreMap.Start = 19; oreMap.Depth = 6; }
                        if (oreMap.Value == 180 && oreMap.Type.Contains("Silver_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 26; oreMap.Depth = 10; }
                        if (oreMap.Value == 190 && oreMap.Type.Contains("Silver_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 29; oreMap.Depth = 7; }
                        if (oreMap.Value == 200 && oreMap.Type.Contains("Gold_01") == true) { oreMap.Type = "Copper"; oreMap.Start = 34; oreMap.Depth = 7; }

                        if (oreMap.Value == 15 && oreMap.Type.Contains("Iron_02") == true) { oreMap.Type = "Hapekite_01"; oreMap.Start = 5; oreMap.Depth = 4; }
                        if (oreMap.Value == 25 && oreMap.Type.Contains("Nickel_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 9; oreMap.Depth = 5; }
                        if (oreMap.Value == 35 && oreMap.Type.Contains("Silicon_01") == true) { oreMap.Type = "Cattierite_01"; oreMap.Start = 12; oreMap.Depth = 6; }
                        if (oreMap.Value == 45 && oreMap.Type.Contains("Cobalt_01") == true) { oreMap.Type = "Cooperite_01"; oreMap.Start = 18; oreMap.Depth = 7; }
                        if (oreMap.Value == 55 && oreMap.Type.Contains("Magnesium_01") == true) { oreMap.Type = "Dolomite_01"; oreMap.Start = 8; oreMap.Depth = 4; }
                        if (oreMap.Value == 65 && oreMap.Type.Contains("Silver_01") == true) { oreMap.Type = "Sulfur"; oreMap.Start = 4; oreMap.Depth = 4; }
                        if (oreMap.Value == 75 && oreMap.Type.Contains("Silver_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 8; oreMap.Depth = 5; }
                        if (oreMap.Value == 85 && oreMap.Type.Contains("Silver_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 16; oreMap.Depth = 7; }
                        if (oreMap.Value == 95 && oreMap.Type.Contains("Silver_01") == true) { oreMap.Type = "OilSand"; oreMap.Start = 24; oreMap.Depth = 9; }
                        if (oreMap.Value == 105 && oreMap.Type.Contains("Silver_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 30; oreMap.Depth = 5; }
                        if (oreMap.Value == 115 && oreMap.Type.Contains("Gold_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 1; oreMap.Depth = 6; }
                        if (oreMap.Value == 125 && oreMap.Type.Contains("Gold_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 3; oreMap.Depth = 7; }
                        if (oreMap.Value == 135 && oreMap.Type.Contains("Gold_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 5; oreMap.Depth = 5; }
                        if (oreMap.Value == 145 && oreMap.Type.Contains("Gold_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 8; oreMap.Depth = 6; }
                        if (oreMap.Value == 155 && oreMap.Type.Contains("Gold_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 10; oreMap.Depth = 7; }
                        if (oreMap.Value == 165 && oreMap.Type.Contains("Gold_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 12; oreMap.Depth = 5; }
                        if (oreMap.Value == 175 && oreMap.Type.Contains("Platinum_01") == true) { oreMap.Type = "Bauxite"; oreMap.Start = 24; oreMap.Depth = 4; }
                        if (oreMap.Value == 185 && oreMap.Type.Contains("Platinum_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 34; oreMap.Depth = 6; }
                        if (oreMap.Value == 195 && oreMap.Type.Contains("Platinum_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 45; oreMap.Depth = 7; }
                        if (oreMap.Value == 205 && oreMap.Type.Contains("Platinum_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 61; oreMap.Depth = 10; }
                    }

                }

                if (planet.Id.SubtypeName == "Komorebi") // TODO: update with new ore types
                {
                    for (int i = 0; i < oreList.Count; i++)
                    {
                        var oreMap = planet.OreMappings[i];

                        if (oreMap.Value == 10 && oreMap.Type.Contains("Iron_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 10; oreMap.Depth = 3; }
                        if (oreMap.Value == 20 && oreMap.Type.Contains("Iron_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 16; oreMap.Depth = 5; }
                        if (oreMap.Value == 30 && oreMap.Type.Contains("Iron_01") == true) { oreMap.Type = "Akimotoite_01"; oreMap.Start = 24; oreMap.Depth = 7; }
                        if (oreMap.Value == 40 && oreMap.Type.Contains("Iron_01") == true) { oreMap.Type = "Quartz_01"; oreMap.Start = 34; oreMap.Depth = 9; }
                        if (oreMap.Value == 50 && oreMap.Type.Contains("Iron_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 43; oreMap.Depth = 14; }

                        if (oreMap.Value == 60 && oreMap.Type.Contains("Nickel_01") == true) { oreMap.Type = "Pyrite_01"; oreMap.Start = 10; oreMap.Depth = 3; }
                        if (oreMap.Value == 70 && oreMap.Type.Contains("Nickel_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 16; oreMap.Depth = 5; }
                        if (oreMap.Value == 80 && oreMap.Type.Contains("Nickel_01") == true) { oreMap.Type = "Akimotoite_01"; oreMap.Start = 24; oreMap.Depth = 7; }
                        if (oreMap.Value == 90 && oreMap.Type.Contains("Nickel_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 34; oreMap.Depth = 9; }
                        if (oreMap.Value == 100 && oreMap.Type.Contains("Nickel_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 43; oreMap.Depth = 14; }

                        if (oreMap.Value == 110 && oreMap.Type.Contains("Silicon_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 10; oreMap.Depth = 3; }
                        if (oreMap.Value == 120 && oreMap.Type.Contains("Silicon_01") == true) { oreMap.Type = "Galena_01"; oreMap.Start = 16; oreMap.Depth = 5; }
                        if (oreMap.Value == 130 && oreMap.Type.Contains("Silicon_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 24; oreMap.Depth = 7; }
                        if (oreMap.Value == 140 && oreMap.Type.Contains("Silicon_01") == true) { oreMap.Type = "Bauxite"; oreMap.Start = 34; oreMap.Depth = 9; }
                        if (oreMap.Value == 150 && oreMap.Type.Contains("Silicon_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 43; oreMap.Depth = 14; }

                        if (oreMap.Value == 160 && oreMap.Type.Contains("Magnesium_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 10; oreMap.Depth = 3; }
                        if (oreMap.Value == 170 && oreMap.Type.Contains("Magnesium_01") == true) { oreMap.Type = "Pyrite_01"; oreMap.Start = 18; oreMap.Depth = 6; }
                        if (oreMap.Value == 180 && oreMap.Type.Contains("Magnesium_01") == true) { oreMap.Type = "Quartz_01"; oreMap.Start = 28; oreMap.Depth = 8; }
                        if (oreMap.Value == 190 && oreMap.Type.Contains("Magnesium_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 36; oreMap.Depth = 12; }

                        if (oreMap.Value == 200 && oreMap.Type.Contains("Cobalt_01") == true) { oreMap.Type = "Stone_01"; oreMap.Start = 27; oreMap.Depth = 8; }

                        if (oreMap.Value == 220 && oreMap.Type.Contains("Ice") == true) { oreMap.Type = "Chlorargyrite_01"; oreMap.Start = 12; oreMap.Depth = 17; }

                        if (oreMap.Value == 240 && oreMap.Type.Contains("Platinum_01") == true) { oreMap.Type = "Lithium"; oreMap.Start = 37; oreMap.Depth = 7; }

                    }

                }
                
                planet.OreMappings = oreList.ToArray();

            }

            var allVoxelMaterials = MyDefinitionManager.Static.GetVoxelMaterialDefinitions();

            foreach (var def in allVoxelMaterials)
            {

                var voxelMaterial = def as MyVoxelMaterialDefinition;

                if (voxelMaterial.Id.SubtypeName == "Cobalt_01") { voxelMaterial.SpawnsInAsteroids = false; }
                if (voxelMaterial.Id.SubtypeName == "Magnesium_01") { voxelMaterial.SpawnsInAsteroids = false; }
                if (voxelMaterial.Id.SubtypeName == "Gold_01") { voxelMaterial.SpawnsInAsteroids = false; }
                if (voxelMaterial.Id.SubtypeName == "Platinum_01") { voxelMaterial.SpawnsInAsteroids = false; }
                if (voxelMaterial.Id.SubtypeName == "Uraninite_01") { voxelMaterial.SpawnsInAsteroids = false; }
                if (voxelMaterial.Id.SubtypeName == "Coal") { voxelMaterial.SpawnsInAsteroids = false; }
                if (voxelMaterial.Id.SubtypeName == "OilSand") { voxelMaterial.SpawnsInAsteroids = false; }
                if (voxelMaterial.Id.SubtypeName == "Sulfur") { voxelMaterial.SpawnsInAsteroids = false; }
                if (voxelMaterial.Id.SubtypeName == "Lithium") { voxelMaterial.SpawnsInAsteroids = false; }
                if (voxelMaterial.Id.SubtypeName == "Titanium") { voxelMaterial.SpawnsInAsteroids = false; }
                if (voxelMaterial.Id.SubtypeName == "Petzite_01") { voxelMaterial.SpawnsInAsteroids = false; }
                if (voxelMaterial.Id.SubtypeName == "Cooperite_01") { voxelMaterial.SpawnsInAsteroids = false; }
                if (voxelMaterial.Id.SubtypeName == "Niggliite_01") { voxelMaterial.SpawnsInAsteroids = false; }
                if (voxelMaterial.Id.SubtypeName == "Carnotite_01") { voxelMaterial.SpawnsInAsteroids = false; }

            }

        }


    }

}