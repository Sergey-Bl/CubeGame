using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    [SerializeField] private string sceneName;

    private void OnCollisionEnter(Collision collision)

    {
        if (collision.collider.tag == "ObjectCube")
        {
            {
                EndGame();
            }
        }

        void EndGame()
        {
            Debug.Log("Game Over");
            SceneManager.LoadSceneAsync(sceneName);
        }
    }
}