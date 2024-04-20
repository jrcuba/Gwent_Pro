using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Deck", menuName = "New Deck")]

public class Deck : ScriptableObject
{
    public List<Card> deck;
    public void Addcard(Card card)
    {
        deck.Add(card);
    }
    public void RemoveRandomCard(Deck deckrandom)
    {
        int RandomValue = UnityEngine.Random.Range(0, deckrandom.deck.Count - 1);
        deckrandom.deck.Remove(deckrandom.deck[RandomValue]);
    }
    public void removeCard(Card aux)
    {
        deck.Remove(aux);
    }
}
