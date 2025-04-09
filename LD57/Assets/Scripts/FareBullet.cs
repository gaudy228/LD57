using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FareBullet : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _ganSpawn;
    [SerializeField] private float _timeKdBetweenFire;
    private bool _inKDBetweenFire = false;
    private void Update()
    {
        Fire();
    }
    private void Fire()
    {
        if (!_inKDBetweenFire && Input.GetMouseButton(0))
        {
            StartCoroutine(KDBetweenFire());
            Instantiate(_bullet, _ganSpawn.position, _ganSpawn.rotation);
        }
    }
    private IEnumerator KDBetweenFire()
    {
        _inKDBetweenFire = true;
        yield return new WaitForSeconds(_timeKdBetweenFire);
        _inKDBetweenFire = false;
    }
}
