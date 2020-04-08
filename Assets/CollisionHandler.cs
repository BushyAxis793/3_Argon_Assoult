using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour {

    [Tooltip("In Seconds")][SerializeField] float levelLoadDelay = 1f;
    [Tooltip("FX prefab on player")][SerializeField] GameObject deathFX;

    void OnCollisionEnter(Collision other)
    {
        StartDeathSequence();
        deathFX.SetActive(true);
        Invoke("ReloadScene",levelLoadDelay);
    }

    private void StartDeathSequence()
    {
        print("Player dying");

    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(1);
    }
}
