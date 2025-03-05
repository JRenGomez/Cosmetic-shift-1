using UnityEngine;

public class Test_View1_Object : ViewObject
{
    public Test_View1_Object()
    {
        TypeWhenActive = ViewType.View1;
    }

    public override void ActivateObject()
    {
        base.ActivateObject();
        ThisSpriteRenderer.color = new Color(1f, 0f, 0f, 1f);
    }
    public override void DeactivateObject()
    {
        base.DeactivateObject();
        ThisSpriteRenderer.color = new Color(1f, 0f, 0f, 0f);
    }
}
