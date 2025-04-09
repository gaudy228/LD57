using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] private float hp;
    public void TakeDamage(float damage)
    {
        hp -= damage;
        if(hp < 0)
        {
            hp = 0;
        }
        if(hp == 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
