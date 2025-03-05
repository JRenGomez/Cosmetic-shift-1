using UnityEngine;

public class Test_View1 : View
{
    public Test_View1()
    {
        ViewType = ViewType.View1;
    }
    public override void ApplyView()
    {
        Debug.Log("This is View 1");
    }
}
