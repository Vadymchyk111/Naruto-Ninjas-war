using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineControler : MonoBehaviour
{
    [SerializeField] private AttackerSpawner _attackerSpawner;
    
    [SerializeField]private bool _needToAttack = false;

    private void Update()
    {
        if(_attackerSpawner != null)
        {
            if(_attackerSpawner.IsSpawning)
                _needToAttack = true;
            else _needToAttack = false;
        }
    }
}
