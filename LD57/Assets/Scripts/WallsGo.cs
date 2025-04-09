using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallsGo : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _pointDieWalls;
    private void FixedUpdate()
    {
        transform.Translate(Vector2.left * _speed * Time.deltaTime);
        if(transform.position.x < _pointDieWalls)
        {
            Destroy(gameObject);
        }
    }
}
