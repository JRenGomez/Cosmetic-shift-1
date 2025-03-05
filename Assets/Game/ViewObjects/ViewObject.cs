using System;
using UnityEngine;
using UnityEngine.UIElements;

public class ViewObject : MonoBehaviour
{
    LevelViewManager ViewManager { get; set; }
    public ViewType TypeWhenActive;
    private void OnEnable()
    {
        LevelViewManager.OnViewSwitched += SwitchObjectState;
    }
    void Start()
    {
        ViewManager = SetViewManager();
    }
    void Update()
    {}
    private LevelViewManager SetViewManager()
    {
        try
        {
            LevelViewManager thisLevelViewManager = FindObjectOfType<LevelViewManager>();
            return thisLevelViewManager;
        }
        catch(Exception e)
        {
            Debug.LogError(e.Message);
            return null;
        }
    }
    public void SwitchObjectState()
    {
        if (ViewManager.CurrentView.ViewType == TypeWhenActive)
            ActivateObject();
        else
            DeactivateObject();
    }
    public virtual void ActivateObject() { }
    public virtual void DeactivateObject() { }
}
