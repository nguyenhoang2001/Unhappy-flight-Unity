using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] string _nextLevelName;
    public void LoadScene()
    {
        SceneManager.LoadScene(_nextLevelName);
        SFXManager.sfxInstance.Audio.PlayOneShot(SFXManager.sfxInstance.Click);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!!");
    }
}
