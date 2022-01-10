using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManagerScript;
    [SerializeField] private int difficulty;
    
    void Start()
    {
        gameManagerScript = FindObjectOfType<GameManager>();
        
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }

    private void SetDifficulty()
    {
        gameManagerScript.StartGame(difficulty);
    }
    
}
