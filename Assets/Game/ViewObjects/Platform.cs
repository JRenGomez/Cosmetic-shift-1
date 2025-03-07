using UnityEngine;

public class Platform : ViewObject
{
    public BoxCollider2D ThisBoxCollider;
    public Rigidbody2D ThisRigidbody2D;
    public SpriteRenderer ThisSpriteRender;

    public override void ActivateObject()
    {
        ThisBoxCollider.enabled = true;
        ThisSpriteRender.color = new Color(ThisSpriteRender.color.r, ThisSpriteRender.color.g, ThisSpriteRender.color.b, 1f);
    }
    public override void DeactivateObject()
    {
        ThisBoxCollider.enabled = false;
        ThisSpriteRender.color = new Color(ThisSpriteRender.color.r, ThisSpriteRender.color.g, ThisSpriteRender.color.b, 0.2f);
    }
}
