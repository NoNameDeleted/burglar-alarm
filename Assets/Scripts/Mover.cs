using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private readonly string Horizontal = nameof(Horizontal);
    private readonly string Vertical = nameof(Vertical);

    private void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis(Horizontal), Input.GetAxis(Vertical), 0f);

        transform.Translate(_speed * Time.deltaTime * direction);
    }
}
