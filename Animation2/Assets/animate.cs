using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate : MonoBehaviour
{
    Animator animator;
    Transform currentPosition;
    public bool walking;
    float speed = 0.1f;
    bool died;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Walk();
    }

    void Walk()
    {
        if (walking)
        {   
            transform.Translate(new Vector3(5, 0, 0) * Time.deltaTime * speed);
            animator.SetBool("IsWalking", true);
        }
        else { animator.SetBool("IsWalking", false); }
        
    }

    public void OnCLickWalk()
    {
        if(walking == false && died != true)
        {
            walking = true;
        }
        else
        {
            walking = false;
        }
    }

    public void OnClickDie()
    {
        died = true;
        walking = false;
        animator.SetTrigger("Died");
    }

    public void OnAttack()
    {
        walking = false;
        animator.SetTrigger("Attacked");
    }


}
