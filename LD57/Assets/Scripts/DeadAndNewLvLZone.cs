using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadAndNewLvLZone : MonoBehaviour
{
    [SerializeField] private float _zoneDeadY;
    [SerializeField] private GameObject _player;
    public bool End { private get; set; } = false;
    private void Update()
    {
        if(_player.transform.position.y < _zoneDeadY)
        {
            SceneManager.LoadScene(1);
        }
        if (_player.transform.position.y < _zoneDeadY && End)
        {
            SceneManager.LoadScene(2);
        }
    }
}
