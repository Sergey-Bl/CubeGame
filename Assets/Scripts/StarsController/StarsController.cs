using UnityEngine;


public class StarsController : MonoBehaviour
{
   

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "ObjectCube") return;
        Destroy(gameObject);
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.StarsReceived();
        Debug.Log("StarReceived");
    }
}