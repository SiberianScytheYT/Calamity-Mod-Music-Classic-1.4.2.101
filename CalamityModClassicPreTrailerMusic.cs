using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.MusicLoader;

namespace CalamityModClassicPreTrailerMusic
{
    public class CalamityModClassicPreTrailerMusic : Mod
    {
        public static CalamityModClassicPreTrailerMusic Instance;

        public CalamityModClassicPreTrailerMusic()
    	{
            Instance = this;
        }

        public override void Load()
        {
            if (!Main.dedServ)
            {
                //Boss Music
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/AquaticScourge"), Find<ModItem>("AquaticScourgeMusicbox").Type, Find<ModTile>("AquaticScourgeMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/Astrageldon"), Find<ModItem>("AstrageldonMusicbox").Type, Find<ModTile>("AstrageldonMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/AstrumDeus"), Find<ModItem>("AstrumDeusMusicbox").Type, Find<ModTile>("AstrumDeusMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/LeftAlone"), Find<ModItem>("BrimmyMusicbox").Type, Find<ModTile>("BrimmyMusicbox").Type);
				AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/Murderswarm"), Find<ModItem>("BumblebirbMusicbox").Type, Find<ModTile>("BumblebirbMusicbox").Type);
				AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/Calamitas"), Find<ModItem>("CalamitasMusicbox").Type, Find<ModTile>("CalamitasMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/Void"), Find<ModItem>("CeaselessVoidMusicbox").Type, Find<ModTile>("CeaselessVoidMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/Crabulon"), Find<ModItem>("CrabulonMusicbox").Type, Find<ModTile>("CrabulonMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/Cryogen"), Find<ModItem>("CryogenMusicbox").Type, Find<ModTile>("CryogenMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/DesertScourge"), Find<ModItem>("DesertScourgeMusicbox").Type, Find<ModTile>("DesertScourgeMusicbox").Type);
				AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/YHARON"), Find<ModItem>("Yharon1Musicbox").Type, Find<ModTile>("Yharon1Musicbox").Type);
				AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/YHARONREBIRTH"), Find<ModItem>("Yharon2Musicbox").Type, Find<ModTile>("Yharon2Musicbox").Type);
				AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/DragonGod"), Find<ModItem>("Yharon3Musicbox").Type, Find<ModTile>("Yharon3Musicbox").Type);
				AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/RUIN"), Find<ModItem>("PolterghastMusicbox").Type, Find<ModTile>("PolterghastMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/Guardians"), Find<ModItem>("ProfanedGuardianMusicbox").Type, Find<ModTile>("ProfanedGuardianMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/ProvidenceTheme"), Find<ModItem>("ProvidenceMusicbox").Type, Find<ModTile>("ProvidenceMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/Ravager"), Find<ModItem>("RavagerMusicbox").Type, Find<ModTile>("RavagerMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/Signus"), Find<ModItem>("SignusMusicbox").Type, Find<ModTile>("SignusMusicbox").Type);
				AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/SirenLure"), Find<ModItem>("SirenIdleMusicbox").Type, Find<ModTile>("SirenIdleMusicbox").Type);
				AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/Siren"), Find<ModItem>("SirenMusicbox").Type, Find<ModTile>("SirenMusicbox").Type);
				AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/LeviathanAndSiren"), Find<ModItem>("LeviathanMusicbox").Type, Find<ModTile>("LeviathanMusicbox").Type);
				AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/Weaver"), Find<ModItem>("StormWeaverMusicbox").Type, Find<ModTile>("StormWeaverMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/SCG"), Find<ModItem>("SCalGMusicbox").Type, Find<ModTile>("SCalGMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/SCL"), Find<ModItem>("SCalLMusicbox").Type, Find<ModTile>("SCalLMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/SCE"), Find<ModItem>("SCalEMusicbox").Type, Find<ModTile>("SCalEMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/SCA"), Find<ModItem>("SCalAMusicbox").Type, Find<ModTile>("SCalAMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/ScourgeofTheUniverse"), Find<ModItem>("DoGMusicbox").Type, Find<ModTile>("DoGMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/UniversalCollapse"), Find<ModItem>("DoGP2Musicbox").Type, Find<ModTile>("DoGP2Musicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/HiveMind"), Find<ModItem>("HiveMindMusicbox").Type, Find<ModTile>("HiveMindMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/BloodCoagulant"), Find<ModItem>("PerforatorMusicbox").Type, Find<ModTile>("PerforatorMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/PlaguebringerGoliath"), Find<ModItem>("PlaguebringerMusicbox").Type, Find<ModTile>("PlaguebringerMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/SlimeGod"), Find<ModItem>("SlimeGodMusicbox").Type, Find<ModTile>("SlimeGodMusicbox").Type);

				//Biome Music
				AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/Sulphur"), Find<ModItem>("SulphurousMusicbox").Type, Find<ModTile>("SulphurousMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/TheAbyss"), Find<ModItem>("HigherAbyssMusicbox").Type, Find<ModTile>("HigherAbyssMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/TheDeepAbyss"), Find<ModItem>("AbyssLowerMusicbox").Type, Find<ModTile>("AbyssLowerMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/TheVoid"), Find<ModItem>("VoidMusicbox").Type, Find<ModTile>("VoidMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/Astral"), Find<ModItem>("AstralMusicbox").Type, Find<ModTile>("AstralMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/Calamity"), Find<ModItem>("CalamityMusicbox").Type, Find<ModTile>("CalamityMusicbox").Type);
                AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/Crag"), Find<ModItem>("CragMusicbox").Type, Find<ModTile>("CragMusicbox").Type);
				AddMusicBox(this, GetMusicSlot(this.Name + "/" +"Sounds/Music/SunkenSea"), Find<ModItem>("SunkenSeaMusicbox").Type, Find<ModTile>("SunkenSeaMusicbox").Type);
            }
        }

        public override void Unload()
        {
            Instance = null;
        }
    }
}