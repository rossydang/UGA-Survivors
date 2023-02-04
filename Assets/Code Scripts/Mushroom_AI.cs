using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom_AI : MonoBehaviour
{
    public float speed = 2.5F;
    public Transform target;
    public float minimumDistance;
    public Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > minimumDistance && Vector2.Distance(transform.position, target.position) < 5 ) {
            speed = 2.5F;
            animator.SetFloat("mush_speed", Mathf.Abs(speed));
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else {
            speed = 0F;
            animator.SetFloat("mush_speed", Mathf.Abs(speed));
        }
    }
}
