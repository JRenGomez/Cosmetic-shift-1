using System;
using UnityEngine;
using UnityEngine.UIElements;

public class ViewObject : MonoBehaviour
{
    public LevelViewManager ViewManager;
    public ViewType TypeWhenActive;
    private void OnEnable()
    {
        LevelViewManager.OnViewSwitched += SwitchObjectState;
    }
    void Start()
    {}
    void Update()
    {}
    public void SwitchObjectState()
    {
        try
        {
            if (ViewManager.CurrentView.ViewType == TypeWhenActive )
                ActivateObject();
            else if (TypeWhenActive == ViewType.UsualView && ViewManager.CurrentView.ViewType != ViewType.ParallelDimension)
                ActivateObject();
            else
                DeactivateObject();
        }
        catch (Exception e)
        {
            SwitchObjectState();
        }

    }
    public virtual void ActivateObject() { }
    public virtual void DeactivateObject() { }
}
