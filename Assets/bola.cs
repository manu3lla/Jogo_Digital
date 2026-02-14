using UnityEngine;

public class Bola : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float velocidadeInicial = 8f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        IniciarMovimento();
    }

    void FixedUpdate()
    {
        rb.linearVelocity = rb.linearVelocity.normalized * velocidadeInicial;
    }

    public void ResetarBola()
    {
        transform.position = Vector3.zero;
        rb.linearVelocity = Vector2.zero;

        IniciarMovimento();
    }

    void IniciarMovimento()
    {
        Vector2 direcao = new Vector2(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
        ).normalized;

        rb.linearVelocity = direcao * velocidadeInicial;
    }
}
