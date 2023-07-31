using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private Transform _currentPosition;

    private bool _died;   
    private bool _walking;

    private const float _speed = 0.1f;

    private void Update()
    {
        Walk();
    }

    private void Walk()
    {
        if (_walking)
        {   
            transform.Translate(new Vector3(5, 0, 0) * Time.deltaTime * _speed);
            _animator.SetBool("IsWalking", true);
        }
        else { _animator.SetBool("IsWalking", false); }
        
    }

    public void OnCLickWalk()
    {
        if(_walking == false && _died != true)
        {
            _walking = true;
        }
        else
        {
            _walking = false;
        }
    }

    public void OnClickDie()
    {
        _died = true;
        _walking = false;
        _animator.SetTrigger("Died");
    }

    public void OnAttack()
    {
        _walking = false;
        _animator.SetTrigger("Attacked");
    }


}
