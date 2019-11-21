using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        if (!Application.isPlaying) {


          //  Gizmos.DrawCube(transform.position, GetComponent<BoxCollider>().size);
        }
    }
}
