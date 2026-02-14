using UnityEngine;
using TMPro;

public class Adm : MonoBehaviour
{
    public int pontosJogadorCima;
    public int pontosJogadorBaixo;

    public TextMeshProUGUI textoPlacar;

    public Transform puck;
    public Transform posicaoInicialPuck;

    private Rigidbody2D rb;

    void Start()
    {
        rb = puck.GetComponent<Rigidbody2D>();
        AtualizarPlacar();
    }

    public void GolCima()
    {
        pontosJogadorBaixo++;
        AtualizarPlacar();
        ResetarPuck();
    }

    public void GolBaixo()
    {
        pontosJogadorCima++;
        AtualizarPlacar();
        ResetarPuck();
    }

    void AtualizarPlacar()
    {
        textoPlacar.text = pontosJogadorCima + " x " + pontosJogadorBaixo;
    }

    void ResetarPuck()
    {
        puck.position = posicaoInicialPuck.position;
        rb.linearVelocity = Vector2.zero;
        rb.angularVelocity = 0f;
    }
}
