using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.Serialization;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;


public class MonsterCreate : MonoBehaviour

{
    public GameObject monsterprefab;
    public GameObject monsterhere;

    public float timeleft = 30f;

    public int counter;

    public bool spawn = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //timer for each monster spawn
        timeleft -= Time.deltaTime;
        if(timeleft < 0 && counter == 0)
        {
            spawn = true;
            timeleft = 30f;
            // 30 seconds, change as needed
            
            if (spawn == true && counter == 0)
            {
                // spawn event, adds (1) to counter in hierarchy
                MonsterMake(new Vector3());
                Debug.Log("made!");
                counter++;
                spawn = false;
            }
            else  if(counter == 1)
            {
                spawn = false;
                timeleft -= Time.deltaTime;
            }
            
            
        }
    }


    void MonsterMake(Vector3 monPosition)
    {
        // actual instantiation function
        monsterhere = Instantiate(monsterprefab, monPosition, Quaternion.identity);
    }
}

