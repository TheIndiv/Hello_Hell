using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatActions : MonoBehaviour
{
    
    public int hp = 100;
    public static int shotgunDMG = 100;
    public static int LaserDMG = 7;
    

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "LaserGun":
            {
                hp -= shotgunDMG;
                break;
            }
            case "Shotgun":
            {
                hp -= LaserDMG;
                break;
            }
            
        }
        
        isDead();

    }

    void isDead()
    {
        if (hp < 0)
        {
            Death();
        }
    }

    void Death()
    {
        GameObject.Destroy(gameObject);
    }
}
