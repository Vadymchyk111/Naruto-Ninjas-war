using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _attacker;

    private float _minSpawningDelay = 5f;
    private float _maxSpawningDelay = 10f;

    [SerializeField]private bool isSpawning = true;

    public bool IsSpawning { get { return isSpawning; } }
    IEnumerator Start()
    {
        while (isSpawning)
        {
            yield return new WaitForSeconds(Random.Range(_minSpawningDelay, _maxSpawningDelay));
            SpawnAttacker();
        }
    }
    private void SpawnAttacker()
    {
        Instantiate(_attacker, transform.position, transform.rotation);
    }
}

