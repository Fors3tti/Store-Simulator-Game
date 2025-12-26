using UnityEngine;

public class StockObject : MonoBehaviour
{
    public float moveSpeed;

    private bool isPlaced;

    public Rigidbody theRB;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickUp()
    {
        theRB.isKinematic = true;

        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
    }

    public void MakePlaced()
    {
        theRB.isKinematic = true;
    }
}
