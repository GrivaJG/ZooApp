using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class CardModel : ScriptableObject
{
    public string title;
    public string description;
    public string exhibit;
    public Sprite animalImg; 
}
