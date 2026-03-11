using TP2.Commun;

namespace TP2.Modele
{
    public class Attack
    {
        
        public int Id { get; private set; }
        public string Name { get; set; }
        public int CurrentPP { get; set; }
        public int MaxPP { get; set; }
        public int BasePower { get; set; }
        public int BasePrecision { get; set; }
        public AttackType Type { get; set; }

        public Attack(int id, string name, int basePower,
            int basePP, int basePrecision, AttackType type)
        {
            Id = id;
            Name = name;
            MaxPP = basePP;
            CurrentPP = MaxPP;
            BasePower = basePower;
            BasePrecision = basePrecision;
            Type = type;
        }

    }
}
