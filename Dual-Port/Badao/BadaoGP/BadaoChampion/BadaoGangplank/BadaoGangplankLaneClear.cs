﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeagueSharp;
using LeagueSharp.Common;
using SharpDX;
using Color = System.Drawing.Color;
using EloBuddy;
using EloBuddy.SDK;

using TargetSelector = PortAIO.TSManager; namespace BadaoKingdom.BadaoChampion.BadaoGangplank
{
    public static class BadaoGangplankLaneClear
    {
        public static void BadaoActivate()
        {
            Game.OnUpdate += Game_OnUpdate;
        }

        private static void Game_OnUpdate(EventArgs args)
        {
            if (PortAIO.OrbwalkerManager.isLaneClearActive || !PortAIO.OrbwalkerManager.isLaneClearActive)
                return;
            if (!BadaoGangplankVariables.LaneQ)
                return;
            foreach (Obj_AI_Minion minion in MinionManager.GetMinions(BadaoMainVariables.Q.Range).OrderBy(x => x.Health))
            {
                if (minion.BadaoIsValidTarget() && BadaoMainVariables.Q.GetDamage(minion) >= minion.Health)
                {
                    BadaoMainVariables.Q.Cast(minion);
                }
            }
        }
    }
}
