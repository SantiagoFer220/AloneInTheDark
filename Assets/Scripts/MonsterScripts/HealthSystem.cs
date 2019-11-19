using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int health;
    public int healthMax;
    public bool isdead;
    public bool letplay;
    

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
        return health/healthMax;
    }

    public void Damage(int DamageAmount)
    {
        health -= DamageAmount;
        if (health < 0)
        {
            isdead = true;
        }

        if (isdead)
        {
            Destroy(gameObject);
            letplay = !letplay;

        }
        /*if(letplay)
        {
            if (!gameObject.particleSystem.isPlaying)
            {
                gameObject.particleSystem.Play();
               particleSystem.enableEmission = true;
            }
            else
            {
                if (gameObject.particleSystem.isPlaying)
                {
                    gameObject.particleSystem.Stop();
                }
            }
        }

        
    }
    
   
}
