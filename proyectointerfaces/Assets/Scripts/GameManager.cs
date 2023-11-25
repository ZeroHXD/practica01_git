using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public event Action OnMainMenu;
    public event Action OnItemsMenu;
    public event Action OnARPosition;

    public static GameManager Instance;
    private void Awake()
    {
        if (Instance != null && Instance != this) //Con esto aseguramos que la instancia solo existe una vez y se cree si no existe
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("Main Menu Activated");

    }
    public void ItemsMenu()
    {
        OnItemsMenu?.Invoke();
        Debug.Log("Items Menu Activated");

    }
    public void ARPosition()
    {

        OnARPosition?.Invoke();
        Debug.Log("AR Position Activated");
    }
    public void CloseAPP()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
