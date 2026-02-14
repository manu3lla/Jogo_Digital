using UnityEngine;

public class Gol1 : MonoBehaviour
{
    public Adm adm;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Puck"))
        {
            if (gameObject.name == "GolCima")
            {
                adm.GolCima();
            }
            else if (gameObject.name == "GolBaixo")
            {
                adm.GolBaixo();
            }
        }
    }
}
