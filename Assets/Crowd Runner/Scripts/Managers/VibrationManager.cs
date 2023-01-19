using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrationManager : MonoBehaviour
{
    [Header(" Settings ")]
    private bool haptics;

    // Start is called before the first frame update
    void Start()
    {
        PlayerDetection.onDoorsHit += Vibrate;
        Enemy.onRunnerDied += Vibrate;
        GameManager.onGameStateChanged += GameStateChangedCallback;
    }

    private void OnDestroy()
    {
        PlayerDetection.onDoorsHit -= Vibrate;
        Enemy.onRunnerDied -= Vibrate;
        GameManager.onGameStateChanged -= GameStateChangedCallback;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Vibrate()
    {
        if(haptics)
        Taptic.Light();
    }

    private void GameStateChangedCallback(GameManager.GameState gameState)
    {
        if (gameState == GameManager.GameState.LevelComplete)
            Vibrate();
        else if (gameState == GameManager.GameState.Gameover)
            Vibrate();
    }

    public void DisableVibrations()
    {
        haptics = false;
    }

    public void EnableVibrations()
    {
        haptics = true;
    }

}
