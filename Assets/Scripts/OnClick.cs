using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnTriggerEnter : MonoBehaviour , IPointerClickHandler
{
    public GameController controller;
    bool hasTriggered;


    void OnPointerClick(PointerEventData pointerEventData)
    {
        
        controller.PlayNextStoryScene();

    }
}
