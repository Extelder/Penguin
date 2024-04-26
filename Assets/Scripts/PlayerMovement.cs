using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidBody;
    private float _directionSpeed;
    

    public static PlayerMovement _player { get; private set; }

    private void Awake()
    {
        _player = this;
    }

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        _rigidBody.velocity = new Vector3(_directionSpeed, _rigidBody.velocity.y, _rigidBody.velocity.z);
        if(_directionSpeed <= -0.1f)
        {
            transform.localScale = new Vector3(0.399721235f, -0.399721235f, 0.399721235f);
        }
        else if(_directionSpeed >= 0.1f)
        {
            transform.localScale = new Vector3(0.399721235f, 0.399721235f, 0.399721235f);
        }
    }


    public void Move(float _speed)
    {
        _directionSpeed = _speed;
    }

    public void StopMove()
    {
        _directionSpeed = 0f;
    }
}
