using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceny : MonoBehaviour
{
    public void ZmienSceneClickerGlowny()
    {
        SceneManager.LoadScene(1);
    }

    public void ZmienSceneSetting()
    {
        SceneManager.LoadScene(3);
    }

    public void WyjscieZgry()
    {
        Application.Quit();
    }

    public void ZmienSceneMenuGlowny()
    {
        SceneManager.LoadScene(0);
    }

    public void Sklep()
    {
        SceneManager.LoadScene(2);
    }

}    
