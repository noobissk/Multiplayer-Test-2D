using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Movement : MonoBehaviour
{
    // Put script on the same object as RigidBody
    [SerializeField] float speed = 5;
    Rigidbody2D RB;
    Vector2 MoveInput;
    PhotonView View;
    void Start()
    {
        View = GetComponent<PhotonView>();
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (View.IsMine)
        {
            Inputs();
        }
    }

    void Inputs()
    {
        MoveInput.x = Input.GetAxisRaw("Horizontal");
        MoveInput.y = Input.GetAxisRaw("Vertical");
    }


    void FixedUpdate()
    {
        if (View.IsMine)
        {
            Move();
        }
    }
    void Move()
    {
        RB.AddForce(MoveInput.normalized * speed * 5, ForceMode2D.Force);
    }
}
