using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCombat : MonoBehaviour
{
    public int playerHp = 200;
    public Text hp;

    private float timer;
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name);
        switch (other.gameObject.tag)
        {
            case "enemy1":
            {
              //  other.gameObject.GetComponent<>()
              playerHp -= 5;
              break;
            }
            case "enemy2":
            {
                playerHp -= 4;
                break;
            }
            case "enemy3":
            {
                playerHp -= 5;
                break;
            }
            case "meds":
            {
                playerHp += 50;
                Destroy(other.gameObject);
                break;
            }


        }
    }

    private void Update()
    {
        hp.text = "Health "+ playerHp.ToString();
    }
    
}
