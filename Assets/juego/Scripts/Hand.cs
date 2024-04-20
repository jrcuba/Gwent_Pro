using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu(fileName = "New Hand", menuName = "New Hand")]

public class Hand : ScriptableObject
{
    public List<Card> hand;

    public void AddRandomCard(Deck deckrandom, int count = 0)
    {
        for (int i = 0; i < 10; i++)
        {
            //valor aleatorio
            int RandomValue = UnityEngine.Random.Range(0, deckrandom.deck.Count - 1);
            //guardo el valor en la mano
            //mano[i] = deckrandom.cards[valorrandom];
            hand.Add(deckrandom.deck[RandomValue]);

            //lo elimino del deck
            deckrandom.deck.Remove(deckrandom.deck[RandomValue]);
        }
    }
    public void AddRandomsCard2(Deck deckrandom)
    {
            //valor aleatorio
            int RandomValue = UnityEngine.Random.Range(0, deckrandom.deck.Count - 1);
            hand.Add(deckrandom.deck[RandomValue]);

            //lo elimino del deck
            deckrandom.deck.Remove(deckrandom.deck[RandomValue]);
    }
}
