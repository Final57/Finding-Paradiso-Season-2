# Finding-Paradiso-Season-2

A Space Engineers Mod and ModAdjusted Files

## TODO

### Modadjuster Compatibility

- [ ] Write Modadjuster compat for Ship Core Framework
- [ ] Write Modadjuster compat for Planets and real gas giants
- - [x] Write OreReamapping for Satreus
- - [ ] Write OreReamapping for Komorebi
- - [ ] Write OreReamapping for ?
- - [ ] Write OreReamapping for ?
- [ ] Write Modadjuster compat to replace industrial overhaul compat mods
- - [x] Write Modadjuster compat for Better Stone & Industrial Overhaul
- - [x] Write Modadjuster compat for Paint Mod (Replaces <https://steamcommunity.com/workshop/filedetails/?id=2614870437>)
- - [x] Write Modadjuster compat for Rotary Airlock (Replaces <https://steamcommunity.com/workshop/filedetails/?id=2937319543>)
- - [x] Write Modadjuster compat for Rebel Lights (Replaces <https://steamcommunity.com/workshop/filedetails/?id=2787966098>)
- - [x] Write Modadjuster compat for Moisture Vaporator (Replaces <https://steamcommunity.com/workshop/filedetails/?id=2923491399>)
- - [x] Write Modadjuster compat for Binoculars (Replaces <https://steamcommunity.com/workshop/filedetails/?id=2960215269>)
- - [x] Write Modadjuster compat for Federal Logistics (Replaces <https://steamcommunity.com/workshop/filedetails/?id=2923120747>)
- - [x] Write Modadjuster compat for ResourceNodes (Replaces <https://steamcommunity.com/sharedfiles/filedetails/?id=2923551981>)
- - [x] Write modadjuster compat for Aryx drive systems (Replaces <https://steamcommunity.com/sharedfiles/filedetails/?id=3003196825>)
- [x] Write modadjuster compat for highpower offset spotlight
- [x] Write Modadjuster compat for highpower spotlight
- [x] Write Modadjuster compat for AQD Concrete
- [x] Write Modadjuster compat for heavy XL blocks
- [x] Write Modadjuster compat for AQD Airlocks
- [x] Write Modadjuster compat for OmniArc Tools
- [x] Write Modadjuster compat for Consolidation Propulsion
- [ ] Write Modasjuster compat for Railway Builder
- [ ] Write Modadjuster compat for Mothership blocks
- [ ] Write modadjuster compat for AWE
- - [x] Write Modadjust compat for AWE Components
- - [ ] Write Modadjust compat for AWE Ammunition
- - [X] Write Modadjust compat for AWE CubeBlocks
- - [ ] Tune CubeBlocks for progression

### Shipcore Configuration

- [x] Write Shipcore config based on "arcane cores" <https://steamcommunity.com/sharedfiles/filedetails/?id=3552605473> - NOTE: Bug Alien for ship/base/rover classes
- - [x] Write Block Groups
- - [x] Use Models from Arcane Cores and create Blocks
- - [x] Create Upgrade Modules
- - [x] Create Ship Cores
- - [x] Use Alien's Spreadsheet to create ship classes
- - [ ] NEEDS REVIEW

### Mod Dependencies

- [ ] Create mod dependencies for NPC mods - Harass Alien, Scarlet, and Lucian for ships

### Upgrades & Replacements

- [ ] Replace Prospector 2 with Prospector 3 (if and when available)
- [ ] Replace AWE with AWE 3 (if and when available)

### Server Side Configurations

- [ ] Write Server Side Config for WeaponCore
- [ ] Write Server Side Config for RelativeTopSpeed
- [ ] Write Server Side Config for DynamicArmor
- [ ] Write Server Side Config for MoistureVaporator
- [ ] Write Server Side Config for HeavierArmor
- [ ] Write Server Side Config for Beacon Signals
- [ ] Write Server Side Config for WCRadar
- [ ] Write Server Side Config for AwwScrap (and AwwScrapIFoundYourCrap)
- [ ] Write Server Side Config for FunLightning
- [x] Write Server Side Config for RealGasGiants
- [x] Write Server Side Config for RealStars

## World Notes

- Setting up the world; <https://steamcommunity.com/sharedfiles/filedetails/?id=3576413253>
  - Call world spawn for Cauldron
    - /CSP.RealGasGiant.900000.0.0.0
    - Use Following PlanetInfo in GasGiants config.xml
  - Call world spawn for Satreus
    - /CSP.Satreus.60000.1783652.800728.-268909
  - Call world spawn for Komorebi
    - /CSP.Komorebi.45000.-191052.-983046.2606687

```xml
<RealGasGiantsSettingsConfig xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">
  <OverrideFromConfig>true</OverrideFromConfig>
  <GasGiantBlocksSun>true</GasGiantBlocksSun>
  <GasGiantsHaveAtmoGlobal>true</GasGiantsHaveAtmoGlobal>
  <SetGlobalNoAsteroids>true</SetGlobalNoAsteroids>
  <CanSpawnOnGasGiants>false</CanSpawnOnGasGiants>
  <EnableGasGiantWindTurbines>false</EnableGasGiantWindTurbines>
  <UseLensFlareOccluder>true</UseLensFlareOccluder>
  <RingParticleLevel>2</RingParticleLevel>
  <GasGiantInfoList>
    <GasGiantConfigInfo PlanetName="RealGasGiant-480942381d19000">
      <PlanetCustomName>Cauldron</PlanetCustomName>
      <Radius>900</Radius>
      <PlanetColor X="255" Y="210" Z="190" />
      <PlanetSkin>Cauldron</PlanetSkin>
      <AtmoInfo>
        <AirDensity>3</AirDensity>
        <OxygenDensity>0</OxygenDensity>
        <WindSpeed>300</WindSpeed>
      </AtmoInfo>
      <RingInfo>
        <HasRing>false</HasRing>
        <RingSkin>Default1</RingSkin>
        <RingNormal X="0" Y="10" Z="1" />
        <RingColor X="255" Y="210" Z="190" />
        <RingLightMult>0.05</RingLightMult>
        <RingShadowMult>0.15</RingShadowMult>
        <RingInnerScale>1.5</RingInnerScale>
        <RingOuterScale>2.5</RingOuterScale>
        <RingLayerSpacingScale>1</RingLayerSpacingScale>
        <RingRotationPeriodSeconds>7200</RingRotationPeriodSeconds>
        <ConstrainNearbyAsteroidsToRing>true</ConstrainNearbyAsteroidsToRing>
        <ShadowOnRingEnabled>true</ShadowOnRingEnabled>
        <CollectRingResources>true</CollectRingResources>
        <CollectResourceRingSubtypeId>Ice</CollectResourceRingSubtypeId>
        <CollectResourceRingAmount>100</CollectResourceRingAmount>
        <EnabledDraw>true</EnabledDraw>
        <EnabledParticle>true</EnabledParticle>
      </RingInfo>
      <RingsInfo>
        <RingConfigInfo>
          <HasRing>true</HasRing>
          <RingSkin>Default2</RingSkin>
          <RingNormal X="0" Y="10" Z="1" />
          <RingColor X="255" Y="230" Z="200" />
          <RingLightMult>0.15</RingLightMult>
          <RingShadowMult>0.05</RingShadowMult>
          <RingInnerScale>1.5</RingInnerScale>
          <RingOuterScale>2.5</RingOuterScale>
          <RingLayerSpacingScale>0.05</RingLayerSpacingScale>
          <RingRotationPeriodSeconds>7200</RingRotationPeriodSeconds>
          <ConstrainNearbyAsteroidsToRing>true</ConstrainNearbyAsteroidsToRing>
          <ShadowOnRingEnabled>true</ShadowOnRingEnabled>
          <CollectRingResources>true</CollectRingResources>
          <CollectResourceRingSubtypeId>Ice</CollectResourceRingSubtypeId>
          <CollectResourceRingAmount>1</CollectResourceRingAmount>
          <EnabledDraw>true</EnabledDraw>
          <EnabledParticle>true</EnabledParticle>
        </RingConfigInfo>
      </RingsInfo>
      <InteriorInfo>
        <AsteroidRemoval>true</AsteroidRemoval>
        <PressureDamagePlayers>true</PressureDamagePlayers>
        <PressureDamageGrids>true</PressureDamageGrids>
      </InteriorInfo>
      <ResourceInfo>
        <CollectPlanetResources>true</CollectPlanetResources>
        <CollectResourceUpperSubtypeId>Ice</CollectResourceUpperSubtypeId>
        <CollectResourceUpperAmount>10</CollectResourceUpperAmount>
        <CollectResourceLowerSubtypeId>Ice</CollectResourceLowerSubtypeId>
        <CollectResourceLowerAmount>50</CollectResourceLowerAmount>
      </ResourceInfo>
      <GravityStrength>2</GravityStrength>
      <GravityFalloff>7</GravityFalloff>
      <DayLengthSeconds>7200</DayLengthSeconds>
      <SpinCounterClockwise>true</SpinCounterClockwise>
    </GasGiantConfigInfo>
  </GasGiantInfoList>
  <PlanetRingInfoList />
</RealGasGiantsSettingsConfig>
```

## Workshop Mod List

### Server Utitilies and Performance

```text
ID          Name                            URL
3017795356  ModAdjustver v2                 https://steamcommunity.com/workshop/filedetails/?id=3017795356
2596667376  Physics Shape Saver             https://steamcommunity.com/workshop/filedetails/?id=2596667376  
3032417765  MultiplayerPredictionSwitcher (Interpolated serverside grid control)    https://steamcommunity.com/workshop/filedetails/?id=3032417765
3237179787  Console Spawn Planets           https://steamcommunity.com/sharedfiles/filedetails/?id=3237179787
```

### World Requirements

#### Planets

```text
ID          Name                            URL
3232085677  Real Gas Giants                 https://steamcommunity.com/sharedfiles/filedetails/?id=3232085677
3152436752  Real Stars                      https://steamcommunity.com/workshop/filedetails/?id=3152436752
3576683005  Cauldron System                 https://steamcommunity.com/sharedfiles/filedetails/?id=3576683005
3309805284  Komorebi                        https://steamcommunity.com/sharedfiles/filedetails/?id=3309805284
2266665708  Satreus                         https://steamcommunity.com/sharedfiles/filedetails/?id=2266665708
```

#### Mechanics

```text
ID          Name                            URL
2344068716  Industrial Overhaul - v1.7.4    https://steamcommunity.com/workshop/filedetails/?id=2344068716
406244471   Better Stone v7.1.0             https://steamcommunity.com/workshop/filedetails/?id=406244471
1542310718  AwwScrap                        https://steamcommunity.com/workshop/filedetails/?id=1542310718
2590528047  AwwScrap: I Found Your Crap!    https://steamcommunity.com/workshop/filedetails/?id=2590528047
3046477519  FunLightning                    https://steamcommunity.com/workshop/filedetails/?id=3046477519
1359618037  Relative Top Speed              https://steamcommunity.com/workshop/filedetails/?id=1359618037
3552595651  Ship Core Framework (3.0.6)     https://steamcommunity.com/sharedfiles/filedetails/?id=3552595651
```

#### NPCs & Creatures

```text
ID          Name                            URL
2596208372  AiEnabled v1.9                  https://steamcommunity.com/workshop/filedetails/?id=2596208372
3105413080  SandWorm                        https://steamcommunity.com/workshop/filedetails/?id=3105413080
```

### Block Mods

```text
ID          Name                            URL
2303516760  High-power Offset Spotlight     https://steamcommunity.com/workshop/filedetails/?id=2303516760
1204806594  High-power Spotlight            https://steamcommunity.com/workshop/filedetails/?id=1204806594
2394430829  Aryx-Lynxon Drive Systems       https://steamcommunity.com/workshop/filedetails/?id=2394430829
2971414972  Heavy XL Blocks                 https://steamcommunity.com/workshop/filedetails/?id=2971414972
709975763   Moisture Vaporator              https://steamcommunity.com/workshop/filedetails/?id=709975763
3208995513  Tank Tracks Framework & API     https://steamcommunity.com/workshop/filedetails/?id=3208995513
3225398014  Tank Track Pack: Morue          https://steamcommunity.com/sharedfiles/filedetails/?id=3225398014
2298956701  AQD - Concrete                  https://steamcommunity.com/sharedfiles/filedetails/?id=2298956701
3412657089  OmniCorp The OmniArc Project: Adv Tools https://steamcommunity.com/sharedfiles/filedetails/?id=3412657089 
3571696367  Railway Builder [v1.1]          https://steamcommunity.com/sharedfiles/filedetails/?id=3571696367
3078500424  Consolidation Propulsions       https://steamcommunity.com/sharedfiles/filedetails/?id=3078500424
```

### Mothership Dependencies

```text
ID          Name                            URL
3275951529  BucketBrigade                   https://steamcommunity.com/workshop/filedetails/?id=3275951529
2535079290  (AR) Windows Wall               https://steamcommunity.com/workshop/filedetails/?id=2535079290
3281242580  BDBB                            https://steamcommunity.com/workshop/filedetails/?id=3281242580
2863089693  [WCIS] Longer Seamless Industrial Conveyor Pipes    https://steamcommunity.com/workshop/filedetails/?id=2863089693
3281245938  SilentBoot                      https://steamcommunity.com/workshop/filedetails/?id=3281245938
2227123639  Middle Gate                     https://steamcommunity.com/workshop/filedetails/?id=2227123639
3030078884  XL Bridge Windows               https://steamcommunity.com/workshop/filedetails/?id=3030078884
```

###

```text
ID          Name                            URL
3046287818  Beaconless Thrust/Power Signals - now with Beacons  https://steamcommunity.com/workshop/filedetails/?id=3046287818
```

### QOL Mods

```text
ID          Name                            URL
514062285   Build Info                      https://steamcommunity.com/workshop/filedetails/?id=514062285
1697184408  Build Vision 3.0                https://steamcommunity.com/workshop/filedetails/?id=1697184408
3195249208  BDAM                            https://steamcommunity.com/workshop/filedetails/?id=3195249208
1469072169  HUD Compass                     https://steamcommunity.com/workshop/filedetails/?id=1469072169
1662953858  Sneaky Sounds - Quieter Tools   https://steamcommunity.com/workshop/filedetails/?id=1662953858
3063543601  Remote3rdPerson                 https://steamcommunity.com/workshop/filedetails/?id=3063543601
2950011596  Flight Vector                   https://steamcommunity.com/workshop/filedetails/?id=2950011596
2946330043  Jump Alert                      https://steamcommunity.com/workshop/filedetails/?id=2946330043
2950431210  Status Report                   https://steamcommunity.com/workshop/filedetails/?id=2950431210
2947081810  Projector Highlighter           https://steamcommunity.com/workshop/filedetails/?id=2947081810
3289462382  Prospector 2                    https://steamcommunity.com/sharedfiles/filedetails/?id=3289462382
3594842497  High Pressure Bottles (Small in your inventory) https://steamcommunity.com/workshop/filedetails/?id=3594842497
3293251056  A Sight to Behold               https://steamcommunity.com/sharedfiles/filedetails/?id=3293251056
3598194640  Safe Speed                      https://steamcommunity.com/sharedfiles/filedetails/?id=3598194640
3230011090  Deformation-B-Gon               https://steamcommunity.com/sharedfiles/filedetails/?id=3230011090
```

### Weapon & Armour Mods

```text
ID          Name                            URL
2957590632  WC Radar                        https://steamcommunity.com/workshop/filedetails/?id=2957590632
2530716039  Aryx Weapon Enterprises Vol. 1 [WeaponCore] https://steamcommunity.com/workshop/filedetails/?id=2530716039
3029470356  Structural Reinforcement        https://steamcommunity.com/workshop/filedetails/?id=3029470356
3107050431  DynamicArmor                    https://steamcommunity.com/workshop/filedetails/?id=3107050431
3016620818  Heavier Armor for WeaponCore    https://steamcommunity.com/workshop/filedetails/?id=3016620818
```

### NPC Mods

```text
ID          Name                            URL
888457124   Suppress Vanilla Cargo Ships    https://steamcommunity.com/workshop/filedetails/?id=888457124
3169738640  Stick the Landing               https://steamcommunity.com/workshop/filedetails/?id=3169738640
3242721372  MESSpawnerUI                    https://steamcommunity.com/workshop/filedetails/?id=3242721372
```

### Cosmetic

```text
ID          Name                            URL
2277303535  L.U.C.1.A.N. Suit A.I. - Ghost Industries Ltd.  https://steamcommunity.com/workshop/filedetails/?id=2277303535
2752881305  Elite Dangerous Style Jump Effect   https://steamcommunity.com/workshop/filedetails/?id=2752881305
```

### Remove

```text
ID          Name                            URL
1555044803  NPC Weapon Upgrades             https://steamcommunity.com/workshop/filedetails/?id=1555044803
3102127379  Planetary Asteroid Rings    https://steamcommunity.com/workshop/filedetails/?id=3102127379
```
