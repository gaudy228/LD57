using UnityEngine;
public class TakeThing : MonoBehaviour
{
    [SerializeField] private GameObject _takeObject;
    [SerializeField] private GameObject _pressE;
    private bool _canInteract = false;
    private bool _isActive = true;
    private DeadAndNewLvLZone _deadAndNewLvLZone;
    private void Start()
    {
        _deadAndNewLvLZone = GetComponent<DeadAndNewLvLZone>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(_isActive)
            {
                _pressE.SetActive(true);
            }
            _canInteract = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _canInteract = false;
            if (_pressE != null)
            {
                _pressE.SetActive(false);
            }
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && _canInteract)
        {
            _isActive = false;
            _takeObject.SetActive(_isActive);
            _pressE?.SetActive(_isActive);
            _deadAndNewLvLZone.End = true;
        }
    }
}
