using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void ExitAR()
    {
        SceneManager.LoadScene("MainPage");
    }

    public void MainPage()
    {
        SceneManager.LoadScene("MainPage");
    }

    public void MapPage()
    {
        SceneManager.LoadScene("ARPage");
    }

    public void MarketPage()
    {
        SceneManager.LoadScene("ShopPage");
    }

    public void ProfilePage()
    {
        SceneManager.LoadScene("ProfilePage");
    }
}
