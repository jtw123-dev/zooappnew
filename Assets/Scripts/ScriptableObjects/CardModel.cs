using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class CardModel : ScriptableObject {

   public string title,description,exhibit;
   public Sprite animalImage;
   
}
