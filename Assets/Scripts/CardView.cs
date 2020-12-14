using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    public Text title;
    public Text description;
    public Text exhibit;

    public Image animalImage;

    public CardModel[] card;



    public void SelectCard(int numberCard)
    {
        title.text = card[numberCard].title;
        description.text = card[numberCard].description;
        exhibit.text = card[numberCard].exhibit;
        animalImage.sprite = card[numberCard].animalImg;
    }
}
