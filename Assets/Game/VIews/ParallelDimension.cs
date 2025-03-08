using UnityEngine;

public class ParallelDimension : View
{
    public ParallelDimension()
    {
        this.ViewType = ViewType.ParallelDimension;
    }
    public override void ApplyView()
    {
        Debug.Log("Parallel Dimension view");
    }
}
