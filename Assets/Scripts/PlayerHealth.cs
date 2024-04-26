using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private Image _healthBarAmount;

    public void TakeDamage(float _damage)
    {
        _healthBarAmount.fillAmount -= _damage;
        if(_healthBarAmount.fillAmount <= 0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
