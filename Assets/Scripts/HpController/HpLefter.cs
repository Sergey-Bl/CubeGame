using TMPro;
using UnityEngine;

public class HpLefter : MonoBehaviour
{
    [SerializeField]
    private float hpCurrent = 10;
    [SerializeField] 
    private TextMeshProUGUI _health;
    private int hpFull = 10;

    public void ReceiveDamage(float damage)
    {
        hpCurrent -= damage;
        _health.text = ($"HP: {hpCurrent} from {hpFull}");

        if (hpCurrent <= 0f)
        {
            hpCurrent -= damage;
            GameOver gameOver = GetComponent<GameOver>();
            gameOver.EndGame();
        }
    }
}