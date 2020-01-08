using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MimicAnimation : MonoBehaviour
{

    private Animator ani_animator;

    // Start is called before the first frame update
    void Awake()
    {
        ani_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Series of input handlers to display a certain animation when a button is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            ani_animator.SetBool("isAttacking", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            ani_animator.SetBool("isAttacking", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ani_animator.SetBool("isDead", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            ani_animator.SetBool("isDead", false);
        }
    }
}
