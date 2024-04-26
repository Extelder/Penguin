using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    [SerializeField] private GameObject _winCanvas;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _muzzle;
    [SerializeField] private float _timeToNextFire;
    private int _kills = 0;

    public static PlayerGun _playerGun { get; private set; }

    private void Awake() => _playerGun = this;

    public void Shoot() =>  Instantiate(_bullet, _muzzle.position, transform.rotation);
    public void AddKill()
    {
        _kills++;
        if(_kills == 7)
        {
            _winCanvas.SetActive(true);
        }
    }
}
