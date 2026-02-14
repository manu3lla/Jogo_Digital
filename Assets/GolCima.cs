using UnityEngine;

public class GolCima : MonoBehaviour
{
    public Adm adm;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Puck"))
        {
            adm.GolCima();
        }
    }
}
