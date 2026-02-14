using UnityEngine;
using System.Collections;

public class PuckReset : MonoBehaviour
{
    public Transform posicaoInicial;

    private Rigidbody2D rb;
    private bool resetando = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Resetar()
    {
        if (!resetando)
        {
            StartCoroutine(ResetCoroutine());
        }
    }

    IEnumerator ResetCoroutine()
    {
        resetando = true;

        rb.linearVelocity = Vector2.zero;
        rb.angularVelocity = 0f;

        yield return new WaitForSeconds(0.5f);

        transform.position = posicaoInicial.position;

        rb.linearVelocity = Vector2.zero;
        rb.angularVelocity = 0f;

        resetando = false;
    }
}
