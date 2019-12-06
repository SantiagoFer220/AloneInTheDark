using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem2 : MonoBehaviour
{
    public int hp;
    public bool isdead;
    public bool letplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "monster")
        {
          HurtPlayer(2);
        }
    }
    void HurtPlayer(int amount)
    {
        hp -= amount;
        Debug.Log("health left:"+ hp);
        if (hp <= 0)
        {
            Debug.Log("Im dead!");
            isdead = true;
        }

        if (isdead)
        {
            //Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            letplay = !letplay;
        }
    }
}

