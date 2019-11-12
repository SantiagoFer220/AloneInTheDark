using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem
{
    private int health;
    private int healthMax;

    public HealthSystem(int healthMax)
    {
        this.healthMax = healthMax;
        health = healthMax;
    }

    public int Gethealth()
    {
        return health;
    }

    public float GetHealthPercent()
    {
        return health / healthMax;
    }

    public void Damage(int DamageAmount)
    {
        health -= DamageAmount;
        if (health < 0) health = 0;
    }
}
