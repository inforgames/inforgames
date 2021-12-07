using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletfly : MonoBehaviour
{
    public Rigidbody2D rb;
    private Shoot shoot;
    public float bulletspeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(Vector2.right * bulletspeed);
        transform.Translate(Vector2.right * bulletspeed);
    }
}
