using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditions : MonoBehaviour {
    public bool ifBool;
    public int value;

    // Use this for initialization
    void Start()
    {
        if (ifBool == true)
        {
            print("ja");
        }
        else
        {
            print("nej");
        }

        
    }
    // Update is called once per frame

    // != inte lika med 
    // == lika med
    // < mindre än
    // > större än
    // <= mindre eller lika med 
    // >= större eller lika med
    // && och (shift 6)
    // || eller (altgr <)
    void Update () {
        if(Input.GetKeyDown(KeyCode.E))
        {
            print("Javla Tuff");
           value = Random.Range(0, 10);
        }

        //if (value != 10)
        //{
        //    print("correct");
        //}
        //else
        //{
        //    print("incorrect");
        //}
    }
}
   


   
        
