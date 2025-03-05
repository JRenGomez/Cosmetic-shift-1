using UnityEngine;

public class Test_View1_Object2 : ViewObject
{
    public Test_View1_Object2()
    {
        TypeWhenActive = ViewType.View1;
    } 
    public override void ActivateObject()
    {
        base.ActivateObject();
        this.gameObject.transform.eulerAngles = new Vector3(0f, 0f, 0);
    }
    public override void DeactivateObject()
    {
        base.DeactivateObject();
        this.gameObject.transform.eulerAngles = new Vector3(0f, 0f, 90f);
    }
}
