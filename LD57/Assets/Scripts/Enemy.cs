using UnityEngine;
public class Enemy : MonoBehaviour
{
    private GameObject player;
    private PlayerHP playerHP;
    [SerializeField] private float speed;
    [SerializeField] private float damage;
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerHP = player.GetComponent<PlayerHP>();
    }
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerHP.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
