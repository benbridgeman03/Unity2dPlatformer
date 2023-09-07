using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenu : MonoBehaviour
{
    [SerializeField]private string scene;
    public void StartGame()
    {
        Application.LoadLevel(scene);
    }
}
