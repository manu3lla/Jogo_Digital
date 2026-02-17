using UnityEngine;
using TMPro;

public class Adm : MonoBehaviour
{
    public int pontosJogadorCima;
    public int pontosJogadorBaixo;

    public TextMeshProUGUI textoPlacar;

    public PuckReset puckReset;

    void Start()
    {
        AtualizarPlacar();
    }

    public void GolCima()
    {
        pontosJogadorBaixo++;
        AtualizarPlacar();
        puckReset.Resetar();
    }

    public void GolBaixo()
    {
        pontosJogadorCima++;
        AtualizarPlacar();
        puckReset.Resetar();
    }

    void AtualizarPlacar()
    {
        textoPlacar.text = pontosJogadorCima + " : " + pontosJogadorBaixo;
    }
}
