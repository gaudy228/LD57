using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private int _maxCountEnemy;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private List<Transform> _spawns;
    private int _curCountEnemy;
    [SerializeField] private float _minKD;
    [SerializeField] private float _maxKD;
    private bool _canSpawnEnemy = true;
    private void Start()
    {
        _curCountEnemy = _maxCountEnemy;
    }
    private void Update()
    {
        if(_canSpawnEnemy && _curCountEnemy > 0)
        {
            Instantiate(_enemy, _spawns[Random.Range(0, _spawns.Count)].position, Quaternion.identity);
            _curCountEnemy--;
            
            StartCoroutine(KDBetweenSpawn());
        }
        if(_curCountEnemy <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
    private IEnumerator KDBetweenSpawn()
    {
        _canSpawnEnemy = false;
        yield return new WaitForSeconds(Random.Range(_minKD, _maxKD));
        _canSpawnEnemy = true;
    }
}
