using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruits : MonoBehaviour
{
    public GameObject[] fruit;
    public GameObject bomb;
    public Transform[] spawners;
    
    void Start()
    {
        StartCoroutine(Throw());
    }

    IEnumerator Throw()
    {
        while (true)
        {
            yield return  new WaitForSeconds(Random.Range(0.2f, 3f));

            Transform trans = spawners[Random.Range(0, spawners.Length)];
            GameObject go = null;
            float rand = Random.Range(0, 100);

            if (rand < 20)
            {
                go = bomb;
            }
            else
            {
                go = fruit[Random.Range(0, fruit.Length)];
            }
            
            GameObject Fruit = Instantiate(go, trans.position, trans.rotation);
            Fruit.GetComponent<Rigidbody2D>().AddForce(trans.transform.up*Random.Range(12f,16f), ForceMode2D.Impulse);
            //print("dupa");
            Destroy(Fruit, 5f);
        }
    }

    
}
