//   _  _    _____       _       _____ _             _ _       
// _| || |_ / ____|     | |     / ____| |           | (_)      
//|_  __  _| (___   ___ | | ___| (___ | |_ _   _  __| |_  ___  
// _| || |_ \___ \ / _ \| |/ _ \\___ \| __| | | |/ _` | |/ _ \ 
//|_  __  _|____) | (_) | | (_) |___) | |_| |_| | (_| | | (_) |
//  |_||_| |_____/ \___/|_|\___/_____/ \__|\__,_|\__,_|_|\___/ 

using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    public KeyCode resetKey = KeyCode.R; // Key to trigger the reset (you can change this in the Inspector).

    void Update()
    {
        if (Input.GetKeyDown(resetKey))
        {
            ResetScene();
        }
    }

    public void ResetScene()
    {
        // Reload the current scene.
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}

//SoloStudio-2024
