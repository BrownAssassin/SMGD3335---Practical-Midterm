using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void OnStartButton_Pressed()
    {
        SceneManager.LoadScene("Main");
    }
}
