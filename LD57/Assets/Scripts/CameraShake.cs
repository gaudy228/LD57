using Cinemachine;
using System;
using System.Collections;
using UnityEngine;
public class CameraShake : MonoBehaviour
{
    private CinemachineVirtualCamera _camera;
    private CinemachineBasicMultiChannelPerlin _channelPerlin;
    [SerializeField] private float strengtMax;
    [SerializeField] private float gainTime;
    private void Awake()
    {
        _camera = GetComponent<CinemachineVirtualCamera>();
        _channelPerlin = _camera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }
    private void Update()
    {
        _channelPerlin.m_AmplitudeGain = strengtMax;
    }
}
