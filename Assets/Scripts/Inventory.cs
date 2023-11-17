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
            Debug.LogWarning("Instance de Inventory déjà présente dans la scène");
            return;
        }


        instance = this;
    }

    private void Start(){
           Debug.LogWarning("test");
            GameObject test = GameObject.FindGameObjectWithTag("coinValue");
            Debug.LogWarning(test);
            coinsCountText = GameObject.FindGameObjectWithTag("coinValue").GetComponent<TMP_Text>();
            Debug.LogWarning(coinsCountText);
    }

    public void AddCoins(int count)
    {
        coinsCount += count;
       coinsCountText.text = coinsCount.ToString(); 
    }
}
