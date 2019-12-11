﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAnimation : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetBool("isAttacking", true);
        }
        else if(Input.GetKeyUp(KeyCode.S))
        {
            animator.SetBool("isAttacking", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetBool("isDead", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("isDead", false);
        }
    }
}
