using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goose : MonoBehaviour
{
    public float upForce = 200f'
    private bool isDead = false;
    private Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead == false)
        {
            if (Input.GetButton("Jump"))
            {
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce
            }
        }
    }
}
