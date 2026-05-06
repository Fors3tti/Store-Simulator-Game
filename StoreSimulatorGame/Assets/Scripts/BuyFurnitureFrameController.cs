using TMPro;
using UnityEngine;

public class BuyFurnitureFrameController : MonoBehaviour
{
    public FurnitureController furnitureController;

    public TMP_Text priceText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        priceText.text = "Price: R$ " + furnitureController.price.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyFurniture()
    {
        if(StoreController.instance.CheckMoneyAvailable(furnitureController.price))
        {
            StoreController.instance.SpendMoney(furnitureController.price);

            Instantiate(furnitureController, 
                StoreController.instance.furnitureSpawnPoint.position, Quaternion.identity);
        }
    }
}
