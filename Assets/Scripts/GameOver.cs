using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    [SerializeField] private string sceneName;

    void OnCollisionEnter(Collision collision)

    {
        if (collision.collider.tag == "ObjectCube")
        {
            {
                EndGame();
            }
        }

        void EndGame()
        {
            Debug.Log("Over");
            SceneManager.LoadSceneAsync(sceneName);
        }
    }
}