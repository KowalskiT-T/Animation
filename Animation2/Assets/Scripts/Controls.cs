using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Controls : MonoBehaviour
{
    private const float _speed = 0.1f;
    private bool _isMoving = false;
    private bool _died;

    [SerializeField] private UnityEvent<bool> _startWalking;
    [SerializeField] private UnityEvent _death;

    private void Update()
    {
        Walk();
    }

    private void Walk()
    {        
        if (_isMoving && !_died) {
            transform.Translate(new Vector3(5, 0, 0) * Time.deltaTime * _speed);           
        }       
    }

    public void BeginEndMovement()
    {
        if(!_isMoving && !_died)
        {
            _isMoving = true;
        }
        else
        {
            _isMoving = false;
        }
        _startWalking.Invoke(_isMoving);
    }

     public void SomeoneDied()
     {
        _died = true;
        _death.Invoke();
     }
}
