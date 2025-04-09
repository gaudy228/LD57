using System;
using System.Collections.Generic;
using UnityEngine;

public class PaswordCorrect : MonoBehaviour
{
    [SerializeField] private int[] _pasword;
    private int _countCorrectChecks;
    public List<SwitchNumbers> numbers;
    [SerializeField] private SwitchScene _switchScene;
    public void CheckCorrect()
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i].CurNumbers == _pasword[i])
            {
                _countCorrectChecks++;
            }
        }
        if(_countCorrectChecks == numbers.Count)
        {
            _switchScene.LoadScene(1);
        }
        _countCorrectChecks = 0;
    }
}
