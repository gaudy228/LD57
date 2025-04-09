using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    [SerializeField] private List<string> _dial;
    [SerializeField] private List<string> _nameDial;
    [SerializeField] private List<GameObject> _heros;
    [SerializeField] private TextMeshProUGUI _dialogText;
    [SerializeField] private TextMeshProUGUI _nameText;
    private int _countDialog;
    private void Start()
    {
        Time.timeScale = 0;
        Next();
    }
    public void Next()
    {
        if(_dial.Count > _countDialog)
        {
            _dialogText.text = _dial[_countDialog];
            _nameText.text = _nameDial[_countDialog];
            for (int i = 0; i < _heros.Count; i++)
            {
                _heros[i].SetActive(false);
            }
            _heros[_countDialog].SetActive(true);
            _countDialog++;
        }
        else
        {
            Skip();
        }
    }
    public void Skip()
    {
        Time.timeScale = 1;
        for (int i = 0; i < _heros.Count; i++)
        {
            _heros[i].SetActive(false);
        }
        gameObject.SetActive(false);
    }
}
