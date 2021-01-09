using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public Rigidbody2D starBody;
    public float speed;
    private bool sombrero = false;

    public Texture2D bottom;
    public Texture2D top;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        var v = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        Debug.DrawLine(starBody.position, starBody.position + v, Color.red);
        starBody.velocity = v * speed;

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (!sombrero)
            {
                sombrero = true;

                Texture2D combined = bottom.AlphaBlend(top);

                Sprite sprite = Sprite.Create(
                    combined,
                    new Rect(0, 0, combined.width, combined.height),
                    new Vector2(0.5f, 0.5f)
                );

                gameObject.GetComponent<SpriteRenderer>().sprite = sprite;

            }
        }
    }
}
