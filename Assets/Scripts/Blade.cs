using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{

    public Rigidbody2D rb;
    public Collider2D col;
    public float min = 0.1f;
    private Vector3 lastPos;
    private Vector3 mouseVel;
    
    
    
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BladeCursor();
        col.enabled = isMoving();
    }

    void BladeCursor()
    {

        var mouse = Input.mousePosition;
        mouse.z = 10;
        rb.position = Camera.main.ScreenToWorldPoint(mouse);
    }

    bool isMoving()
    {
        Vector3 curPos = transform.position;
        float move = (lastPos - curPos).magnitude;
        lastPos = curPos;

        if (move > min)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
