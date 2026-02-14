using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private CircleCollider2D playerCollider;

    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;
    public BoxCollider2D upLeftWall;
    public BoxCollider2D upRightWall;
    public BoxCollider2D downLeftWall;
    public BoxCollider2D downRightWall;

    void Start()
    {
        playerCollider = GetComponent<CircleCollider2D>();

        Transform wallsParent = GameObject.Find("Paredes").transform;

        leftWall = wallsParent.Find("ParedeEsquerda").GetComponent<BoxCollider2D>();
        rightWall = wallsParent.Find("ParedeDireita").GetComponent<BoxCollider2D>();
        upLeftWall = wallsParent.Find("ParedeCimaEsquerda").GetComponent<BoxCollider2D>();
        upRightWall = wallsParent.Find("ParedeCima").GetComponent<BoxCollider2D>();
        downLeftWall = wallsParent.Find("ParedeBaixo").GetComponent<BoxCollider2D>();
        downRightWall = wallsParent.Find("ParedeBaixoDireita").GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        Vector3 pos = mousePos;

        float radius = playerCollider.bounds.extents.x;

        float minX = leftWall.bounds.max.x + radius;
        float maxX = rightWall.bounds.min.x - radius;

        float minY = downLeftWall.bounds.max.y + radius;
        float meioCampo = 0f;

        float maxY = meioCampo - radius;

        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);

        transform.position = pos;
    }
}
