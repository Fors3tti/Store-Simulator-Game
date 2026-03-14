using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public GameObject updatePricePanel;

    public TMP_Text basePriceText, currentPriceText;

    private void Awake()
    {
        instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenUpdatePrice(StockInfo stockToUpdate)
    {
        updatePricePanel.SetActive(true);

        Cursor.lockState = CursorLockMode.None;

        basePriceText.text = "R$" + stockToUpdate.price;
        currentPriceText.text = "R$" + stockToUpdate.currentPrice;
    }

    public void CloseUpdatePrice()
    {
        updatePricePanel.SetActive(false);

        Cursor.lockState = CursorLockMode.Locked;
    }
}
