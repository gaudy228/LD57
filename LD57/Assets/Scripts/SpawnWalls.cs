using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalls : MonoBehaviour
{
    [SerializeField] private GameObject _walls;
    [SerializeField] private float _timeSpawn;
    [SerializeField] private float _min;
    [SerializeField] private float _max;
    private bool _canSpawnEnemy = true;
    private void Update()
    {
        if (_canSpawnEnemy)
        {
            Instantiate(_walls, new Vector2(transform.position.x, Random.Range(_min, _max)), Quaternion.identity);


            StartCoroutine(KDBetweenSpawn());
        }
    }
    private IEnumerator KDBetweenSpawn()
    {
        _canSpawnEnemy = false;
        yield return new WaitForSeconds(_timeSpawn);
        _canSpawnEnemy = true;
    }
}
