using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeGetset : MonoBehaviour
{

    public void ScreenLoader()
    {
        SceneManager.LoadScene(1);
    }

    public void CameraLoader()
    {
        SceneManager.LoadScene(2);
    }

    public void LoginLoader()
    {
        SceneManager.LoadScene(0);
    }

}
