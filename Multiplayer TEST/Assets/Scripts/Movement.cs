using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Put script on the same object as RigidBody
    [SerializeField] float speed = 5;
    Rigidbody2D RB;
    Vector2 MoveInput;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Inputs();
    }

    void Inputs()
    {
        MoveInput.x = Input.GetAxis("Horizontal");
        MoveInput.y = Input.GetAxis("Vertical");
    }


    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        RB.AddForce(MoveInput * transform.up * speed, ForceMode2D.Force);
    }
}
