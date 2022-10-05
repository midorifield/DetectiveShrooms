using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour , IPointerClickHandler
{
    public GameController controller;
    bool hasTriggered;


    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        controller.PlayNextStoryScene();

    }
}
