using UnityEngine;

public class BurglarAlarm : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private readonly int MinVolume = 0;
    private readonly int MaxVolume = 1;

    private int _targetVolume;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _targetVolume = MaxVolume;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _targetVolume = MinVolume;
    }

    private void Update()
    {
        _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, _targetVolume, Time.deltaTime);
    }
}
