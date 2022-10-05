using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour, IPointerClickHandler
{

    public StoryScene currentScene;
    public BottomBarController bottomBar;

    
    public void PlayNextStoryScene(){

        bottomBar.PlayScene(currentScene);

    }

    void Start()
    {
        PlayNextStoryScene();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (bottomBar.IsCompleted())
            {
                if (bottomBar.IsLastSentence())
                {
                    currentScene = currentScene.nextScene;
                    bottomBar.PlayScene(currentScene);
                }
                else
                {
                    bottomBar.PlayNextSentence();
                }
            }
        }
    }

}
