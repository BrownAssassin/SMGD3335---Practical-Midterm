using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollection : MonoBehaviour
{
    public int coins = 0;
    
    void Update()
    {
        if (coins == 10)
        {
            SceneManager.LoadScene("End");
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Coins: " + coins);
    }
}
