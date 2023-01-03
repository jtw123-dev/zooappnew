using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour {

    [SerializeField] Text _title,_description,_exhibit;
    [SerializeField] Image _animalImage;
    [SerializeField] private CardModel[] _cards;

    

    private void OnEnable()
    {
      
    }

    public void ActivateCard(int pickedCard)
    {
        _title.text = _cards[pickedCard].title.ToString();
        _description.text = _cards[pickedCard].description.ToString();
        _exhibit.text = _cards[pickedCard].description.ToString();
        _animalImage.sprite = _cards[pickedCard].animalImage;
        
    }
}
