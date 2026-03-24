using TMPro;
using UnityEngine;

public class BuyStockFrameController : MonoBehaviour
{
    public StockInfo info;

    public TMP_Text nameText, priceText, boxAmountText, boxPriceText, buttonText;

    public StockBoxController boxToSpawn;

    private float boxCost;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateFrameInfo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateFrameInfo()
    {
        info = StockInfoController.instance.GetInfo(info.name);

        nameText.text = info.name;
        priceText.text = "R$" + info.price.ToString("F2");

        int boxAmount = boxToSpawn.GetStockAmount(info.typeOfStock);
        boxAmountText.text = boxAmount.ToString() + " per box";

        boxCost = boxAmount * info.price;
        boxPriceText.text = "Box: R$" + boxCost.ToString("F2");

        buttonText.text = "PAY: R$" + boxCost.ToString("F2");
    }
}
