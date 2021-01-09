﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        // When target is hit
        if (col.gameObject.tag == "Bullet")
        {
            Debug.Log("Target was Hit!");
            source.Play();
            Destroy(col.gameObject);
            Destroy(gameObject);
            Score.AddScore();
        }
    }

}