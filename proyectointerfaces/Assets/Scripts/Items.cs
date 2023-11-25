using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu] //Nos permitira visualizar el item cuando hagamos clic en Create.
public class Items : ScriptableObject
{
    public string ItemName;
    public Sprite ItemImage;
    public string ItemDescription;
    public GameObject Item3DModel;

}
