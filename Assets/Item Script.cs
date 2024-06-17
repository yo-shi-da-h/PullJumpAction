using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    //public GameObject ItemPrefab;
    private Animator animator;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Enter");
        //DestroySelf();
        animator.SetTrigger("Get");
        audioSource.Play();
    }
    // Update is called once per frame
    void Update()
    {
        //animator.SetTrigger("Get");

    }
    private void DestroySelf()
    {
        Destroy(gameObject);
    }
    

    private void OnTriggerStay(Collider other)
    {
        //Debug.Log("Stay");
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Exit");
    }
   
}
