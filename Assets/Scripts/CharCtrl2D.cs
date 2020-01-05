using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharCtrl2D : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody2D rBody2D;
    void Start()
    {
        rBody2D = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate() //runs constantly
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        rBody2D.velocity = new Vector2(x, y) * speed;
        rBody2D.angularVelocity = 0.0f;
    }
}
