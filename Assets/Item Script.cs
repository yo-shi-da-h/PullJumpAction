using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public GameObject ItemPrefab;

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Enter");
        DestroySelf();
    }

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Exit");
    }
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
