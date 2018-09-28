using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testAssignment : MonoBehaviour
{

    public int userValue;
    int dice = 10;
    public int playerHP;
    public int dragonHP;
    bool start = false;
    int dragonHitChance;
    int ultimateDragonKnightSlayer;
    int playerMinDamage;
    int playerMaxDamage;








    void Uppgift1()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue += 2;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue /= 2;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }
    }

    void Uppgift2()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            dice += (Random.Range(1, 7)) - (Random.Range(1, 7));
            print(dice);
        }
    }
    void Uppgift3()
    {
        if (start == false)
        {
            
            playerHP = 100;
            dragonHP = (Random.Range(100, 151));
            ultimateDragonKnightSlayer = Random.Range(1, 11);
            if (ultimateDragonKnightSlayer == 1)

            {
                dragonHP = dragonHP * 2;
            }
            start = true;

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dragonHitChance = (Random.Range(0, 2));
            if (dragonHitChance >= 1)
            {
                playerHP -= (Random.Range(10, 21));


            }
           // fkn ta tag i!!! dragonHP -= (Random.Range(Random.Range(3, 5)));
        }
        if (dragonHP <= 0)
        {
            print("player wins");
            start = false;
        }
        if (playerHP <= 0)
        {
            print("you died");
            start = false;
        }
    }

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3();
    }

}
