using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        Debug.Log("Attempting to change to scene: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
