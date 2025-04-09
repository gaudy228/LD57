using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody2D _rb;
    [SerializeField] private float _playerScale;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        _rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * _speed, _rb.velocity.y);
        if(Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.localScale = new Vector3(-_playerScale, _playerScale, _playerScale);
        }
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.localScale = new Vector3(_playerScale, _playerScale, _playerScale);
        }
    }
}
