using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] private List<Items> items = new List<Items>();
    [SerializeField] private GameObject buttonContainer;
    [SerializeField] private ItemButtonManager itemButtonManager;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.OnItemsMenu += CreateButtons;
    }
    private void CreateButtons()
    {
        foreach (var item in items)
        {
            ItemButtonManager itemButton;
            itemButton = Instantiate(itemButtonManager, buttonContainer.transform);

            itemButton.ItemName = item.ItemName;
            itemButton.ItemDescription = item.ItemDescription;
            itemButton.ItemImage = item.ItemImage;
            itemButton.Item3Dmdel = item.Item3DModel;
            itemButton.name = item.ItemName;
        }
        GameManager.Instance.OnItemsMenu -= CreateButtons; //Desuscribimos el evento cada que se llama para no acumular botones. 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
