using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int starCount = 13;
    [SerializeField] private int receivedStar = 0;
    [SerializeField] private string sceneName;

    public void StarsReceived()
    {
        receivedStar++;
        if (receivedStar >= starCount)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        Debug.Log("Over");
        SceneManager.LoadSceneAsync(sceneName);
    }
}