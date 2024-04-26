using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Start()
    {
        if(PlayerMovement._player.transform.localScale == new Vector3(0.399721235f, -0.399721235f, 0.399721235f))
        {
            _speed = -_speed;
        }
    }

    void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<EnemyFollow>(out EnemyFollow _enemy))
        {
            _enemy.TakeDamage(10);
        }
        Destroy(gameObject);
    }
}
