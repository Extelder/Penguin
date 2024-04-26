using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerJump : MonoBehaviour
{
    private Rigidbody _rigdBody;

    [SerializeField] private float _jumpForce;
    private bool _onGround;

    private void Start()
    {
        _rigdBody = GetComponent<Rigidbody>();
    }
    public void Jump()
    {
        if(_onGround == true)
        {
            _rigdBody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    } 

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.TryGetComponent<Ground>(out Ground _ground))
        {
            _onGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Ground>(out Ground _ground))
        {
            _onGround = false;
        }
    }
}
