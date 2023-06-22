[System.Serializable]

public class Weapon : Item
{
    public int damage;
    public int decay;
    public int ammo;

    public Weapon(string name, int count, int itemDam, int itemDecay, int itemAmmo) : base(name, count)
    {
        damage = itemDam;
        decay = itemDecay;
        ammo = itemAmmo;
    }
}
