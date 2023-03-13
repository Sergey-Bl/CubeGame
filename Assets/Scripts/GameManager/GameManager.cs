using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int starCount = 13;
    [SerializeField] private int receivedStar = 0;
    [SerializeField] private string sceneName;
    [SerializeField] private TextMeshProUGUI _starsScore;

    public void StarsReceived()
    {
        receivedStar++;
        _starsScore.text = ($"Collected: {receivedStar} from {starCount}");
        if (receivedStar >= starCount)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        Debug.Log("Game Over");
        SceneManager.LoadSceneAsync(sceneName);
    }
}