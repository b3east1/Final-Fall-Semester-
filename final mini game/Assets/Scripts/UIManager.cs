using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI coinCountText;
    public int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        coinCountText.text = "Coins: " + coins.ToString();
    }

    // Update is called once per frame
    public void UpdateCoinCount()
    {
        coins++;
        coinCountText.text = "Coins; " + coins.ToString();

    }
}
    