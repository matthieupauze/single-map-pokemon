using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP2.Modele;

namespace TP2.Commun
{
    public static class AttacksDB
    {
        public readonly static List<Attack> ALL_ATTACKS;
        private static string MOVE_FILE = Properties.Resources.All_Attacks;

        static AttacksDB()
        {
            ALL_ATTACKS = new List<Attack>();
            PopulateList();
        }

        private static void PopulateList()
        {
            foreach (string line in MOVE_FILE.Split(new string[] { "\n" }, StringSplitOptions.None))
            {
                string[] stats = line.Split(',');

                int id = int.Parse(stats[0]);
                string name = stats[1];
                int basePower = string.IsNullOrEmpty(stats[3]) ? 1000 : int.Parse(stats[3]);
                int basePP = string.IsNullOrEmpty(stats[4]) ? 1000 : int.Parse(stats[4]);
                int baseAccuracy = string.IsNullOrEmpty(stats[5]) ? 1000 : int.Parse(stats[5]);
                AttackType type = (AttackType)int.Parse(stats[6]);

                Attack newAttack = new Attack(id, name.Capitalize(), basePower, basePP, baseAccuracy, type);
                ALL_ATTACKS.Add(newAttack);
            }
        }

        public static Attack[] GetDefaultAttacks()
        {
            return new Attack[4] { ALL_ATTACKS[0], ALL_ATTACKS[32], ALL_ATTACKS[52], ALL_ATTACKS[97] };
        }

    }
}
