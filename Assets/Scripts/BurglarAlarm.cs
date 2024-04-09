using System.Collections;
using UnityEngine;

public class BurglarAlarm : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private readonly int MinVolume = 0;
    private readonly int MaxVolume = 1;

    public void Activate()
    {
        StartCoroutine(ChangeVolume(MaxVolume));
    }

    public void Deactivate()
    {
        StartCoroutine(ChangeVolume(MinVolume));
    }

    private IEnumerator ChangeVolume(int targetVolume)
    {
        while (_audioSource.volume != targetVolume)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, targetVolume, Time.deltaTime);

            yield return null;
        }
    }
}
