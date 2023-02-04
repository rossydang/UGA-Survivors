using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 160f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update(){

    }

    void FixedUpdate() {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput *  runSpeed* Time.fixedDeltaTime);
        Debug.Log(transform.position);

        float vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * vertical *  runSpeed* Time.fixedDeltaTime);
    }
}
