using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Fruit : MonoBehaviour
{
    public GameObject sliced;
    

    public void SliceThatFruit()
    {
        GameObject inst = (GameObject)Instantiate(sliced, transform.position, transform.rotation);
        Destroy(gameObject);

        Rigidbody[] rbSliced = inst.transform.GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rb in rbSliced)
        {
            rb.transform.rotation = Random.rotation;
            rb.AddExplosionForce(Random.Range(300,700), transform.position, 3f);
        }

        FindObjectOfType<GameManager>().ScoreAdd(1);
        Destroy(inst.gameObject, 5f);
        Destroy(gameObject);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Blade b = other.GetComponent<Blade>();

        if (!b)
        {
            return;
        }
        SliceThatFruit();
        
    }

    private void Update()
    {
        
        
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            SliceThatFruit();
        }*/
    }
}
