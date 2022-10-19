using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadGame()
    {
        // La escena Game debe estar en la lista de escenas en la ventana de Build Settings
        SceneManager.LoadScene("Game");
    }
}
