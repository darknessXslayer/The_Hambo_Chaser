using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_AI_Behaviour : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Hampo_Move.instance.follow = true;
        Debug.Log("trigger is work");
    }

    /*private void OnCollisionEnter(Collision Platform)
    {
        
    }*/
}
