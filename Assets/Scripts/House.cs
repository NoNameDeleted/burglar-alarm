using UnityEngine;

public class House : MonoBehaviour
{
    [SerializeField] BurglarAlarm alarm;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Crook>() == true)
            alarm.Activate();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Crook>() == true)
            alarm.Deactivate();
    }
}
