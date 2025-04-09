using UnityEngine;

public class SwitchPlatform : MonoBehaviour
{
    public GameObject activeFrame;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            activeFrame.SetActive(true);
        }

    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            activeFrame.SetActive(false);
        }
    }
}
