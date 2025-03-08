using UnityEngine;

public class Lamp : ViewObject
{
    public SpriteRenderer ThisSpriteRender;
    public override void ActivateObject()
    {
        ThisSpriteRender.color = new Color(ThisSpriteRender.color.r, ThisSpriteRender.color.g, ThisSpriteRender.color.b, 0.2f);
    }
    public override void DeactivateObject()
    {
        ThisSpriteRender.color = new Color(ThisSpriteRender.color.r, ThisSpriteRender.color.g, ThisSpriteRender.color.b, 1f);
    }
}
