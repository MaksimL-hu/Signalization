using System;
using System.Collections;
using UnityEngine;

[RequireComponent (typeof(AudioSource))]
public class Signalization : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float _speedChangeVolume;

    private Coroutine _playingCoroutine;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void Play(bool isPlay)
    {
        if (_playingCoroutine != null)
            StopCoroutine(_playingCoroutine);

        _playingCoroutine = StartCoroutine(SwitchSmooth(isPlay));
    }

    private IEnumerator SwitchSmooth(bool isPlay)
    {
        int volume = Convert.ToInt32(isPlay);

        while (_audioSource.volume != volume)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, volume, _speedChangeVolume);
            yield return null;
        }

        _audioSource.volume = volume;
    }
}