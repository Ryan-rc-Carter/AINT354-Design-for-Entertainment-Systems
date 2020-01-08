using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAnimation : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator ani_Animator;

    void Awake()
    {
        ani_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            ani_Animator.SetBool("isWalking", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            ani_Animator.SetBool("isWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            ani_Animator.SetBool("isAttacking", true);
        }
        else if(Input.GetKeyUp(KeyCode.S))
        {
            ani_Animator.SetBool("isAttacking", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ani_Animator.SetBool("isDead", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            ani_Animator.SetBool("isDead", false);
        }
    }
}
