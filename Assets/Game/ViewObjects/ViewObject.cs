using System;
using UnityEngine;
using UnityEngine.UIElements;

public class ViewObject : MonoBehaviour
{
    LevelViewManager ViewManager { get; set; }
    public ViewType TypeWhenActive { get; set; }
    public SpriteRenderer ThisSpriteRenderer;
    void Start()
    {
        ViewManager = SetViewManager();
    }
    void Update()
    {
        if (TypeWhenActive == ViewManager.CurrentView.ViewType)
            ActivateObject();
        else
            DeactivateObject();
    }
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
    public virtual void ActivateObject() { }
    public virtual void DeactivateObject() { }
}
