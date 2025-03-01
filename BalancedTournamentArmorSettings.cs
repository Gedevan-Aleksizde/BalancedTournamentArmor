﻿using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Base.Global;

namespace BalancedTournamentArmor
{
    public class BalancedTournamentArmorSettings : AttributeGlobalSettings<BalancedTournamentArmorSettings>
    {
        public override string Id => "BalancedTournamentArmor";

        public override string DisplayName => "Balanced Tournament Armor";

        public override string FolderName => "BalancedTournamentArmor";

        public override string FormatType => "json2";

        [SettingPropertyInteger("Troop Tier", 1, 6, "0", Order = 0, RequireRestart = false, HintText = "Troop tier for armor worn by tournament participants. Default is 1.")]
        [SettingPropertyGroup("Armor", GroupOrder = 0)]
        public int TroopTier { get; set; } = 1;

        [SettingPropertyBool("Heal Heroes to Full HP", Order = 0, RequireRestart = false, HintText = "Heal nobles, companions and the player to full HP. HP will revert after the tournament. Enabled by default.")]
        [SettingPropertyGroup("HP", GroupOrder = 1)]
        public bool ShouldHealHeroAgents { get; set; } = true;
    }
}
