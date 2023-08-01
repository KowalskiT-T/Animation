using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    [SerializeField] private Animator _animator;
   
    public void OnCLickAnimationWalk(bool MovementOn)
    {       
       _animator.SetBool("IsWalking", MovementOn);
    }

    public void OnClickAnimationDie()
    {
        _animator.SetTrigger("Died");
    }

    public void OnAttackAnimation()
    {
        _animator.SetTrigger("Attacked");
    }

}
