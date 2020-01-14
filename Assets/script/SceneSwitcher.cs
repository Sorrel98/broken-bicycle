using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    public void palyaTutorial() {

        SceneManager.LoadScene("1_Titorial");
    }

    public void palyMainstage()
    {

        SceneManager.LoadScene("2_Mainstage");
    }

    public void Option()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void Mainmenu()
    {

        SceneManager.LoadScene("0_Start");
    }


    public void Pause()
    {

        SceneManager.LoadScene("UI_menu");
    }


    public void Pausemainstage()
    {

        SceneManager.LoadScene("UI_Mainstage");
    }


    public void GameOver()
    {

        SceneManager.LoadScene("GameOver");

    }

    public void GameOver2()
    {

        SceneManager.LoadScene("GameOver2");

    }

    public void GameClear()
    {

        SceneManager.LoadScene("GameClear");

    }

    public void strory_start()
    {

        SceneManager.LoadScene("story_start");

    }


    public void Ending()
    {

        SceneManager.LoadScene("Ending");

    }


    public void Exit()
    {

        Application.Quit();

    }

}