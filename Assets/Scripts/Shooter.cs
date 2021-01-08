using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject fireball;
    public Rigidbody2D body;
    public float speed;

    void Update()
    {
        body.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed);

        // When spacebar is hit
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // instantiate the fireball object            
            Instantiate(fireball,
                new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0),
                new Quaternion(0, 0, 0, 0)
            );
        }
    }

}