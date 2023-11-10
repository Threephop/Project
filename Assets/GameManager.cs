using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int nScore;
    public static int numberOfCoins;
    public TextMeshProUGUI coinsText;
    // Start is called before the first frame update
    void Start()
    {
        nScore = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = numberOfCoins.ToString();
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetScore();
        }
    }
    public void ResetScore()
    {
        nScore = 0;
    }
}
