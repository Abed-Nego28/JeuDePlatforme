using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    public int coinsCount;
    public TMP_Text coinsCountText;

    public static Inventory instance;

    private void Awake()
    {
        if (instance != null)
        {
            return;
        }


        instance = this;
    }

    private void Start()
    {
        GameObject test = GameObject.FindGameObjectWithTag("coinValue");
        coinsCountText = GameObject.FindGameObjectWithTag("coinValue").GetComponent<TMP_Text>();
    }

    public void AddCoins(int count)
    {
        coinsCount += count;
        coinsCountText.text = coinsCount.ToString();
    }
}
