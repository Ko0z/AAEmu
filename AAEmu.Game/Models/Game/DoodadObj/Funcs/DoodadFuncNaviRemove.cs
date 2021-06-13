﻿using AAEmu.Game.Models.Game.DoodadObj.Templates;
using AAEmu.Game.Models.Game.Units;

namespace AAEmu.Game.Models.Game.DoodadObj.Funcs
{
    public class DoodadFuncNaviRemove : DoodadFuncTemplate
    {
        public int ReqLaborPower { get; set; }
        
        public override void Use(Unit caster, Doodad owner, uint skillId, int nextPhase = 0)
        {
            //_log.Debug("DoodadFuncNaviRemove");
            owner.ToPhaseAndUse = false;
        }
    }
}
