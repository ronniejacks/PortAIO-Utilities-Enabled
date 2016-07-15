using EloBuddy;
using ExorAIO.Utilities;
using LeagueSharp;
using LeagueSharp.SDK.Core.Utils;

using TargetSelector = PortAIO.TSManager; namespace ExorAIO.Champions.Graves
{
    /// <summary>
    ///     The logics class.
    /// </summary>
    internal partial class Logics
    {
        /// <summary>
        ///     Called on do-cast.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="args">The args.</param>
        public static void Weaving(Obj_AI_Base sender, GameObjectProcessSpellCastEventArgs args)
        {
            if (!(args.Target is AIHeroClient) ||
                Invulnerable.Check(args.Target as AIHeroClient))
            {
                return;
            }

            /// <summary>
            ///     The E Combo Weaving Logic.
            /// </summary>
            if (Vars.E.IsReady() &&
                Vars.getCheckBoxItem(Vars.EMenu, "combo"))
            {
                Vars.E.Cast(Game.CursorPos);
                return;
            }

            /// <summary>
            ///     The W Combo Weaving Logic.
            /// </summary>
            if (Vars.W.IsReady() &&
                Vars.getCheckBoxItem(Vars.WMenu, "combo"))
            {
                Vars.W.Cast(Vars.W.GetPrediction(Targets.Target).CastPosition);
            }
        }
    }
}