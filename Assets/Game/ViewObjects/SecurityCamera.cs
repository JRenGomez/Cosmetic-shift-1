using UnityEngine;

public class SecurityCamera : ViewObject
{
    public SpriteRenderer ThisSpriteRender;
    public Collider2D ThisCollider2D;
    private Color InitialColor;
    private void Start()
    {
        InitialColor = ThisSpriteRender.color;
    }
    public override void ActivateObject()
    {
        ThisCollider2D.enabled = false;
        ThisSpriteRender.color = new Color(0f, 1f, 0f, ThisSpriteRender.color.a);
    }
    public override void DeactivateObject()
    {
        ThisCollider2D.enabled = true;
        ThisSpriteRender.color = InitialColor;
    }
}
