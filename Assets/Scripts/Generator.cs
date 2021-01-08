using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject boxToGenerate;

    void Update()
    {
        // When spacebar is hit
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // instantiate the box object
            Instantiate(boxToGenerate);
        }
    }

}