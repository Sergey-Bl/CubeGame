using UnityEngine;

public class TrapController : MonoBehaviour
{
    private int damage = 1;

    [SerializeField]
    private HpLefter hpLefter;
    
    
    private MeshRenderer user; void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "ObjectCube")
        {
            if (hpLefter != null)
            {
                hpLefter.ReceiveDamage(damage);
                Debug.Log("log -hp");

                EventController.TrapStay?.Invoke();
            }
        }
    }
}