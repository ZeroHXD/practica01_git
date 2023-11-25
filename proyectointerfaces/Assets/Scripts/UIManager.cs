using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; //LIBRERIA DE DOTween (HOTween v2)
using System;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuCanvas; //agregar los campos de los gameObject que contienen la interfaz
    [SerializeField] private GameObject itemsMenuCanvas; //agregar los campos de los gameObject que contienen la interfaz
    [SerializeField] private GameObject ARPositionCanvas; //agregar los campos de los gameObject que contienen la interfaz

    // Start is called before the first frame update
    void Start()
    {
        //Ahora se van a crear las funciones que van a estar suscritos a los eventos del GamenManager
        GameManager.Instance.OnMainMenu += ActivateMainMenu;
        GameManager.Instance.OnItemsMenu += ActivateItemsMenu;
        GameManager.Instance.OnARPosition += ActivateARPosition;
    }

    private void ActivateARPosition()
    {
        //creamos efectos como si los botones para animar la interfaz, esto se logra con el Asset DOTween
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f); // Agregando efectos de Scala al invocar al primer boton GetChild indica los botones - en este caso Boton pos 0
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f); // Agregando efectos de Scala al invocar al primer boton GetChild indica los botones - en este caso Boton pos 1
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f); // Agregando efectos de Scala al invocar al primer boton GetChild indica los botones - en este caso Boton pos 2

        //desactivamos los botones al dejarle sin escala
        //creamos los otros botones, de las otras interfaces. items Menu
        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f); //GetChild(0) - ItemsOpen
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f); //GetChild(1) - ScrollView
        itemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f); // Para agregar efecto como si el boton saliera de la CAJA,usando DOMoveY para que se posicione hacia la derecha

        //creamos los otros botones,de las otras interfaces ARPosition
        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);


    }

    private void ActivateItemsMenu()
    {
        //desactivamos los botones al dejarle sin escala
        //creamos efectos como si los botones para animar la interfaz, esto se logra con el Asset DOTween
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f); // Agregando efectos de Scala al invocar al primer boton GetChild indica los botones - en este caso Boton pos 0
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f); // Agregando efectos de Scala al invocar al primer boton GetChild indica los botones - en este caso Boton pos 1
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f); // Agregando efectos de Scala al invocar al primer boton GetChild indica los botones - en este caso Boton pos 2


        //creamos los otros botones, de las otras interfaces. items Menu
        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f); //GetChild(0) - ItemsOpen
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f); //GetChild(1) - ScrollView
        itemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f); // Para agregar efecto como si el boton saliera de la CAJA,usando DOMoveY para que se posicione hacia la derecha

        //desactivamos los botones al dejarle sin escala
        //creamos los otros botones,de las otras interfaces ARPosition
        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }

    private void ActivateMainMenu()
    {
        //creamos efectos como si los botones para animar la interfaz, esto se logra con el Asset DOTween
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f); // Agregando efectos de Scala al invocar al primer boton GetChild indica los botones - en este caso Boton pos 0
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f); // Agregando efectos de Scala al invocar al primer boton GetChild indica los botones - en este caso Boton pos 1
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f); // Agregando efectos de Scala al invocar al primer boton GetChild indica los botones - en este caso Boton pos 2

        //desactivamos los botones al dejarle sin escala
        //creamos los otros botones, de las otras interfaces. items Menu
        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f); //GetChild(0) - ItemsOpen
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f); //GetChild(1) - ScrollView
        itemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f); // Para agregar efecto como si el boton saliera de la CAJA,usando DOMoveY para que se posicione hacia la derecha

        //desactivamos los botones al dejarle sin escala
        //creamos los otros botones,de las otras interfaces ARPosition
        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }
}