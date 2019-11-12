using System.Collections;
using System.Collections.Generic;
using System.Numerics;
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
        
        timeleft -= Time.deltaTime;
        if(timeleft < 0)
        {
            spawn = true;
            timeleft = 30f;
            
            if (spawn == true)
            {
                MonsterMake(new Vector3());
                Debug.Log("made!");
                counter++;
                spawn = false;

            }
            
        }
    }


    void MonsterMake(Vector3 monPosition)
    {
        monsterhere = Instantiate(monsterprefab, monPosition, Quaternion.identity);
    }
}

