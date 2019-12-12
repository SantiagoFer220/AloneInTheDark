using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCon : MonoBehaviour
{
   
    public int SceneNum = 0;

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider collision)

    {
        if (Input.GetKeyDown(KeyCode.F))
        {

            ChangeScene();
        }
    }






    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneNum);
    }
}