using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerFly : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    private Rigidbody2D _rb;
    private int _countAfterWalls = 10;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = Vector3.zero;
            _rb.AddForce(new Vector2(_rb.velocity.x, _jumpForce), ForceMode2D.Impulse);
        }
        if(_countAfterWalls <= 0)
        {
            SceneManager.LoadScene(4);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("WallDie"))
        {
            SceneManager.LoadScene(3);
        }
        if (collision.gameObject.CompareTag("Bonus"))
        {
            _countAfterWalls--;
        }
    }
}
