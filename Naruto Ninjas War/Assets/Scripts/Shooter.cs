using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject _projectile, gun;
    [SerializeField] private float _timeToAttack = 2f;

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(_timeToAttack);
            Fire();
        }
    }

    private void Fire()
    {
        Instantiate(_projectile, gun.transform.position, _projectile.transform.rotation);
    }
}
