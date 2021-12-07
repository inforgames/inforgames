using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform AttackPoint;
    public Transform norotobject;
    public Rigidbody2D rb;
    public float bulletspeed = 10;
    private float nextfire;
    public float cooldown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(Time.time > nextfire)
            {
                nextfire = Time.time + cooldown;
                Instantiate(bullet, AttackPoint.position, norotobject.rotation);
            }
            
            //Instantiate(bullet, AttackPoint.position, norotobject.rotation);
        }
    }
}
