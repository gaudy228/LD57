using UnityEngine;
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _timeLife;
    [SerializeField] protected float _damage;
    void Start()
    {
        Destroy(gameObject, _timeLife);
    }
    void FixedUpdate()
    {
        transform.Translate(Vector2.up * _speed * Time.deltaTime);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
