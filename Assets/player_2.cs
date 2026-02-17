using UnityEngine;

public class player_2 : MonoBehaviour
{
    public Transform bola;

    private Rigidbody2D bolaRb;
    private CircleCollider2D playerCollider;
    private Rigidbody2D rb;

    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;
    public BoxCollider2D upWall;
    public BoxCollider2D downWall;

    [SerializeField] private float velocidade = 12f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<CircleCollider2D>();
        bolaRb = bola.GetComponent<Rigidbody2D>();

        Transform wallsParent = GameObject.Find("Paredes").transform;

        leftWall = wallsParent.Find("ParedeEsquerda").GetComponent<BoxCollider2D>();
        rightWall = wallsParent.Find("ParedeDireita").GetComponent<BoxCollider2D>();
        upWall = wallsParent.Find("ParedeCima").GetComponent<BoxCollider2D>();
        downWall = wallsParent.Find("ParedeBaixo").GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (bola == null || bolaRb == null) return;

        Vector3 alvo;
        if (bolaRb.linearVelocity.y > 0)
        {
            float previsaoX = bola.position.x + bolaRb.linearVelocity.x * 0.2f;
            alvo = new Vector3(previsaoX, bola.position.y, 0f);
        }
        else if (bola.position.y > 0)
        {
            alvo = bola.position;
        }
        else
        {
            alvo = new Vector3(0f, 3f, 0f);
        }

        float radius = playerCollider.bounds.extents.x;

        float minX = leftWall.bounds.max.x + radius;
        float maxX = rightWall.bounds.min.x - radius;

        float meioCampo = 0f;

        float minY = meioCampo + radius;
        float maxY = upWall.bounds.min.y - radius;

        alvo.x = Mathf.Clamp(alvo.x, minX, maxX);
        alvo.y = Mathf.Clamp(alvo.y, minY, maxY);

        Vector2 novaPosicao = Vector2.MoveTowards(
            rb.position,
            alvo,
            velocidade * Time.deltaTime
        );

        rb.MovePosition(novaPosicao);
    }
}
