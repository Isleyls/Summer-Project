[System.Serializable]

public class Weapon : Item
{
    public int damage;
    public int decay;
    public int ammo;
    public int rof;
    public string firetype;
    public string ammoType;

    public Weapon(string name, int count, int itemDam, int itemDecay, int itemAmmo, int ROF, string ft, string at) : base(name, count)
    {
        damage = itemDam;
        decay = itemDecay;
        ammo = itemAmmo;
        rof = ROF;
        firetype = ft;
        ammoType = at;
    }
}
