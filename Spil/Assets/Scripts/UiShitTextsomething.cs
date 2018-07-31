using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiShitTextsomething : MonoBehaviour {

    
    public int Health1 = 3;
    public int Health2 = 3;
    public Text HealthShow1;
    public Text HealthShow2;
    

    public void LoseHealthPlayer1()
    {
        Health1--;
        HealthShow1.text = "Player 1 HP: " + Health1;

    }

    public void LoseHealthPlayer2()
    {
        Health2--;
        HealthShow2.text = "Player 2 HP: " + Health2;

    }


}
