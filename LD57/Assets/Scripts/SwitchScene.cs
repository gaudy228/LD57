using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    [SerializeField] private int _nScene;
    public void LoadScene(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
