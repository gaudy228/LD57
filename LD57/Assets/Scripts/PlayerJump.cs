
using System.Collections;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    private bool _canJump;
    private bool _firstJump = true;
    private bool _wall = false;
    private Rigidbody2D _rb;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Jump();
    }
    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _canJump)
        {
            _rb.velocity = Vector3.zero;
            _rb.AddForce(new Vector2(_rb.velocity.x, _jumpForce), ForceMode2D.Impulse);
            _firstJump = false;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && !_firstJump)
        {
            _rb.velocity = Vector3.zero;
            _rb.AddForce(new Vector2(_rb.velocity.x, _jumpForce), ForceMode2D.Impulse);
            _firstJump = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && _wall)
        {
            _rb.velocity = Vector3.zero;
            _rb.AddForce(new Vector2(_rb.velocity.x, _jumpForce), ForceMode2D.Impulse);
            _firstJump = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
        {
            _canJump = true;
            _firstJump = true;
        }
        if (collision.CompareTag("Wall"))
        {
            _wall = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
        {
            _canJump = false;
        }
        if (collision.CompareTag("Wall"))
        {
            _wall = false;
        }
    }
}
