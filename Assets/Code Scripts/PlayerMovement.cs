using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 5f;
    // Start is called before the first frame update
    public Rigidbody2D rb;
    Vector2 movement;
    void Start()
    {
    }

    // Update is called once per frame
    void Update(){
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate() {
        rb.MovePosition(rb.position + movement * runSpeed * Time.fixedDeltaTime);
    }
}
