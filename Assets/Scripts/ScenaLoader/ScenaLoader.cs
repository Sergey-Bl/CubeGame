using UnityEngine;
using UnityEngine.SceneManagement;

namespace ScenaLoader
{
    public class ScenaLoader : MonoBehaviour
    {
        [SerializeField] private string scenaName;

        public void load()
        {
            SceneManager.LoadSceneAsync(scenaName);
        }
    }
}