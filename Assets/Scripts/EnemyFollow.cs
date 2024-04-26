using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    [SerializeField] private float _followSpeed;
    private int _health = 100;



    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.TryGetComponent<PlayerHealth>(out PlayerHealth _playerHealth))
        {
            _playerHealth.TakeDamage(0.05f);
        }
    }
    private void OnTCollisionStay(Collision other)
    {
        if(other.gameObject.TryGetComponent<PlayerHealth>(out PlayerHealth _playerHealth))
        {
            _playerHealth.TakeDamage(0.01f);
        }
    }

    public void TakeDamage(int _damage)
    {
        _health -= _damage;
        if(_health <= 0)
        {
            PlayerGun._playerGun.AddKill();
            Destroy(gameObject);
        }
    }
}
