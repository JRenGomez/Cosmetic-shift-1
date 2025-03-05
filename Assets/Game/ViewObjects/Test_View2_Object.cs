using Unity.VisualScripting;
using UnityEngine;

public class Test_View2_Object : ViewObject
{
    public Test_View2_Object()
    {
        TypeWhenActive = ViewType.View2;
    }

    public override void ActivateObject()
    {
        base.ActivateObject();
        ThisSpriteRenderer.color = new Color(0f, 1f, 0f, 1f);
    }
    public override void DeactivateObject()
    {
        base.DeactivateObject();
        ThisSpriteRenderer.color = new Color(0f, 1f, 0f, 0f);
    }
}
