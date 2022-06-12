using System;

public class Player : IPlayer
{
    public float Health { get; set; }
    public float MaxHealth { get; set; }

    public Player()
    {
        MaxHealth = 100;
        Health = MaxHealth;
    }
}
