using UnityEngine;

public class Platform : ViewObject
{
    public BoxCollider2D ThisBoxCollider;
    public Rigidbody2D ThisRigidbody2D;
    public SpriteRenderer ThisSpriteRender;

    public override void ActivateObject()
    {
        ThisBoxCollider.enabled = true;
        ThisSpriteRender.enabled = true;
    }
    public override void DeactivateObject()
    {
        ThisBoxCollider.enabled = false;
        ThisSpriteRender.enabled = false;
    }
}
