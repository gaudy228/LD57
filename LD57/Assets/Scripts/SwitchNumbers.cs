using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SwitchNumbers : MonoBehaviour
{
    public int CurNumbers;
    [SerializeField] private TextMeshProUGUI _curNumbersText;
    [SerializeField] private PaswordCorrect _paswordCorrect;
    private void Start()
    {
        UpdateUI();
    }
    public void UpNumbers()
    {
        CurNumbers++;
        if( CurNumbers == 10)
        {
            CurNumbers = 0;
        }
        UpdateUI();
        _paswordCorrect.CheckCorrect();
    }
    public void DownNumbers()
    {
        CurNumbers--;
        if (CurNumbers == -1)
        {
            CurNumbers = 9;
        }
        UpdateUI();
        _paswordCorrect.CheckCorrect();
    }
    private void UpdateUI()
    {
        _curNumbersText.text = CurNumbers.ToString();
    }
}
