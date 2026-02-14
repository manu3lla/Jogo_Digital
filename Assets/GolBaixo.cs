using UnityEngine;

public class GolBaixo : MonoBehaviour
{
    public Adm adm;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Puck"))
        {
            adm.GolBaixo();
        }
    }
}
