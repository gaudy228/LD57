using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    [SerializeField] private GameObject _interactObject;
    [SerializeField] private GameObject _pressE;
    private bool _canInteract = false;
    private bool _isActive = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        { 
            _pressE.SetActive(true);
            _canInteract = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _canInteract = false;
            if(_interactObject != null)
            {
                _interactObject.SetActive(false);
                _pressE.SetActive(false);
            }
        }
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && _canInteract)
        {
            _isActive = !_isActive;
            _interactObject.SetActive(_isActive);
            _pressE?.SetActive(!_isActive);
        }
    }
}
