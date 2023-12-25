using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    float horizontal;
    float vertical;
    float jump;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        jump = Input.GetAxis("Jump");

        Vector3 Move = new Vector3(horizontal * Time.deltaTime * speed, jump * Time.deltaTime * speed, vertical * Time.deltaTime * speed);
        transform.Translate(Move.x, Move.y, Move.z);

        
        if(Move.y > 0)
        {
            animator.SetBool("IsJump", true);
            return;
        }
        else 
        {
            animator.SetBool("IsJump", false);
        }
    }
}
