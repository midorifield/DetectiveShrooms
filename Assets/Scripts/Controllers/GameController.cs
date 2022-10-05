using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public StoryScene currentScene;
    public BottomBarController bottomBar;

    
    public void PlayNextStoryScene(){

        bottomBar.GetComponent<RectTransform>().localScale = new Vector3(0.6f,1f,1f);
        bottomBar.PlayScene(currentScene);

    }

    void Start()
    {
        //PlayNextStoryScene();
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
