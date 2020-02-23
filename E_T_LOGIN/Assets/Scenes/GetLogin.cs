using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GetLogin : MonoBehaviour
{
    public InputField username;
    public InputField password;
    public void LoginLoader()
    {
        SceneManager.LoadScene(1);
    }

    public void Register()
    {
        SceneManager.LoadScene(3);
    }
}
