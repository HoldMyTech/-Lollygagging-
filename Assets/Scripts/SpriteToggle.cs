using UnityEngine;

public class SpriteToggle : MonoBehaviour
{
    public Sprite spriteA;
    public Sprite spriteB;

    private SpriteRenderer sr;
    private bool showingA = true;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = spriteA;
    }

    void OnMouseDown()
    {
        showingA = !showingA;
        sr.sprite = showingA ? spriteA : spriteB;
    }
}