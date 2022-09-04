using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiMoving : MonoBehaviour
{
    [Range(0f, 10f)]
    [SerializeField] private float _moveSpeed = 2f;
    void Update()
    {
        transform.Translate(Vector2.up * _moveSpeed * Time.deltaTime);
    }
}
