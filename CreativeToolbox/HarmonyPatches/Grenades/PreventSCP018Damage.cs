﻿using System;
using Grenades;
using HarmonyLib;

namespace CreativeToolbox
{
    [HarmonyPatch(typeof(Scp018Grenade), nameof(Scp018Grenade.Awake))]
    static class PreventSCP018Damage
    {
        public static bool Prefix(Scp018Grenade __instance)
        {
            if (CreativeToolbox.ConfigRef.Config.EnableGrenadeDamagePrevention)
            {
                __instance.damageHurt = 0;
                __instance.damageScpMultiplier = 0;
            }
            return true;
        }
    }
}
