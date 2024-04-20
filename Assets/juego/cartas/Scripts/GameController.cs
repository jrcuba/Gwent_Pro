using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static Unity.Burst.Intrinsics.X86;
public class GameController : MonoBehaviour
{
    int countReturnCards = 0;

    public Text ShowCountRadiant;
    public Text ShowCountDire;
    public Text RoundDire;
    public Text RoundRadiant;

    public Text Cardname;
    public Text Power;
    public Text Efect;
    public Text Faction;
    public Text FieldType;

    int countShow = 0;
    int countShow2 = 0;
    string CardnameAux;
    int countDraw = 0;

    int countAux = 0;
    int countTurns = -1;
    int countTurns2 = 0;
    int countTurns3 = 0;
    int countPointsRadiant = 0;
    int countPointsDire = 0;
    int RoundWinerRadiant = 0;
    int RoundWinerDire = 0; 

    public Image MeleeRadiant;
    public Image MeleeRadiant2;
    public Image MeleeDire1;
    public Image MeleeDire2;
    public Image RangeRadiant1;
    public Image RangeRadiant2;
    public Image RangeDire1;
    public Image RangeDire2;
    public Image AsedyRadiant1;
    public Image AsedyRadiant2;
    public Image AsedyDire1;
    public Image AsedyDire2;
    public Image CampoRadiant1;
    public Image CampoDire1;

    public Card MeleeRadiantCard;
    public Card MeleeRadiant2Card;
    public Card MeleeDire1Card;
    public Card MeleeDire2Card;
    public Card RangeRadiant1Card;
    public Card RangeRadiant2Card;
    public Card RangeDire1Card;
    public Card RangeDire2Card;
    public Card AsedyRadiant1Card;
    public Card AsedyRadiant2Card;
    public Card AsedyDire1Card;
    public Card AsedyDire2Card;
    public Card LiderRadiantCard;
    public Card LiderDireCard;


    public Image EspacioliderRadiant;
    public Image EspacioliderDire;

    public Image EspacioRadiant;
    public Image EspacioRadiant1;
    public Image EspacioRadiant2;
    public Image EspacioRadiant3;
    public Image EspacioRadiant4;
    public Image EspacioRadiant5;
    public Image EspacioRadiant6;
    public Image EspacioRadiant7;
    public Image EspacioRadiant8;
    public Image EspacioRadiant9;

    public Image EspacioDire;
    public Image EspacioDire1;
    public Image EspacioDire2;
    public Image EspacioDire3;
    public Image EspacioDire4;
    public Image EspacioDire5;
    public Image EspacioDire6;
    public Image EspacioDire7;
    public Image EspacioDire8;
    public Image EspacioDire9;

    public Button Start;
    public Button DrawButton;

    public Deck DeckRadiant;
    public Deck DeckDire;

    public Hand HandRadiant;
    public Hand HandDire;

    public Card Abaddon;
    public Card Centaure_Warruner;
    public Card Dragon_Knight;
    public Card Drow_Ranger;
    public Card EarthShaker;
    public Card Invoker;
    public Card Jugernaut;
    public Card Lina;
    public Card Phantom_Assassin;
    public Card Phoenix;
    public Card Razor;
    public Card Shadow_Field;
    public Card Sven;
    public Card Tiny;
    public Card Unding;
    public Card Weaver;
    public Card Desolator;
    public Card Falcon_Blade;
    public Card Fell_Spirit;
    public Card Ghost_Spirit;
    public Card Gleirpnir;
    public Card Harpy_Scout;
    public Card Harpy_Stormcraafter;
    public Card Helm_of_Dominator;
    public Card Hill_Troll;
    public Card Kobold;
    public Card Mask_of_Madness;
    public Card Octarine;


    public void AddToDeck(Deck aux)
    {

        aux.Addcard(Abaddon);
        aux.Addcard(Centaure_Warruner);
        aux.Addcard(Dragon_Knight);
        aux.Addcard(Drow_Ranger);
        aux.Addcard(EarthShaker);
        aux.Addcard(Invoker);
        aux.Addcard(Jugernaut);
        aux.Addcard(Lina);
        aux.Addcard(Phantom_Assassin);
        aux.Addcard(Phoenix);
        aux.Addcard(Razor);
        aux.Addcard(Shadow_Field);
        aux.Addcard(Sven);
        aux.Addcard(Tiny);
        aux.Addcard(Unding);
        aux.Addcard(Weaver);
        aux.Addcard(Desolator);
        aux.Addcard(Falcon_Blade);
        aux.Addcard(Fell_Spirit);
        aux.Addcard(Ghost_Spirit);
        aux.Addcard(Gleirpnir);
        aux.Addcard(Harpy_Scout);
        aux.Addcard(Harpy_Stormcraafter);
        aux.Addcard(Helm_of_Dominator);
        aux.Addcard(Hill_Troll);
        aux.Addcard(Kobold);
        aux.Addcard(Mask_of_Madness);
        aux.Addcard(Octarine);
        for (int i = 0; i < aux.deck.Count; i++)
        {
            //agrega las respectivas cartas al deck de radiant
            if (aux.deck[i].Faction == "Radiant")
            {
                DeckRadiant.Addcard(aux.deck[i]);
                if (aux.deck[i].Faction == "Radiant" && aux.deck[i].Type == "Silver")
                {
                    DeckRadiant.Addcard(aux.deck[i]);
                    DeckRadiant.Addcard(aux.deck[i]);
                }
            }
            else if (aux.deck[i].Faction == "Dire")
            {
                DeckDire.Addcard(aux.deck[i]);
                if (aux.deck[i].Faction == "Dire" && aux.deck[i].Type == "Silver")
                {
                    DeckDire.Addcard(aux.deck[i]);
                    DeckDire.Addcard(aux.deck[i]);
                }
            }

        }
    }
    
    //queda por borrar sprites
    public void ClearDeck(Deck aux)
    {
        aux.deck.Clear();
    }

    //queda por borrar sprites
    public void Clearhand(Hand aux)
    {
        aux.hand.Clear();
    }

    public void ReturnCards() 
    {
        int random1 = UnityEngine.Random.Range(0, 10);
        int random2 = UnityEngine.Random.Range(0,DeckRadiant.deck.Count);
        int random3 = UnityEngine.Random.Range(0, 10);
if (countReturnCards == 0 || countReturnCards == 1)
        {
            if (countReturnCards == 0) {
                if (random1 != random3) {
            if (random1 == 0)
            {
                EspacioRadiant.sprite = DeckRadiant.deck[random2].Picture;
                HandRadiant.hand[0] = DeckRadiant.deck[random2];
                DeckRadiant.removeCard(DeckRadiant.deck[random2]);
            }
            else if (random1 == 1)
            {
                EspacioRadiant1.sprite = DeckRadiant.deck[random2].Picture;
                HandRadiant.hand[1] = DeckRadiant.deck[random2];
                DeckRadiant.removeCard(DeckRadiant.deck[random2]);
            }
            else if (random1 == 2)
            {
                EspacioRadiant1.sprite = DeckRadiant.deck[random2].Picture;
                HandRadiant.hand[2] = DeckRadiant.deck[random2];
                DeckRadiant.removeCard(DeckRadiant.deck[random2]);
            }
            else if (random1 == 3)
            {
                EspacioRadiant3.sprite = DeckRadiant.deck[random2].Picture;
                HandRadiant.hand[3] = DeckRadiant.deck[random2];
                DeckRadiant.removeCard(DeckRadiant.deck[random2]);
            }
            else if (random1 == 4)
            {
                EspacioRadiant4.sprite = DeckRadiant.deck[random2].Picture;
                HandRadiant.hand[4] = DeckRadiant.deck[random2];
                DeckRadiant.removeCard(DeckRadiant.deck[random2]);
            }
            else if (random1 == 5)
            {
                EspacioRadiant5.sprite = DeckRadiant.deck[random2].Picture;
                HandRadiant.hand[5] = DeckRadiant.deck[random2];
                DeckRadiant.removeCard(DeckRadiant.deck[random2]);
            }
            else if (random1 == 6)
            {
                EspacioRadiant6.sprite = DeckRadiant.deck[random2].Picture;
                HandRadiant.hand[6] = DeckRadiant.deck[random2];
                DeckRadiant.removeCard(DeckRadiant.deck[random2]);
            }
            else if (random1 == 7)
            {
                EspacioRadiant7.sprite = DeckRadiant.deck[random2].Picture;
                HandRadiant.hand[7] = DeckRadiant.deck[random2];
                DeckRadiant.removeCard(DeckRadiant.deck[random2]);
            }
            else if (random1 == 8)
            {
                EspacioRadiant8.sprite = DeckRadiant.deck[random2].Picture;
                HandRadiant.hand[8] = DeckRadiant.deck[random2];
                DeckRadiant.removeCard(DeckRadiant.deck[random2]);
            }
            else if (random1 == 9)
            {
                EspacioRadiant9.sprite = DeckRadiant.deck[random2].Picture;
                HandRadiant.hand[9] = DeckRadiant.deck[random2];
                DeckRadiant.removeCard(DeckRadiant.deck[random2]);
            }

            int random4 = UnityEngine.Random.Range(0, DeckRadiant.deck.Count);
            if (random3 == 0)
            {
                EspacioRadiant.sprite = DeckRadiant.deck[random4].Picture;
                HandRadiant.hand[0] = DeckRadiant.deck[random4];
                DeckRadiant.removeCard(DeckRadiant.deck[random4]);
            }
            else if (random3 == 1)
            {
                EspacioRadiant1.sprite = DeckRadiant.deck[random4].Picture;
                HandRadiant.hand[1] = DeckRadiant.deck[random4];
                DeckRadiant.removeCard(DeckRadiant.deck[random4]);
            }
            else if (random3 == 2)
            {
                EspacioRadiant2.sprite = DeckRadiant.deck[random4].Picture;
                HandRadiant.hand[2] = DeckRadiant.deck[random4];
                DeckRadiant.removeCard(DeckRadiant.deck[random4]);
            }
            else if (random3 == 3)
            {
                EspacioRadiant3.sprite = DeckRadiant.deck[random4].Picture;
                HandRadiant.hand[3] = DeckRadiant.deck[random4];
                DeckRadiant.removeCard(DeckRadiant.deck[random4]);
            }
            else if (random3 == 4)
            {
                EspacioRadiant4.sprite = DeckRadiant.deck[random4].Picture;
                HandRadiant.hand[4] = DeckRadiant.deck[random4];
                DeckRadiant.removeCard(DeckRadiant.deck[random4]);
            }
            else if (random3 == 5)
            {
                EspacioRadiant5.sprite = DeckRadiant.deck[random4].Picture;
                HandRadiant.hand[5] = DeckRadiant.deck[random4];
                DeckRadiant.removeCard(DeckRadiant.deck[random4]);
            }
            else if (random3 == 6)
            {
                EspacioRadiant6.sprite = DeckRadiant.deck[random4].Picture;
                HandRadiant.hand[6] = DeckRadiant.deck[random4];
                DeckRadiant.removeCard(DeckRadiant.deck[random4]);
            }
            else if (random3 == 7)
            {
                EspacioRadiant7.sprite = DeckRadiant.deck[random4].Picture;
                HandRadiant.hand[7] = DeckRadiant.deck[random4];
                DeckRadiant.removeCard(DeckRadiant.deck[random4]);
            }
            else if (random3 == 8)
            {
                EspacioRadiant8.sprite = DeckRadiant.deck[random4].Picture;
                HandRadiant.hand[8] = DeckRadiant.deck[random4];
                DeckRadiant.removeCard(DeckRadiant.deck[random4]);
            }
            else if (random3 == 9)
            {
                EspacioRadiant9.sprite = DeckRadiant.deck[random4].Picture;
                HandRadiant.hand[9] = DeckRadiant.deck[random4];
                DeckRadiant.removeCard(DeckRadiant.deck[random4]);
            }
        }
                else if (random1 == random3)
        {
            if (random1 == 0)
            {
                EspacioRadiant.sprite = DeckRadiant.deck[random2].Picture;
                HandRadiant.hand[0] = DeckRadiant.deck[random2];
                DeckRadiant.removeCard(DeckRadiant.deck[random2]);
            }
            else if (random1 != 0) 
            {
                EspacioRadiant.sprite = DeckRadiant.deck[random2].Picture;
                HandRadiant.hand[random1] = DeckRadiant.deck[random2];
                DeckRadiant.removeCard(DeckRadiant.deck[random2]);
            }
            countReturnCards++;
        }
            }
            countReturnCards++;
        }
    if (countReturnCards == 2) 
        { 
            if (random1 != random3)
        {
            if (random1 == 0)
            {
                EspacioDire.sprite = DeckDire.deck[random2].Picture;
                HandDire.hand[0] = DeckDire.deck[random2];
                DeckDire.removeCard(DeckDire.deck[random2]);
            }
            else if (random1 == 1)
            {
                EspacioDire.sprite = DeckDire.deck[random2].Picture;
                HandDire.hand[1] = DeckDire.deck[random2];
                DeckDire.removeCard(DeckDire.deck[random2]);
            }
            else if (random1 == 2)
            {
                EspacioDire.sprite = DeckDire.deck[random2].Picture;
                HandDire.hand[2] = DeckDire.deck[random2];
                DeckDire.removeCard(DeckDire.deck[random2]);
            }
            else if (random1 == 3)
            {
                EspacioDire3.sprite = DeckDire.deck[random2].Picture;
                HandDire.hand[3] = DeckDire.deck[random2];
                DeckDire.removeCard(DeckDire.deck[random2]);
            }
            else if (random1 == 4)
            {
                EspacioDire4.sprite = DeckDire.deck[random2].Picture;
                HandDire.hand[4] = DeckDire.deck[random2];
                DeckDire.removeCard(DeckDire.deck[random2]);
            }
            else if (random1 == 5)
            {
                EspacioDire5.sprite = DeckDire.deck[random2].Picture;
                HandDire.hand[5] = DeckDire.deck[random2];
                DeckDire.removeCard(DeckDire.deck[random2]);
            }
            else if (random1 == 6)
            {
                EspacioDire6.sprite = DeckDire.deck[random2].Picture;
                HandDire.hand[6] = DeckDire.deck[random2];
                DeckDire.removeCard(DeckDire.deck[random2]);
            }
            else if (random1 == 7)
            {
                EspacioDire7.sprite = DeckDire.deck[random2].Picture;
                HandDire.hand[7] = DeckDire.deck[random2];
                DeckDire.removeCard(DeckDire.deck[random2]);
            }
            else if (random1 == 8)
            {
                EspacioDire8.sprite = DeckDire.deck[random2].Picture;
                HandDire.hand[8] = DeckDire.deck[random2];
                DeckDire.removeCard(DeckDire.deck[random2]);
            }
            else if (random1 == 9)
            {
                EspacioDire9.sprite = DeckDire.deck[random2].Picture;
                HandDire.hand[9] = DeckDire.deck[random2];
                DeckDire.removeCard(DeckDire.deck[random2]);
            }

            int random4 = UnityEngine.Random.Range(0, DeckDire.deck.Count);
            if (random3 == 0)
            {
                EspacioDire.sprite = DeckDire.deck[random4].Picture;
                HandDire.hand[0] = DeckDire.deck[random4];
                DeckDire.removeCard(DeckDire.deck[random4]);
            }
            else if (random3 == 1)
            {
                EspacioDire.sprite = DeckDire.deck[random4].Picture;
                HandDire.hand[1] = DeckDire.deck[random4];
                DeckDire.removeCard(DeckDire.deck[random4]);
            }
            else if (random3 == 6)
            {
                EspacioDire6.sprite = DeckDire.deck[random4].Picture;
                HandDire.hand[6] = DeckDire.deck[random4];
                DeckDire.removeCard(DeckDire.deck[random4]);
            }
            else if (random3 == 7)
            {
                EspacioDire7.sprite = DeckDire.deck[random4].Picture;
                HandDire.hand[7] = DeckDire.deck[random4];
                DeckDire.removeCard(DeckDire.deck[random4]);
            }
            else if (random3 == 8)
            {
                EspacioDire8.sprite = DeckDire.deck[random4].Picture;
                HandDire.hand[8] = DeckDire.deck[random4];
                DeckDire.removeCard(DeckDire.deck[random4]);
            }
            else if (random3 == 9)
            {
                EspacioDire9.sprite = DeckDire.deck[random4].Picture;
                HandDire.hand[9] = DeckDire.deck[random4];
                DeckDire.removeCard(DeckDire.deck[random4]);
            }
        }
            else if (random1 == random3)
        {
            if (random1 == 0)
            {
                EspacioDire.sprite = DeckDire.deck[random2].Picture;
                HandDire.hand[0] = DeckDire.deck[random2];
                DeckDire.removeCard(DeckDire.deck[random2]);
            }
            else if (random1 != 0)
            {
                EspacioDire.sprite = DeckDire.deck[random2].Picture;
                HandDire.hand[random1] = DeckDire.deck[random2];
                DeckDire.removeCard(DeckDire.deck[random2]);
            }
        }
            countReturnCards++;
        }
    }


    //pincha
    public void StartGame()
    {
        HandRadiant.AddRandomCard(DeckRadiant);
        HandDire.AddRandomCard(DeckDire);
        EspacioRadiant.sprite = HandRadiant.hand[0].Picture;
        EspacioRadiant1.sprite = HandRadiant.hand[1].Picture;
        EspacioRadiant2.sprite = HandRadiant.hand[2].Picture;
        EspacioRadiant3.sprite = HandRadiant.hand[3].Picture;
        EspacioRadiant4.sprite = HandRadiant.hand[4].Picture;
        EspacioRadiant5.sprite = HandRadiant.hand[5].Picture;
        EspacioRadiant6.sprite = HandRadiant.hand[6].Picture;
        EspacioRadiant7.sprite = HandRadiant.hand[7].Picture;
        EspacioRadiant8.sprite = HandRadiant.hand[8].Picture;
        EspacioRadiant9.sprite = HandRadiant.hand[9].Picture;

        EspacioDire.sprite = HandDire.hand[0].Picture;
        EspacioDire1.sprite = HandDire.hand[1].Picture;
        EspacioDire2.sprite = HandDire.hand[2].Picture;
        EspacioDire3.sprite = HandDire.hand[3].Picture;
        EspacioDire4.sprite = HandDire.hand[4].Picture;
        EspacioDire5.sprite = HandDire.hand[5].Picture;
        EspacioDire6.sprite = HandDire.hand[6].Picture;
        EspacioDire7.sprite = HandDire.hand[7].Picture;
        EspacioDire8.sprite = HandDire.hand[8].Picture;
        EspacioDire9.sprite = HandDire.hand[9].Picture;
    }

    //queda por hacer
    public void PassTurn()
    {
        //aqui va tambien el sistema de puntos junto con el sistema de turnos
        countTurns2++;
        //tengo que hacer que el contador de turnos 2 disminuya cuando se invoque
        if (countTurns == 0)
        {
            countTurns++;
        }
        else if (countTurns == 1)
        {
            countTurns--;
        }
        if (countTurns2 == 2)
        {
            if (countPointsRadiant > countPointsDire)
            {
                RoundWinerRadiant++;
                countTurns = 0;
            }
            else if(countPointsDire > countPointsRadiant)
            {
                RoundWinerDire++;
                countTurns = 1;

            }
            else if (countPointsRadiant == countPointsDire)
            {
                RoundWinerRadiant++;
                RoundWinerDire++;
            }
            while (countDraw < 2 && countTurns2 != 0)
            {
                //aqui tbn tengo que hacer sistema de robo 
                if (EspacioRadiant.sprite == null)
                {
                    HandRadiant.AddRandomsCard2(DeckRadiant);
                    HandRadiant.hand[0] = HandRadiant.hand[HandRadiant.hand.Count - 1];
                    HandRadiant.hand[HandRadiant.hand.Count - 1].IsDestroyed();
                    EspacioRadiant.sprite = HandRadiant.hand[0].Picture;
                    countDraw++;
                }
                if (EspacioRadiant1.sprite == null)
                {
                    HandRadiant.AddRandomsCard2(DeckRadiant);
                    HandRadiant.hand[1] = HandRadiant.hand[HandRadiant.hand.Count - 1];
                    HandRadiant.hand[HandRadiant.hand.Count - 1].IsDestroyed();
                    EspacioRadiant1.sprite = HandRadiant.hand[1].Picture;
                    countDraw++;
                }
                if (EspacioRadiant2.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandRadiant.AddRandomsCard2(DeckRadiant);
                    HandRadiant.hand[2] = HandRadiant.hand[HandRadiant.hand.Count - 1];
                    HandRadiant.hand[HandRadiant.hand.Count - 1].IsDestroyed();
                    EspacioRadiant2.sprite = HandRadiant.hand[2].Picture;
                    countDraw++;

                }
                if (EspacioRadiant3.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandRadiant.AddRandomsCard2(DeckRadiant);
                    HandRadiant.hand[3] = HandRadiant.hand[HandRadiant.hand.Count - 1];
                    HandRadiant.hand[HandRadiant.hand.Count - 1].IsDestroyed();
                    EspacioRadiant3.sprite = HandRadiant.hand[3].Picture;
                    countDraw++;
                }
                if (EspacioRadiant4.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandRadiant.AddRandomsCard2(DeckRadiant);
                    HandRadiant.hand[4] = HandRadiant.hand[HandRadiant.hand.Count - 1];
                    HandRadiant.hand[HandRadiant.hand.Count - 1].IsDestroyed();
                    EspacioRadiant4.sprite = HandRadiant.hand[4].Picture;
                    countDraw++;
                }
                if (EspacioRadiant5.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandRadiant.AddRandomsCard2(DeckRadiant);
                    HandRadiant.hand[5] = HandRadiant.hand[HandRadiant.hand.Count - 1];
                    HandRadiant.hand[HandRadiant.hand.Count - 1].IsDestroyed();
                    EspacioRadiant5.sprite = HandRadiant.hand[5].Picture;
                    countDraw++;
                }
                if (EspacioRadiant6.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandRadiant.AddRandomsCard2(DeckRadiant);
                    HandRadiant.hand[6] = HandRadiant.hand[HandRadiant.hand.Count - 1];
                    HandRadiant.hand[HandRadiant.hand.Count - 1].IsDestroyed();
                    EspacioRadiant6.sprite = HandRadiant.hand[6].Picture;
                    countDraw++;
                }
                if (EspacioRadiant7.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandRadiant.AddRandomsCard2(DeckRadiant);
                    HandRadiant.hand[7] = HandRadiant.hand[HandRadiant.hand.Count - 1];
                    HandRadiant.hand[HandRadiant.hand.Count - 1].IsDestroyed();
                    EspacioRadiant7.sprite = HandRadiant.hand[7].Picture;
                    countDraw++;
                }
                if (EspacioRadiant8.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandRadiant.AddRandomsCard2(DeckRadiant);
                    HandRadiant.hand[8] = HandRadiant.hand[HandRadiant.hand.Count - 1];
                    HandRadiant.hand[HandRadiant.hand.Count - 1].IsDestroyed();
                    EspacioRadiant8.sprite = HandRadiant.hand[8].Picture;
                    countDraw++;
                }
                if (EspacioRadiant9.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandRadiant.AddRandomsCard2(DeckRadiant);
                    HandRadiant.hand[9] = HandRadiant.hand[HandRadiant.hand.Count - 1];
                    HandRadiant.hand[HandRadiant.hand.Count - 1].IsDestroyed();
                    EspacioRadiant9.sprite = HandRadiant.hand[9].Picture;
                    countDraw++;
                }
                break;
            }
            countDraw = 0;
            while (countDraw < 2 && countTurns2 != 0)
            {
                if (EspacioDire.sprite == null)
                {
                    HandDire.AddRandomsCard2(DeckDire);
                    HandDire.hand[0] = HandDire.hand[HandDire.hand.Count - 1];
                    HandDire.hand[HandDire.hand.Count - 1].IsDestroyed();
                    EspacioDire.sprite = HandDire.hand[0].Picture;
                    countDraw++;
                }
                if (EspacioDire1.sprite == null)
                {
                    HandDire.AddRandomsCard2(DeckDire);
                    HandDire.hand[1] = HandDire.hand[HandDire.hand.Count - 1];
                    HandDire.hand[HandDire.hand.Count - 1].IsDestroyed();
                    EspacioDire1.sprite = HandDire.hand[1].Picture;
                    countDraw++;
                }
                if (EspacioDire2.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandDire.AddRandomsCard2(DeckDire);
                    HandDire.hand[2] = HandDire.hand[HandDire.hand.Count - 1];
                    HandDire.hand[HandDire.hand.Count - 1].IsDestroyed();
                    EspacioDire2.sprite = HandDire.hand[2].Picture;
                    countDraw++;
                }
                if (EspacioDire3.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandDire.AddRandomsCard2(DeckDire);
                    HandDire.hand[3] = HandDire.hand[HandDire.hand.Count - 1];
                    HandDire.hand[HandDire.hand.Count - 1].IsDestroyed();
                    EspacioDire3.sprite = HandDire.hand[3].Picture;
                    countDraw++;
                }
                if (EspacioDire4.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandDire.AddRandomsCard2(DeckDire);
                    HandDire.hand[4] = HandDire.hand[HandDire.hand.Count - 1];
                    HandDire.hand[HandDire.hand.Count - 1].IsDestroyed();
                    EspacioDire4.sprite = HandDire.hand[4].Picture;
                    countDraw++;
                }
                if (EspacioDire5.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandDire.AddRandomsCard2(DeckDire);
                    HandDire.hand[5] = HandDire.hand[HandDire.hand.Count - 1];
                    HandDire.hand[HandDire.hand.Count - 1].IsDestroyed();
                    EspacioDire5.sprite = HandDire.hand[5].Picture;
                    countDraw++;
                }
                if (EspacioDire6.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandDire.AddRandomsCard2(DeckDire);
                    HandDire.hand[6] = HandDire.hand[HandDire.hand.Count - 1];
                    HandDire.hand[HandDire.hand.Count - 1].IsDestroyed();
                    EspacioDire6.sprite = HandDire.hand[6].Picture;
                    countDraw++;
                }
                if (EspacioDire7.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandDire.AddRandomsCard2(DeckDire);
                    HandDire.hand[7] = HandDire.hand[HandDire.hand.Count - 1];
                    HandDire.hand[HandDire.hand.Count - 1].IsDestroyed();
                    EspacioDire7.sprite = HandDire.hand[7].Picture;
                    countDraw++;
                }
                if (EspacioDire8.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandDire.AddRandomsCard2(DeckDire);
                    HandDire.hand[8] = HandDire.hand[HandDire.hand.Count - 1];
                    HandDire.hand[HandDire.hand.Count - 1].IsDestroyed();
                    EspacioDire8.sprite = HandDire.hand[8].Picture;
                    countDraw++;
                }
                if (EspacioDire9.sprite == null)
                {
                    if (countDraw == 2)
                    {
                        break;
                    }
                    HandDire.AddRandomsCard2(DeckDire);
                    HandDire.hand[9] = HandDire.hand[HandDire.hand.Count - 1];
                    HandDire.hand[HandDire.hand.Count - 1].IsDestroyed();
                    EspacioDire9.sprite = HandDire.hand[9].Picture;
                    countDraw++;
                }
                break;
            }
            countDraw = 0;
            countPointsRadiant = 0;
            countPointsDire = 0;
            ShowCountRadiant.text = countPointsRadiant.ToString();
            ShowCountDire.text = countPointsDire.ToString();
            RoundRadiant.text = RoundWinerRadiant.ToString();
            RoundDire.text = RoundWinerDire.ToString();
            countTurns2 = 0;
            countTurns3++;

            MeleeRadiant.sprite = null;
            MeleeRadiant2.sprite = null;
            MeleeDire1.sprite = null;
            MeleeDire2.sprite = null;
            RangeRadiant1.sprite = null;
            RangeRadiant2.sprite = null;
            RangeDire1.sprite = null;
            RangeDire2.sprite = null;
            AsedyRadiant1.sprite = null;
            AsedyRadiant2.sprite = null;
            AsedyDire1.sprite = null;
            AsedyDire2.sprite = null;
            CampoRadiant1.sprite = null;
            CampoDire1.sprite = null;
        }
        if (countTurns3 == 3)
        {
            //queda hacer el texto para decir quien es el ganador
            Application.Quit();
        }
    }

    //pincha

    /*2 errores ,las cartas desaparecen y cuando lo hacen suman los puntos igual ,hacer un if para que las cartas reaparezcan y se resten los puntos de nuevo,ejemplo : si la carta es de tipo melee y los campos
    son diferentes de null ,reaparezco el sprite la carta y resto los puntos ,asi hago 4 condiciones para cada 1 de los campos y con esto queda terminada la fase de invocaciones
     */
    public void MostrarRadiant()
    {
        if (countTurns == -1 || countTurns == 0) 
        {
            if (HandRadiant.hand[0].CardName != Cardname.text)
            {
                countShow = 0;
            }
            Cardname.text = HandRadiant.hand[0].CardName;
            Power.text = HandRadiant.hand[0].Power.ToString();
            Efect.text = HandRadiant.hand[0].Efect;
            Faction.text = HandRadiant.hand[0].Faction;
            FieldType.text = HandRadiant.hand[0].Description;
            if (countShow == 0)
            {
                countShow++;
            }
            else if (countShow == 1)
            {
                countShow++;
                countTurns ++;
            }
            else if (countShow > 1)
            {
                countShow = 0;
            }
        }
    }
    public void MostrarRadiant1()
    {
        if (countTurns == -1 || countTurns == 0)
        {
            if (HandRadiant.hand[1].CardName != Cardname.text)
            {
                countShow = 0;
            }
            Cardname.text = HandRadiant.hand[1].CardName;
            Power.text = HandRadiant.hand[1].Power.ToString();
            Efect.text = HandRadiant.hand[1].Efect;
            Faction.text = HandRadiant.hand[1].Faction;
            FieldType.text = HandRadiant.hand[1].Description;
            if (countShow == 0)
            {
                countShow++;
            }
            else if (countShow == 1)
            {
                countShow++;
                countTurns++;
            }
            else if (countShow > 1)
            {
                countShow = 0;
            }
        }
    }
    public void MostrarRadiant2()
    {
        if (countTurns == -1 || countTurns == 0)
        {
            if (HandRadiant.hand[2].CardName != Cardname.text)
            {
                countShow = 0;
            }
            Cardname.text = HandRadiant.hand[2].CardName;
            Power.text = HandRadiant.hand[2].Power.ToString();
            Efect.text = HandRadiant.hand[2].Efect;
            Faction.text = HandRadiant.hand[2].Faction;
            FieldType.text = HandRadiant.hand[2].Description;
            if (countShow == 0)
            {
                countShow++;
            }
            else if (countShow == 1)
            {
                countShow++;
                countTurns++;
            }
            else if (countShow > 1)
            {
                countShow = 0;
            }
        }
    }
    public void MostrarRadiant3()
    {
        if (countTurns == -1 || countTurns == 0)
        {
            if (HandRadiant.hand[3].CardName != Cardname.text)
            {
                countShow = 0;
            }
            Cardname.text = HandRadiant.hand[3].CardName;
            Power.text = HandRadiant.hand[3].Power.ToString();
            Efect.text = HandRadiant.hand[3].Efect;
            Faction.text = HandRadiant.hand[3].Faction;
            FieldType.text = HandRadiant.hand[3].Description;
            if (countShow == 0)
            {
                countShow++;
            }
            else if (countShow == 1)
            {
                countShow++;
                countTurns++;
            }
            else if (countShow > 1)
            {
                countShow = 0;
            }
        }
    }
    public void MostrarRadiant4()
    {
        if (countTurns == -1 || countTurns == 0)
        {
            if (HandRadiant.hand[4].CardName != Cardname.text)
            {
                countShow = 0;
            }
            Cardname.text = HandRadiant.hand[4].CardName;
            Power.text = HandRadiant.hand[4].Power.ToString();
            Efect.text = HandRadiant.hand[4].Efect;
            Faction.text = HandRadiant.hand[4].Faction;
            FieldType.text = HandRadiant.hand[4].Description;
            if (countShow == 0)
            {
                countShow++;
            }
            else if (countShow == 1)
            {
                countShow++;
                countTurns++;
            }
            else if (countShow > 1)
            {
                countShow = 0;
            }
        }
    }
    public void MostrarRadiant5()
    {
        if (countTurns == -1 || countTurns == 0)
        {
            if (HandRadiant.hand[5].CardName != Cardname.text)
            {
                countShow = 0;
            }
            Cardname.text = HandRadiant.hand[5].CardName;
            Power.text = HandRadiant.hand[5].Power.ToString();
            Efect.text = HandRadiant.hand[5].Efect;
            Faction.text = HandRadiant.hand[5].Faction;
            FieldType.text = HandRadiant.hand[5].Description;
            if (countShow == 0)
            {
                countShow++;
            }
            else if (countShow == 1)
            {
                countShow++;
                countTurns++;
            }
            else if (countShow > 1)
            {
                countShow = 0;
            }
        }
    }
    public void MostrarRadiant6()
    {
        if (countTurns == -1 || countTurns == 0)
        {
            if (HandRadiant.hand[6].CardName != Cardname.text)
            {
                countShow = 0;
            }
            Cardname.text = HandRadiant.hand[6].CardName;
            Power.text = HandRadiant.hand[6].Power.ToString();
            Efect.text = HandRadiant.hand[6].Efect;
            Faction.text = HandRadiant.hand[6].Faction;
            FieldType.text = HandRadiant.hand[6].Description;
            if (countShow == 0)
            {
                countShow++;
            }
            else if (countShow == 1)
            {
                countShow++;
                countTurns++;
            }
            else if (countShow > 1)
            {
                countShow = 0;
            }
        }
    }
    public void MostrarRadiant7()
    {
        if (countTurns == -1 || countTurns == 0)
        {
            if (HandRadiant.hand[7].CardName != Cardname.text)
            {
                countShow = 0;
            }
            Cardname.text = HandRadiant.hand[7].CardName;
            Power.text = HandRadiant.hand[7].Power.ToString();
            Efect.text = HandRadiant.hand[7].Efect;
            Faction.text = HandRadiant.hand[7].Faction;
            FieldType.text = HandRadiant.hand[7].Description;
            if (countShow == 0)
            {
                countShow++;
            }
            else if (countShow == 1)
            {
                countShow++;
                countTurns++;
            }
            else if (countShow > 1)
            {
                countShow = 0;
            }
        }
    }
    public void MostrarRadiant8()
    {
        if (countTurns == -1 || countTurns == 0)
        {
            if (HandRadiant.hand[8].CardName != Cardname.text)
            {
                countShow = 0;
            }
            Cardname.text = HandRadiant.hand[8].CardName;
            Power.text = HandRadiant.hand[8].Power.ToString();
            Efect.text = HandRadiant.hand[8].Efect;
            Faction.text = HandRadiant.hand[8].Faction;
            FieldType.text = HandRadiant.hand[8].Description;
            if (countShow == 0)
            {
                countShow++;
            }
            else if (countShow == 1)
            {
                countShow++;
                countTurns++;
            }
            else if (countShow > 1)
            {
                countShow = 0;
            }
        }
    }
    public void MostrarRadiant9()
    {
        if (countTurns == -1 || countTurns == 0)
        {
            if (HandRadiant.hand[9].CardName != Cardname.text)
            {
                countShow = 0;
            }
            Cardname.text = HandRadiant.hand[9].CardName;
            Power.text = HandRadiant.hand[9].Power.ToString();
            Efect.text = HandRadiant.hand[9].Efect;
            Faction.text = HandRadiant.hand[9].Faction;
            FieldType.text = HandRadiant.hand[9].Description;
            if (countShow == 0)
            {
                countShow++;
            }
            else if (countShow == 1)
            {
                countShow++;
                countTurns++;
            }
            else if (countShow > 1)
            {
                countShow = 0;
            }
        }
    }
    public void MostrarDire()
    {
        if (countTurns == 1 || countTurns == 2)
        {
            countTurns = 2;
            if (HandDire.hand[0].CardName != Cardname.text)
            {
                countShow2 = 0;
            }
            Cardname.text = HandDire.hand[0].CardName;
            Power.text = HandDire.hand[0].Power.ToString();
            Efect.text = HandDire.hand[0].Efect;
            Faction.text = HandDire.hand[0].Faction;
            FieldType.text = HandDire.hand[0].Description;
            if (countShow2 == 0)
            {
                countShow2++;
            }
            else if (countShow2 == 1)
            {
                countTurns--;
            }
        }
    }
    public void MostrarDire1()
    {

        if (countTurns == 1 || countTurns == 2)
        {
            countTurns = 2;
            if (HandDire.hand[1].CardName != Cardname.text)
            {
                countShow2 = 0;
            }
            Cardname.text = HandDire.hand[1].CardName;
            Power.text = HandDire.hand[1].Power.ToString();
            Efect.text = HandDire.hand[1].Efect;
            Faction.text = HandDire.hand[1].Faction;
            FieldType.text = HandDire.hand[1].Description;
            if (countShow2 == 0)
            {
                countShow2++;
            }
            else if (countShow2 == 1)
            {
                countTurns--;
            }
        }
    }
    public void MostrarDire2()
    {

        if (countTurns == 1 || countTurns == 2)
        {
            countTurns = 2;
            if (HandDire.hand[2].CardName != Cardname.text)
            {
                countShow2 = 0;
            }
            Cardname.text = HandDire.hand[2].CardName;
            Power.text = HandDire.hand[2].Power.ToString();
            Efect.text = HandDire.hand[2].Efect;
            Faction.text = HandDire.hand[2].Faction;
            FieldType.text = HandDire.hand[2].Description;
            if (countShow2 == 0)
            {
                countShow2++;
            }
            else if (countShow2 == 1)
            {
                countTurns--;
            }
        }
    }
    public void MostrarDire3()
    {

        if (countTurns == 1 || countTurns == 2)
        {
            countTurns = 2;
            if (HandDire.hand[3].CardName != Cardname.text)
            {
                countShow2 = 0;
            }
            Cardname.text = HandDire.hand[3].CardName;
            Power.text = HandDire.hand[3].Power.ToString();
            Efect.text = HandDire.hand[3].Efect;
            Faction.text = HandDire.hand[3].Faction;
            FieldType.text = HandDire.hand[3].Description;
            if (countShow2 == 0)
            {
                countShow2++;
            }
            else if (countShow2 == 1)
            {
                countTurns--;
            }
        }
    }
    public void MostrarDire4()
    {

        if (countTurns == 1 || countTurns == 2)
        {
            countTurns = 2;
            if (HandDire.hand[4].CardName != Cardname.text)
            {
                countShow2 = 0;
            }
            Cardname.text = HandDire.hand[4].CardName;
            Power.text = HandDire.hand[4].Power.ToString();
            Efect.text = HandDire.hand[4].Efect;
            Faction.text = HandDire.hand[4].Faction;
            FieldType.text = HandDire.hand[4].Description;
            if (countShow2 == 0)
            {
                countShow2++;
            }
            else if (countShow2 == 1)
            {
                countTurns--;
            }
        }
    }
    public void MostrarDire5()
    {

        if (countTurns == 1 || countTurns == 2)
        {
            countTurns = 2;
            if (HandDire.hand[5].CardName != Cardname.text)
            {
                countShow2 = 0;
            }
            Cardname.text = HandDire.hand[5].CardName;
            Power.text = HandDire.hand[5].Power.ToString();
            Efect.text = HandDire.hand[5].Efect;
            Faction.text = HandDire.hand[5].Faction;
            FieldType.text = HandDire.hand[5].Description;
            if (countShow2 == 0)
            {
                countShow2++;
            }
            else if (countShow2 == 1)
            {
                countTurns--;
            }
        }
    }
    public void MostrarDire6()
    {

        if (countTurns == 1 || countTurns == 2)
        {
            countTurns = 2;
            if (HandDire.hand[6].CardName != Cardname.text)
            {
                countShow2 = 0;
            }
            Cardname.text = HandDire.hand[6].CardName;
            Power.text = HandDire.hand[6].Power.ToString();
            Efect.text = HandDire.hand[6].Efect;
            Faction.text = HandDire.hand[6].Faction;
            FieldType.text = HandDire.hand[6].Description;
            if (countShow2 == 0)
            {
                countShow2++;
            }
            else if (countShow2 == 1)
            {
                countTurns--;
            }
        }
    }
    public void MostrarDire7()
    {

        if (countTurns == 1 || countTurns == 2)
        {
            countTurns = 2;
            if (HandDire.hand[7].CardName != Cardname.text)
            {
                countShow2 = 0;
            }
            Cardname.text = HandDire.hand[7].CardName;
            Power.text = HandDire.hand[7].Power.ToString();
            Efect.text = HandDire.hand[7].Efect;
            Faction.text = HandDire.hand[7].Faction;
            FieldType.text = HandDire.hand[7].Description;
            if (countShow2 == 0)
            {
                countShow2++;
            }
            else if (countShow2 == 1)
            {
                countTurns--;
            }
        }
    }
    public void MostrarDire8()
    {

        if (countTurns == 1 || countTurns == 2)
        {
            countTurns = 2;
            if (HandDire.hand[8].CardName != Cardname.text)
            {
                countShow2 = 0;
            }
            Cardname.text = HandDire.hand[8].CardName;
            Power.text = HandDire.hand[8].Power.ToString();
            Efect.text = HandDire.hand[8].Efect;
            Faction.text = HandDire.hand[8].Faction;
            FieldType.text = HandDire.hand[8].Description;
            if (countShow2 == 0)
            {
                countShow2++;
            }
            else if (countShow2 == 1)
            {
                countTurns--;
            }
        }
    }
    public void MostrarDire9()
    {

        if (countTurns == 1 || countTurns == 2)
        {
            countTurns = 2;
            if (HandDire.hand[9].CardName != Cardname.text)
            {
                countShow2 = 0;
            }
            Cardname.text = HandDire.hand[9].CardName;
            Power.text = HandDire.hand[9].Power.ToString();
            Efect.text = HandDire.hand[9].Efect;
            Faction.text = HandDire.hand[9].Faction;
            FieldType.text = HandDire.hand[9].Description;
            if (countShow2 == 0)
            {
                countShow2++;
            }
            else if (countShow2 == 1)
            {
                countTurns--;
            }
        }
    }


    public void invocar()
    {
        //muestro la carta y guerdo la misma en una carta auxiliar,si el nombre de la otra carta es igual a la auxiliar cuando se pulse de nuevo entonces countTurns++ ,si no countTurns--
        if (countTurns == 0)
        {
            if (EspacioRadiant.sprite != null)
            {
                countTurns++;
                countTurns2 = 0;
                countPointsRadiant = countPointsRadiant + HandRadiant.hand[0].Power;
            }

            if (HandRadiant.hand[0].FileType == "Melee")
            {
                if (EspacioRadiant.sprite != null && MeleeRadiant.sprite == null)
                {
                    MeleeRadiantCard = HandRadiant.hand[0];
                    MeleeRadiant.sprite = HandRadiant.hand[0].Picture;
                }
                else if (EspacioRadiant.sprite != null && MeleeRadiant.sprite != null && MeleeRadiant2.sprite == null)
                {
                    MeleeRadiant2Card = HandRadiant.hand[0];
                    MeleeRadiant2.sprite = HandRadiant.hand[0].Picture;
                }
                else if (EspacioRadiant.sprite != null && MeleeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[0].Power;
                }
            }
            else if (HandRadiant.hand[0].FileType == "Range")
            {
                if (EspacioRadiant.sprite != null && RangeRadiant1.sprite == null)
                {
                    RangeRadiant1Card = HandRadiant.hand[0];
                    RangeRadiant1.sprite = HandRadiant.hand[0].Picture;
                }
                else if (EspacioRadiant.sprite != null && RangeRadiant1.sprite != null && RangeRadiant2.sprite == null)
                {
                    RangeRadiant2Card = HandRadiant.hand[0];
                    RangeRadiant2.sprite = HandRadiant.hand[0].Picture;
                }
                else if (EspacioRadiant.sprite != null && RangeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[0].Power;
                }
            }
            else if (HandRadiant.hand[0].FileType == "Asedy")
            {

                if (EspacioRadiant.sprite != null && AsedyRadiant1.sprite == null)
                {
                    AsedyRadiant1Card = HandRadiant.hand[0];
                    AsedyRadiant1.sprite = HandRadiant.hand[0].Picture;
                }
                else if (EspacioRadiant.sprite != null && AsedyRadiant1.sprite != null && AsedyRadiant2.sprite == null)
                {
                    AsedyRadiant2Card = HandRadiant.hand[0];
                    AsedyRadiant2.sprite = HandRadiant.hand[0].Picture;
                }
                else if (EspacioRadiant.sprite != null && AsedyRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[0].Power;
                }
            }
            else if (HandRadiant.hand[0].FileType == "Efect")
            {

                if (EspacioRadiant.sprite != null && CampoRadiant1.sprite == null)
                {
                    CampoRadiant1.sprite = HandRadiant.hand[0].Picture;
                }
                else if (EspacioRadiant.sprite != null && CampoRadiant1.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[0].Power;
                }
            }
            else if (HandRadiant.hand[0].FileType == "Lider")
            {
                EspacioliderRadiant.sprite = HandRadiant.hand[0].Picture;
                LiderRadiantCard = HandRadiant.hand[0];
            }
            ShowCountRadiant.text = countPointsRadiant.ToString();
            EspacioRadiant.sprite = null;
            if (countTurns == 0)
            {
                EspacioRadiant.sprite = HandRadiant.hand[0].Picture;
            }
        }
    }
    public void invocar1()
    {
        if (countTurns == 0) {
            if (EspacioRadiant1.sprite != null)
            {
                countTurns++;
                countTurns2 = 0;
                countPointsRadiant = countPointsRadiant + HandRadiant.hand[1].Power;
            }
            if (HandRadiant.hand[1].FileType == "Melee")
            {
                if (EspacioRadiant1.sprite != null && MeleeRadiant.sprite == null)
                {
                    MeleeRadiantCard = HandRadiant.hand[1];
                    MeleeRadiant.sprite = HandRadiant.hand[1].Picture;
                }
                else if (EspacioRadiant1.sprite != null && MeleeRadiant.sprite != null && MeleeRadiant2.sprite == null)
                {
                    MeleeRadiant2Card = HandRadiant.hand[1];
                    MeleeRadiant2.sprite = HandRadiant.hand[1].Picture;
                }
                else if (EspacioRadiant1.sprite != null && MeleeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[1].Power;
                }
            }
            else if (HandRadiant.hand[1].FileType == "Range")
            {
                if (EspacioRadiant1.sprite != null && RangeRadiant1.sprite == null)
                {
                    RangeRadiant1Card = HandRadiant.hand[1];
                    RangeRadiant1.sprite = HandRadiant.hand[1].Picture;
                    EspacioRadiant1.sprite = null;
                }
                else if (EspacioRadiant1.sprite != null && RangeRadiant1.sprite != null && RangeRadiant2.sprite == null)
                {
                    RangeRadiant2Card = HandRadiant.hand[1];
                    RangeRadiant2.sprite = HandRadiant.hand[1].Picture;
                }
                else if (EspacioRadiant1.sprite != null && RangeRadiant2.sprite != null)
                {

                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[1].Power;
                }
            }
            else if (HandRadiant.hand[1].FileType == "Asedy")
            {

                if (EspacioRadiant1.sprite != null && AsedyRadiant1.sprite == null)
                {
                    AsedyRadiant1Card = HandRadiant.hand[1];
                    AsedyRadiant1.sprite = HandRadiant.hand[1].Picture;
                }
                else if (EspacioRadiant1.sprite != null && AsedyRadiant1.sprite != null && AsedyRadiant2.sprite == null)
                {
                    AsedyRadiant2Card = HandRadiant.hand[1];
                    AsedyRadiant2.sprite = HandRadiant.hand[1].Picture;
                }
                else if (EspacioRadiant1.sprite != null && AsedyRadiant2.sprite != null)
                {

                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[1].Power;
                }
            }
            else if (HandRadiant.hand[1].FileType == "Efect")
            {

                if (EspacioRadiant1.sprite != null && CampoRadiant1.sprite == null)
                {
                    CampoRadiant1.sprite = HandRadiant.hand[1].Picture;
                }
                else if (EspacioRadiant1.sprite != null && CampoRadiant1.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[1].Power;
                }
            }
            else if (HandRadiant.hand[1].FileType == "Lider")
            {
                EspacioliderRadiant.sprite = HandRadiant.hand[1].Picture;
                LiderRadiantCard = HandRadiant.hand[1];
            }
            ShowCountRadiant.text = countPointsRadiant.ToString();
            EspacioRadiant1.sprite = null;
            if (countTurns == 0)
            {
                EspacioRadiant1.sprite = HandRadiant.hand[1].Picture;
            }
            //HandRadiant.hand[1] = null;
        }
    }
    public void invocar2()
    {
        if (countTurns == 0) {
            if (EspacioRadiant2.sprite != null)
            {
                countTurns++;
                countTurns2 = 0;
                countPointsRadiant = countPointsRadiant + HandRadiant.hand[2].Power;
            }
            if (HandRadiant.hand[2].FileType == "Melee")
            {
                if (EspacioRadiant2.sprite != null && MeleeRadiant.sprite == null)
                {
                    MeleeRadiantCard = HandRadiant.hand[2];
                    MeleeRadiant.sprite = HandRadiant.hand[2].Picture;
                }
                else if (EspacioRadiant2.sprite != null && MeleeRadiant.sprite != null && MeleeRadiant2.sprite == null)
                {
                    MeleeRadiant2Card = HandRadiant.hand[2];
                    MeleeRadiant2.sprite = HandRadiant.hand[2].Picture;
                }
                else if (EspacioRadiant2.sprite != null && MeleeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[2].Power;
                }
            }
            else if (HandRadiant.hand[2].FileType == "Range")
            {
                if (EspacioRadiant2.sprite != null && RangeRadiant1.sprite == null)
                {
                    RangeRadiant1Card = HandRadiant.hand[2];
                    RangeRadiant1.sprite = HandRadiant.hand[2].Picture;
                }
                else if (EspacioRadiant2.sprite != null && RangeRadiant1.sprite != null && RangeRadiant2.sprite == null)
                {
                    RangeRadiant2Card = HandRadiant.hand[2];
                    RangeRadiant2.sprite = HandRadiant.hand[2].Picture;
                }
                else if (EspacioRadiant2.sprite != null && RangeRadiant2.sprite != null)
                {

                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[2].Power;
                }
            }
            else if (HandRadiant.hand[2].FileType == "Asedy")
            {

                if (EspacioRadiant2.sprite != null && AsedyRadiant1.sprite == null)
                {
                    AsedyRadiant1Card = HandRadiant.hand[2];
                    AsedyRadiant1.sprite = HandRadiant.hand[2].Picture;
                }
                else if (EspacioRadiant2.sprite != null && AsedyRadiant1.sprite != null && AsedyRadiant2.sprite == null)
                {
                    AsedyRadiant2Card = HandRadiant.hand[2];
                    AsedyRadiant2.sprite = HandRadiant.hand[2].Picture;
                }
                else if (EspacioRadiant2.sprite != null && AsedyRadiant2.sprite != null)
                {

                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[2].Power;
                }
            }
            else if (HandRadiant.hand[2].FileType == "Efect")
            {


                if (EspacioRadiant2.sprite != null && CampoRadiant1.sprite == null)
                {
                    CampoRadiant1.sprite = HandRadiant.hand[2].Picture;
                }
                else if (EspacioRadiant2.sprite != null && CampoRadiant1.sprite != null)
                {

                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[2].Power;
                }
            }
            else if (HandRadiant.hand[2].FileType == "Lider")
            {
                EspacioliderRadiant.sprite = HandRadiant.hand[2].Picture;
                LiderRadiantCard = HandRadiant.hand[2];
            }
            ShowCountRadiant.text = countPointsRadiant.ToString();
            EspacioRadiant2.sprite = null;
            if (countTurns == 0)
            {
                EspacioRadiant2.sprite = HandRadiant.hand[2].Picture;
            }
            //HandRadiant.hand[2] = null;
        }
    }
    public void invocar3()
    {
        if (countTurns == 0)
        {
            if (EspacioRadiant3.sprite != null)
            {
                countTurns++;
                countTurns2 = 0;
                countPointsRadiant = countPointsRadiant + HandRadiant.hand[3].Power;
            }
            if (HandRadiant.hand[3].FileType == "Melee")
            {
                if (EspacioRadiant3.sprite != null && MeleeRadiant.sprite == null)
                {
                    MeleeRadiantCard = HandRadiant.hand[3];
                    MeleeRadiant.sprite = HandRadiant.hand[3].Picture;
                }
                else if (EspacioRadiant3.sprite != null && MeleeRadiant.sprite != null && MeleeRadiant2.sprite == null)
                {
                    MeleeRadiant2Card = HandRadiant.hand[3];
                    MeleeRadiant2.sprite = HandRadiant.hand[3].Picture;
                }
                else if (EspacioRadiant3.sprite != null && MeleeRadiant2.sprite != null)
                {

                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[3].Power;
                }
            }
            else if (HandRadiant.hand[3].FileType == "Range")
            {
                if (EspacioRadiant3.sprite != null && RangeRadiant1.sprite == null)
                {
                    RangeRadiant1Card = HandRadiant.hand[3];
                    RangeRadiant1.sprite = HandRadiant.hand[3].Picture;
                }
                else if (EspacioRadiant3.sprite != null && RangeRadiant1.sprite != null && RangeRadiant2.sprite == null)
                {
                    RangeRadiant2Card = HandRadiant.hand[3];
                    RangeRadiant2.sprite = HandRadiant.hand[3].Picture;
                }
                else if (EspacioRadiant3.sprite != null && RangeRadiant2.sprite != null)
                {

                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[3].Power;
                }
            }
            else if (HandRadiant.hand[3].FileType == "Asedy")
            {

                if (EspacioRadiant3.sprite != null && AsedyRadiant1.sprite == null)
                {
                    AsedyRadiant1Card = HandRadiant.hand[3];
                    AsedyRadiant1.sprite = HandRadiant.hand[3].Picture;
                }
                else if (EspacioRadiant3.sprite != null && AsedyRadiant1.sprite != null && AsedyRadiant2.sprite == null)
                {
                    AsedyRadiant2Card = HandRadiant.hand[3];
                    AsedyRadiant2.sprite = HandRadiant.hand[3].Picture;
                }
                else if (EspacioRadiant3.sprite != null && AsedyRadiant2.sprite != null)
                {

                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[3].Power;
                }
            }
            else if (HandRadiant.hand[3].FileType == "Efect")
            {


                if (EspacioRadiant3.sprite != null && CampoRadiant1.sprite == null)
                {
                    CampoRadiant1.sprite = HandRadiant.hand[3].Picture;
                }
                else if (EspacioRadiant3.sprite != null && CampoRadiant1.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[3].Power;
                }

            }
            else if (HandRadiant.hand[3].FileType == "Lider")
            {
                EspacioliderRadiant.sprite = HandRadiant.hand[3].Picture;
                LiderRadiantCard = HandRadiant.hand[3];
            }
            ShowCountRadiant.text = countPointsRadiant.ToString();
            EspacioRadiant3.sprite = null;
            if (countTurns == 0)
            {
                EspacioRadiant3.sprite = HandRadiant.hand[3].Picture;
            }
        }
    }
    public void invocar4()
    {
        if (countTurns == 0)
        {
            if (EspacioRadiant4.sprite != null)
            {
                countTurns++;
                countTurns2 = 0;
                countPointsRadiant = countPointsRadiant + HandRadiant.hand[4].Power;
            }
            if (HandRadiant.hand[4].FileType == "Melee")
            {
                if (EspacioRadiant4.sprite != null && MeleeRadiant.sprite == null)
                {
                    MeleeRadiantCard = HandRadiant.hand[4];
                    MeleeRadiant.sprite = HandRadiant.hand[4].Picture;
                }
                else if (EspacioRadiant4.sprite != null && MeleeRadiant.sprite != null && MeleeRadiant2.sprite == null)
                {
                    MeleeRadiant2Card = HandRadiant.hand[4];
                    MeleeRadiant2.sprite = HandRadiant.hand[4].Picture;
                }
                else if (EspacioRadiant4.sprite != null && MeleeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[4].Power;
                }
            }
            else if (HandRadiant.hand[4].FileType == "Range")
            {
                if (EspacioRadiant4.sprite != null && RangeRadiant1.sprite == null)
                {
                    RangeRadiant1Card = HandRadiant.hand[4];
                    RangeRadiant1.sprite = HandRadiant.hand[4].Picture;
                }
                else if (EspacioRadiant4.sprite != null && RangeRadiant1.sprite != null && RangeRadiant2.sprite == null)
                {
                    RangeRadiant2Card = HandRadiant.hand[4];
                    RangeRadiant2.sprite = HandRadiant.hand[4].Picture;
                }
                else if (EspacioRadiant4.sprite != null && RangeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[4].Power;
                }
            }
            else if (HandRadiant.hand[4].FileType == "Asedy")
            {

                if (EspacioRadiant4.sprite != null && AsedyRadiant1.sprite == null)
                {
                    AsedyRadiant1Card = HandRadiant.hand[4];
                    AsedyRadiant1.sprite = HandRadiant.hand[4].Picture;
                }
                else if (EspacioRadiant4.sprite != null && AsedyRadiant1.sprite != null && AsedyRadiant2.sprite == null)
                {
                    AsedyRadiant2Card = HandRadiant.hand[4];
                    AsedyRadiant2.sprite = HandRadiant.hand[4].Picture;
                }
                else if (EspacioRadiant4.sprite != null && AsedyRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[4].Power;
                }
            }
            else if (HandRadiant.hand[4].FileType == "Efect")
            {


                if (EspacioRadiant4.sprite != null && CampoRadiant1.sprite == null)
                {
                    CampoRadiant1.sprite = HandRadiant.hand[4].Picture;
                }
                else if (EspacioRadiant4.sprite != null && CampoRadiant1.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[4].Power;
                }
            }
            else if (HandRadiant.hand[4].FileType == "Lider")
            {
                EspacioliderRadiant.sprite = HandRadiant.hand[4].Picture;
                LiderRadiantCard = HandRadiant.hand[4];
            }
            ShowCountRadiant.text = countPointsRadiant.ToString();
            EspacioRadiant4.sprite = null;
            if (countTurns == 0)
            {
                EspacioRadiant4.sprite = HandRadiant.hand[4].Picture;
            }
        }
    }
    public void invocar5()
    {
        if (countTurns == 0)
        {
            if (EspacioRadiant5.sprite != null)
            {
                countTurns++;
                countTurns2 = 0;
                countPointsRadiant = countPointsRadiant + HandRadiant.hand[5].Power;
            }
            if (HandRadiant.hand[5].FileType == "Melee")
            {
                if (EspacioRadiant5.sprite != null && MeleeRadiant.sprite == null)
                {
                    MeleeRadiantCard = HandRadiant.hand[5];
                    MeleeRadiant.sprite = HandRadiant.hand[5].Picture;
                }
                else if (EspacioRadiant5.sprite != null && MeleeRadiant.sprite != null && MeleeRadiant2.sprite == null)
                {
                    MeleeRadiant2Card = HandRadiant.hand[5];
                    MeleeRadiant2.sprite = HandRadiant.hand[5].Picture;
                }
                else if (EspacioRadiant5.sprite != null && MeleeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[5].Power;
                }
            }
            else if (HandRadiant.hand[5].FileType == "Range")
            {
                if (EspacioRadiant5.sprite != null && RangeRadiant1.sprite == null)
                {
                    RangeRadiant1Card = HandRadiant.hand[5];
                    RangeRadiant1.sprite = HandRadiant.hand[5].Picture;
                }
                else if (EspacioRadiant.sprite != null && RangeRadiant1.sprite != null && RangeRadiant2.sprite == null)
                {
                    RangeRadiant2Card = HandRadiant.hand[5];
                    RangeRadiant2.sprite = HandRadiant.hand[5].Picture;
                }
                else if (EspacioRadiant5.sprite != null && RangeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[5].Power;
                }
            }
            else if (HandRadiant.hand[5].FileType == "Asedy")
            {

                if (EspacioRadiant5.sprite != null && AsedyRadiant1.sprite == null)
                {
                    AsedyRadiant1Card = HandRadiant.hand[5];
                    AsedyRadiant1.sprite = HandRadiant.hand[5].Picture;
                }
                else if (EspacioRadiant5.sprite != null && AsedyRadiant1.sprite != null && AsedyRadiant2.sprite == null)
                {
                    AsedyRadiant2Card = HandRadiant.hand[5];
                    AsedyRadiant2.sprite = HandRadiant.hand[5].Picture;
                }
                else if (EspacioRadiant5.sprite != null && AsedyRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[5].Power;
                }
            }
            else if (HandRadiant.hand[5].FileType == "Efect")
            {


                if (EspacioRadiant5.sprite != null && CampoRadiant1.sprite == null)
                {
                    CampoRadiant1.sprite = HandRadiant.hand[5].Picture;
                }
                else if (EspacioRadiant5.sprite != null && CampoRadiant1.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[5].Power;
                }
            }
            else if (HandRadiant.hand[5].FileType == "Lider")
            {
                EspacioliderRadiant.sprite = HandRadiant.hand[5].Picture;
                LiderRadiantCard = HandRadiant.hand[5];
            }
            ShowCountRadiant.text = countPointsRadiant.ToString();
            EspacioRadiant5.sprite = null;
            //HandRadiant.hand[5] = null;
            if (countTurns == 0)
            {
                EspacioRadiant5.sprite = HandRadiant.hand[5].Picture;
            }
        }
    }
    public void invocar6()
    {
        if (countTurns == 0)
        {
            if (EspacioRadiant6.sprite != null)
            {
                countTurns++;
                countTurns2 = 0;
                countPointsRadiant = countPointsRadiant + HandRadiant.hand[6].Power;
            }
            if (HandRadiant.hand[6].FileType == "Melee")
            {
                if (EspacioRadiant6.sprite != null && MeleeRadiant.sprite == null)
                {
                    MeleeRadiantCard = HandRadiant.hand[6];
                    MeleeRadiant.sprite = HandRadiant.hand[6].Picture;

                }
                else if (EspacioRadiant6.sprite != null && MeleeRadiant.sprite != null && MeleeRadiant2.sprite == null)
                {
                    MeleeRadiant2Card = HandRadiant.hand[6];
                    MeleeRadiant2.sprite = HandRadiant.hand[6].Picture;
                }
                else if (EspacioRadiant6.sprite != null && MeleeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[6].Power;
                }
            }
            else if (HandRadiant.hand[6].FileType == "Range")
            {
                if (EspacioRadiant6.sprite != null && RangeRadiant1.sprite == null)
                {
                    RangeRadiant1Card = HandRadiant.hand[6];
                    RangeRadiant1.sprite = HandRadiant.hand[6].Picture;

                }
                else if (EspacioRadiant6.sprite != null && RangeRadiant1.sprite != null && RangeRadiant2.sprite == null)
                {
                    RangeRadiant2Card = HandRadiant.hand[6];
                    RangeRadiant2.sprite = HandRadiant.hand[6].Picture;
                }
                else if (EspacioRadiant6.sprite != null && RangeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[6].Power;
                }
            }
            else if (HandRadiant.hand[6].FileType == "Asedy")
            {

                if (EspacioRadiant6.sprite != null && AsedyRadiant1.sprite == null)
                {
                    AsedyRadiant1Card = HandRadiant.hand[6];
                    AsedyRadiant1.sprite = HandRadiant.hand[6].Picture;
                    EspacioRadiant.sprite = null;
                }
                else if (EspacioRadiant6.sprite != null && AsedyRadiant1.sprite != null && AsedyRadiant2.sprite == null)
                {
                    AsedyRadiant2Card = HandRadiant.hand[6];
                    AsedyRadiant2.sprite = HandRadiant.hand[6].Picture;
                }
                else if (EspacioRadiant6.sprite != null && AsedyRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[6].Power;
                }
            }
            else if (HandRadiant.hand[6].FileType == "Efect")
            {


                if (EspacioRadiant6.sprite != null && CampoRadiant1.sprite == null)
                {
                    CampoRadiant1.sprite = HandRadiant.hand[6].Picture;
                }
                else if ( EspacioRadiant6.sprite != null & CampoRadiant1.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[6].Power;
                }
            }
            else if (HandRadiant.hand[6].FileType == "Lider")
            {
                EspacioliderRadiant.sprite = HandRadiant.hand[6].Picture;
                LiderRadiantCard = HandRadiant.hand[6];
            }
            ShowCountRadiant.text = countPointsRadiant.ToString();
            EspacioRadiant6.sprite = null;
            //HandRadiant.hand[6] = null;
            if (countTurns == 0)
            {
                EspacioRadiant6.sprite = HandRadiant.hand[6].Picture;
            }
        }
    }
    public void invocar7()
    {
        if (countTurns == 0)
        {
            if (EspacioRadiant7.sprite != null)
            {
                countTurns++;
                countTurns2 = 0;
                countPointsRadiant = countPointsRadiant + HandRadiant.hand[7].Power;
            }
            if (HandRadiant.hand[7].FileType == "Melee")
            {
                if (EspacioRadiant7.sprite != null && MeleeRadiant.sprite == null)
                {
                    MeleeRadiantCard = HandRadiant.hand[7];
                    MeleeRadiant.sprite = HandRadiant.hand[7].Picture;
                }
                else if (EspacioRadiant7.sprite != null && MeleeRadiant.sprite != null && MeleeRadiant2.sprite == null)
                {
                    MeleeRadiant2Card = HandRadiant.hand[7];
                    MeleeRadiant2.sprite = HandRadiant.hand[7].Picture;

                }
                else if (EspacioRadiant7.sprite != null && MeleeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[7].Power;
                }
            }
            else if (HandRadiant.hand[7].FileType == "Range")
            {
                if (EspacioRadiant7.sprite != null && RangeRadiant1.sprite == null)
                {
                    RangeRadiant1Card = HandRadiant.hand[7];
                    RangeRadiant1.sprite = HandRadiant.hand[7].Picture;

                }
                else if (EspacioRadiant7.sprite != null && RangeRadiant1.sprite != null && RangeRadiant2.sprite == null)
                {
                    RangeRadiant2Card = HandRadiant.hand[7];
                    RangeRadiant2.sprite = HandRadiant.hand[7].Picture;

                }
                else if (EspacioRadiant7.sprite != null && RangeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[7].Power;
                }
            }
            else if (HandRadiant.hand[7].FileType == "Asedy")
            {

                if (EspacioRadiant7.sprite != null && AsedyRadiant1.sprite == null)
                {
                    AsedyRadiant1Card = HandRadiant.hand[7];
                    AsedyRadiant1.sprite = HandRadiant.hand[7].Picture;
                }
                else if (EspacioRadiant7.sprite != null && AsedyRadiant1.sprite != null && AsedyRadiant2.sprite == null)
                {
                    AsedyRadiant2Card = HandRadiant.hand[7];
                    AsedyRadiant2.sprite = HandRadiant.hand[7].Picture;
                }
                else if (EspacioRadiant7.sprite != null && AsedyRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[7].Power;
                }
            }
            else if (HandRadiant.hand[7].FileType == "Efect")
            {


                if (EspacioRadiant7.sprite != null && CampoRadiant1.sprite == null)
                {
                    CampoRadiant1.sprite = HandRadiant.hand[7].Picture;
                }
                else if ( EspacioRadiant7.sprite != null && CampoRadiant1.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[7].Power;
                }
            }
            else if (HandRadiant.hand[7].FileType == "Lider")
            {
                EspacioliderRadiant.sprite = HandRadiant.hand[7].Picture;
                LiderRadiantCard = HandRadiant.hand[7];
            }
            ShowCountRadiant.text = countPointsRadiant.ToString();
            EspacioRadiant7.sprite = null;
            //HandRadiant.hand[7] = null;
            if (countTurns == 0)
            {
                EspacioRadiant7.sprite = HandRadiant.hand[7].Picture;
            }
        }
    }
    public void invocar8()
    {
        if (countTurns == 0)
        {
            if (EspacioRadiant8.sprite != null)
            {
                countTurns++;
                countTurns2 = 0;
                countPointsRadiant = countPointsRadiant + HandRadiant.hand[8].Power;
            }
            if (HandRadiant.hand[8].FileType == "Melee")
            {
                if (EspacioRadiant8.sprite != null && MeleeRadiant.sprite == null)
                {
                    MeleeRadiantCard = HandRadiant.hand[8];
                    MeleeRadiant.sprite = HandRadiant.hand[8].Picture;

                }
                else if (EspacioRadiant8.sprite != null && MeleeRadiant.sprite != null && MeleeRadiant2.sprite == null)
                {
                    MeleeRadiant2Card = HandRadiant.hand[8];
                    MeleeRadiant2.sprite = HandRadiant.hand[8].Picture;
                }
                else if (EspacioRadiant8.sprite != null && MeleeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[8].Power;
                }
            }
            else if (HandRadiant.hand[8].FileType == "Range")
            {
                if (EspacioRadiant8.sprite != null && RangeRadiant1.sprite == null)
                {
                    RangeRadiant1Card = HandRadiant.hand[8];
                    RangeRadiant1.sprite = HandRadiant.hand[8].Picture;
                }
                else if (EspacioRadiant8.sprite != null && RangeRadiant1.sprite != null && RangeRadiant2.sprite == null)
                {
                    RangeRadiant2Card = HandRadiant.hand[8];
                    RangeRadiant2.sprite = HandRadiant.hand[8].Picture;
                }
                else if (EspacioRadiant8.sprite != null && RangeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[8].Power;
                }
            }
            else if (HandRadiant.hand[8].FileType == "Asedy")
            {

                if (EspacioRadiant8.sprite != null && AsedyRadiant1.sprite == null)
                {
                    AsedyRadiant1Card = HandRadiant.hand[8];
                    AsedyRadiant1.sprite = HandRadiant.hand[8].Picture;
                }
                else if (EspacioRadiant8.sprite != null && AsedyRadiant1.sprite != null && AsedyRadiant2.sprite == null)
                {
                    AsedyRadiant2Card = HandRadiant.hand[8];
                    AsedyRadiant2.sprite = HandRadiant.hand[8].Picture;
                }
                else if (EspacioRadiant8.sprite != null && AsedyRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[8].Power;
                }
            }
            else if (HandRadiant.hand[8].FileType == "Efect")
            {


                if (EspacioRadiant8.sprite != null && CampoRadiant1.sprite == null)
                {
                    CampoRadiant1.sprite = HandRadiant.hand[8].Picture;
                }
                else if (EspacioRadiant8.sprite != null && CampoRadiant1.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[8].Power;
                }
            }
            else if (HandRadiant.hand[8].FileType == "Lider")
            {
                EspacioliderRadiant.sprite = HandRadiant.hand[8].Picture;
                LiderRadiantCard = HandRadiant.hand[8];
            }
            ShowCountRadiant.text = countPointsRadiant.ToString();
            EspacioRadiant8.sprite = null;
            //HandRadiant.hand[8] = null;
            if (countTurns == 0)
            {
                EspacioRadiant8.sprite = HandRadiant.hand[8].Picture;
            }
        }
    }
    public void invocar9()
    {
        if (countTurns == 0)
        {
            if (EspacioRadiant9.sprite != null)
            {
                countTurns++;
                countTurns2 = 0;
                countPointsRadiant = countPointsRadiant + HandRadiant.hand[9].Power;
            }
            if (HandRadiant.hand[9].FileType == "Melee")
            {
                if (EspacioRadiant9.sprite != null && MeleeRadiant.sprite == null)
                {
                    MeleeRadiantCard = HandRadiant.hand[9];
                    MeleeRadiant.sprite = HandRadiant.hand[9].Picture;
                }
                else if (EspacioRadiant9.sprite != null && MeleeRadiant.sprite != null && MeleeRadiant2.sprite == null)
                {
                    MeleeRadiant2Card = HandRadiant.hand[9];
                    MeleeRadiant2.sprite = HandRadiant.hand[9].Picture;
                }
                else if (EspacioRadiant9.sprite != null && MeleeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[9].Power;
                }
            }
            else if (HandRadiant.hand[9].FileType == "Range")
            {
                if (EspacioRadiant9.sprite != null && RangeRadiant1.sprite == null)
                {
                    RangeRadiant1Card = HandRadiant.hand[9];
                    RangeRadiant1.sprite = HandRadiant.hand[9].Picture;
                }
                else if (EspacioRadiant9.sprite != null && RangeRadiant1.sprite != null && RangeRadiant2.sprite == null)
                {
                    RangeRadiant2Card = HandRadiant.hand[9];
                    RangeRadiant2.sprite = HandRadiant.hand[9].Picture;

                }
                else if (EspacioRadiant9.sprite != null && RangeRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[9].Power;
                }
            }
            else if (HandRadiant.hand[9].FileType == "Asedy")
            {

                if (EspacioRadiant9.sprite != null && AsedyRadiant1.sprite == null)
                {
                    AsedyRadiant1Card = HandRadiant.hand[9];
                    AsedyRadiant1.sprite = HandRadiant.hand[9].Picture;
                }
                else if (EspacioRadiant9.sprite != null && AsedyRadiant1.sprite != null && AsedyRadiant2.sprite == null)
                {
                    AsedyRadiant2Card = HandRadiant.hand[9];
                    AsedyRadiant2.sprite = HandRadiant.hand[9].Picture;
                }
                else if (EspacioRadiant9.sprite != null && AsedyRadiant2.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[9].Power;
                }
            }
            else if (HandRadiant.hand[9].FileType == "Efect")
            {


                if (EspacioRadiant9.sprite != null && CampoRadiant1.sprite == null)
                {
                    CampoRadiant1.sprite = HandRadiant.hand[9].Picture;
                }
                else if (EspacioRadiant9.sprite != null && CampoRadiant1.sprite != null)
                {
                    countTurns--;
                    countPointsRadiant = countPointsRadiant - HandRadiant.hand[9].Power;
                }
            }
            else if (HandRadiant.hand[9].FileType == "Lider")
            {
                EspacioliderRadiant.sprite = HandRadiant.hand[9].Picture;
                LiderRadiantCard = HandRadiant.hand[9];
            }
            ShowCountRadiant.text = countPointsRadiant.ToString();
            EspacioRadiant9.sprite = null;
            //HandRadiant.hand[9] = null;
            if (countTurns == 0)
            {
                EspacioRadiant9.sprite = HandRadiant.hand[9].Picture;
            }
        }
    }
    public void invocarDire()
    {
        if (countTurns == 1) {
            if (EspacioDire.sprite != null)
            {
                countTurns--;
                countTurns2 = 0;
                countPointsDire = countPointsDire + HandDire.hand[0].Power;
            }
            if (HandDire.hand[0].FileType == "Melee")
            {
                if (EspacioDire.sprite != null && MeleeDire1.sprite == null)
                {
                    MeleeDire1Card = HandDire.hand[0];
                    MeleeDire1.sprite = HandDire.hand[0].Picture;
                    EspacioDire.sprite = null;
                    HandDire.hand[0] = null;
                }

                else if (EspacioDire.sprite != null && MeleeDire1.sprite != null && MeleeDire2.sprite == null)
                {
                    MeleeDire2Card = HandDire.hand[0];
                    MeleeDire2.sprite = HandDire.hand[0].Picture;
                    HandDire.hand[0] = null;
                    EspacioDire.sprite = null;
                }

                else if (EspacioDire.sprite != null && MeleeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[0].Power;
                }
            }

            else if (HandDire.hand[0].FileType == "Range")
            {
                if (EspacioDire.sprite != null && RangeDire1.sprite == null)
                {
                    RangeDire1Card = HandDire.hand[0];
                    RangeDire1.sprite = HandDire.hand[0].Picture;
                    EspacioDire.sprite = null;
                    HandDire.hand[0] = null;
                }
                else if (EspacioDire.sprite != null && RangeDire1.sprite != null && RangeDire2.sprite == null)
                {
                    RangeDire2Card = HandDire.hand[0];
                    RangeDire2.sprite = HandDire.hand[0].Picture;
                    HandDire.hand[0] = null;
                    EspacioDire.sprite = null;
                }
                else if (EspacioDire.sprite != null && RangeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[0].Power;
                }
            }


            else if (HandDire.hand[0].FileType == "Asedy")
            {

                if (EspacioDire.sprite != null && AsedyDire1.sprite == null)
                {
                    AsedyDire1Card = HandDire.hand[0];
                    AsedyDire1.sprite = HandDire.hand[0].Picture;
                    EspacioDire.sprite = null;
                    HandDire.hand[0] = null;
                }
                else if (EspacioDire.sprite != null && AsedyDire1.sprite != null && AsedyDire2.sprite == null)
                {
                    AsedyDire2Card = HandDire.hand[0];
                    AsedyDire2.sprite = HandDire.hand[0].Picture;
                    HandDire.hand[0] = null;
                    EspacioDire.sprite = null;
                }
                else if (EspacioDire.sprite != null && AsedyDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[0].Power;
                }
            }


            else if (HandDire.hand[0].FileType == "Efect")
            {


                if (EspacioDire.sprite != null && CampoDire1.sprite == null)
                {
                    CampoDire1.sprite = HandDire.hand[0].Picture; 
                    EspacioDire.sprite = null;
                    HandDire.hand[0] = null;
                }
                else if (EspacioDire.sprite != null && CampoDire1.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[0].Power;
                }
            }
            else if (HandDire.hand[0].FileType == "Lider")
            {
                EspacioliderDire.sprite = HandDire.hand[0].Picture;
                LiderDireCard = HandDire.hand[0];
            }
            ShowCountDire.text = countPointsDire.ToString();
            EspacioDire.sprite = null;
            //HandDire.hand[0] = null;
            if (countTurns == 1)
            {
                EspacioDire.sprite = HandDire.hand[0].Picture;
            }
            //OJOOOOOOOOOOOOOOOO
            countTurns = -1;
        }
    }
    public void invocarDire1()
    {
        if (countTurns == 1)
        {

            if (EspacioDire1.sprite != null)
            {
                countTurns--;
                countTurns2 = 0;
                countPointsDire = countPointsDire + HandDire.hand[1].Power;
            }
            if (HandDire.hand[1].FileType == "Melee")
            {
                if (EspacioDire1.sprite != null && MeleeDire1.sprite == null)
                {
                    MeleeDire1Card = HandDire.hand[1];
                    MeleeDire1.sprite = HandDire.hand[1].Picture;
                }


                else if (EspacioDire1.sprite != null && MeleeDire1.sprite != null && MeleeDire2.sprite == null)
                {
                    MeleeDire2Card = HandDire.hand[1];
                    MeleeDire2.sprite = HandDire.hand[1].Picture;
                }



                else if (EspacioDire1.sprite != null && MeleeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[1].Power;
                }
            }



            else if (HandDire.hand[1].FileType == "Range")
            {
                if (EspacioDire1.sprite != null && RangeDire1.sprite == null)
                {
                    RangeDire1Card = HandDire.hand[1];
                    RangeDire1.sprite = HandDire.hand[1].Picture;
                }
                else if (EspacioDire1.sprite != null && RangeDire1.sprite != null && RangeDire2.sprite == null)
                {
                    RangeDire2Card = HandDire.hand[1];
                    RangeDire2.sprite = HandDire.hand[1].Picture;
                }
                else if (EspacioDire1.sprite != null && RangeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[1].Power;
                }
            }


            else if (HandDire.hand[1].FileType == "Asedy")
            {

                if (EspacioDire1.sprite != null && AsedyDire1.sprite == null)
                {
                    AsedyDire1Card = HandDire.hand[1];
                    AsedyDire1.sprite = HandDire.hand[1].Picture;
                }
                else if (EspacioDire1.sprite != null && AsedyDire1.sprite != null && AsedyDire2.sprite == null)
                {
                    AsedyDire2Card = HandDire.hand[1];
                    AsedyDire2.sprite = HandDire.hand[1].Picture;
                }
                else if (EspacioDire1.sprite != null && AsedyDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[1].Power;
                }
            }


            else if (HandDire.hand[1].FileType == "Efect")
            {


                if (EspacioDire1.sprite != null && CampoDire1.sprite == null)
                {
                    CampoDire1.sprite = HandDire.hand[1].Picture;
                }
                else if ( EspacioDire.sprite != null && CampoDire1.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[1].Power;
                }
            }
            else if (HandDire.hand[1].FileType == "Lider")
            {
                EspacioliderDire.sprite = HandDire.hand[1].Picture;
                LiderDireCard = HandDire.hand[1];
            }
            ShowCountDire.text = countPointsDire.ToString();
            EspacioDire1.sprite = null;
            //HandDire.hand[1] = null;
            if (countTurns == 1)
            {
                EspacioDire1.sprite = HandDire.hand[1].Picture;
            }
            countTurns = -1;
        }
    }
    public void invocarDire2()
    {
        if (countTurns == 1)
        {
            if (EspacioDire2.sprite != null)
            {
                countTurns--;
                countTurns2 = 0;
                countPointsDire = countPointsDire + HandDire.hand[2].Power;
            }
            if (HandDire.hand[2].FileType == "Melee")
            {
                if (EspacioDire2.sprite != null && MeleeDire1.sprite == null)
                {
                    MeleeDire1Card = HandDire.hand[2];
                    MeleeDire1.sprite = HandDire.hand[2].Picture;
                }


                else if (EspacioDire2.sprite != null && MeleeDire1.sprite != null && MeleeDire2.sprite == null)
                {
                    MeleeDire2Card = HandDire.hand[1];
                    MeleeDire2.sprite = HandDire.hand[2].Picture;
                }



                else if (EspacioDire2.sprite != null && MeleeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[2].Power;
                }
            }



            else if (HandDire.hand[2].FileType == "Range")
            {
                if (EspacioDire2.sprite != null && RangeDire1.sprite == null)
                {
                    RangeDire1Card = HandDire.hand[2];
                    RangeDire1.sprite = HandDire.hand[2].Picture;
                }
                else if (EspacioDire2.sprite != null && RangeDire1.sprite != null && RangeDire2.sprite == null)
                {
                    RangeDire2Card = HandDire.hand[2];
                    RangeDire2.sprite = HandDire.hand[2].Picture;
                }
                else if (EspacioDire2.sprite != null && RangeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[2].Power;
                }
            }


            else if (HandDire.hand[2].FileType == "Asedy")
            {

                if (EspacioDire2.sprite != null && AsedyDire1.sprite == null)
                {
                    AsedyDire1Card = HandDire.hand[2];
                    AsedyDire1.sprite = HandDire.hand[2].Picture;
                }
                else if (EspacioDire2.sprite != null && AsedyDire1.sprite != null && AsedyDire2.sprite == null)
                {
                    AsedyDire2Card = HandDire.hand[2];
                    AsedyDire2.sprite = HandDire.hand[2].Picture;
                }
                else if (EspacioDire2.sprite != null && AsedyDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[2].Power;
                }
            }


            else if (HandDire.hand[2].FileType == "Efect")
            {


                if (EspacioDire2.sprite != null && CampoDire1.sprite == null)
                {
                    CampoDire1.sprite = HandDire.hand[2].Picture;
                }
                else if (EspacioDire2.sprite != null && CampoDire1.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[2].Power;
                }
            }
            else if (HandDire.hand[2].FileType == "Lider")
            {
                EspacioliderDire.sprite = HandDire.hand[2].Picture;
                LiderDireCard = HandDire.hand[2];
            }
            ShowCountDire.text = countPointsDire.ToString();
            EspacioDire2.sprite = null;
            //HandDire.hand[2] = null;
            if (countTurns == 1)
            {
                EspacioDire2.sprite = HandDire.hand[2].Picture;
            }
            countTurns = -1;
        }
    }
    public void invocarDire3()
    {
        if (countTurns == 1)
        {
            if (EspacioDire3.sprite != null)
            {
                countTurns--;
                countTurns2 = 0;
                countPointsDire = countPointsDire + HandDire.hand[3].Power;
            }
            if (HandDire.hand[3].FileType == "Melee")
            {
                if (EspacioDire3.sprite != null && MeleeDire1.sprite == null)
                {
                    MeleeDire1Card = HandDire.hand[3];
                    MeleeDire1.sprite = HandDire.hand[3].Picture;
                }


                else if (EspacioDire3.sprite != null && MeleeDire1.sprite != null && MeleeDire2.sprite == null)
                {
                    MeleeDire2Card = HandDire.hand[3];
                    MeleeDire2.sprite = HandDire.hand[3].Picture;
                }



                else if (EspacioDire3.sprite != null && MeleeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[3].Power;
                }
            }



            else if (HandDire.hand[3].FileType == "Range")
            {
                if (EspacioDire3.sprite != null && RangeDire1.sprite == null)
                {
                    RangeDire1Card = HandDire.hand[3];
                    RangeDire1.sprite = HandDire.hand[3].Picture;

                }
                else if (EspacioDire3.sprite != null && RangeDire1.sprite != null && RangeDire2.sprite == null)
                {
                    RangeDire2Card = HandDire.hand[3];
                    RangeDire2.sprite = HandDire.hand[3].Picture;
                }
                else if (EspacioDire3.sprite != null && RangeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[3].Power;
                }
            }


            else if (HandDire.hand[3].FileType == "Asedy")
            {

                if (EspacioDire3.sprite != null && AsedyDire1.sprite == null)
                {
                    AsedyDire1Card = HandDire.hand[3];
                    AsedyDire1.sprite = HandDire.hand[3].Picture;
                }
                else if (EspacioDire3.sprite != null && AsedyDire1.sprite != null && AsedyDire2.sprite == null)
                {
                    AsedyDire2Card = HandDire.hand[3];
                    AsedyDire2.sprite = HandDire.hand[3].Picture;
                }
                else if (EspacioDire3.sprite != null && AsedyDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[3].Power;
                }
            }


            else if (HandDire.hand[3].FileType == "Efect")
            {


                if (EspacioDire3.sprite != null && CampoDire1.sprite == null)
                {
                    CampoDire1.sprite = HandDire.hand[3].Picture;
                }
                else if (EspacioDire3.sprite != null && CampoDire1.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[3].Power;
                }
            }
            else if (HandDire.hand[3].FileType == "Lider")
            {
                EspacioliderDire.sprite = HandDire.hand[3].Picture;
                LiderDireCard = HandDire.hand[3];
            }
            ShowCountDire.text = countPointsDire.ToString();
            EspacioDire3.sprite = null;
            //HandDire.hand[3] = null;
            if (countTurns == 1)
            {
                EspacioDire3.sprite = HandDire.hand[3].Picture;
            }
            countTurns = -1;
        }
    }
    public void invocarDire4()
    {
        if (countTurns == 1)
        {
            if (EspacioDire4.sprite != null)
            {
                countTurns--;
                countTurns2 = 0;
                countPointsDire = countPointsDire + HandDire.hand[4].Power;
            }
            if (HandDire.hand[4].FileType == "Melee")
            {
                if (EspacioDire4.sprite != null && MeleeDire1.sprite == null)
                {
                    MeleeDire1Card = HandDire.hand[4];
                    MeleeDire1.sprite = HandDire.hand[4].Picture;
                }


                else if (EspacioDire4.sprite != null && MeleeDire1.sprite != null && MeleeDire2.sprite == null)
                {
                    MeleeDire2Card = HandDire.hand[4];
                    MeleeDire2.sprite = HandDire.hand[4].Picture;
                }



                else if (EspacioDire4.sprite != null && MeleeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[4].Power;
                }
            }



            else if (HandDire.hand[4].FileType == "Range")
            {
                if (EspacioDire4.sprite != null && RangeDire1.sprite == null)
                {
                    RangeDire1Card = HandDire.hand[4];
                    RangeDire1.sprite = HandDire.hand[4].Picture;
                }
                else if (EspacioDire4.sprite != null && RangeDire1.sprite != null && RangeDire2.sprite == null)
                {
                    RangeDire2Card = HandDire.hand[4];
                    RangeDire2.sprite = HandDire.hand[4].Picture;
                }
                else if (EspacioDire4.sprite != null && RangeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[4].Power;
                }
            }


            else if (HandDire.hand[4].FileType == "Asedy")
            {

                if (EspacioDire4.sprite != null && AsedyDire1.sprite == null)
                {
                    AsedyDire1Card = HandDire.hand[4];
                    AsedyDire1.sprite = HandDire.hand[4].Picture;

                }
                else if (EspacioDire4.sprite != null && AsedyDire1.sprite != null && AsedyDire2.sprite == null)
                {
                    AsedyDire2Card = HandDire.hand[4];
                    AsedyDire2.sprite = HandDire.hand[4].Picture;
                }
                else if (EspacioDire4.sprite != null && AsedyDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[4].Power;
                }
            }


            else if (HandDire.hand[4].FileType == "Efect")
            {


                if (EspacioDire4.sprite != null && CampoDire1.sprite == null)
                {
                    CampoDire1.sprite = HandDire.hand[4].Picture;
                }
                else if ( EspacioDire4.sprite != null && CampoDire1.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[4].Power;
                }
            }
            else if (HandDire.hand[4].FileType == "Lider")
            {
                EspacioliderDire.sprite = HandDire.hand[4].Picture;
                LiderDireCard = HandDire.hand[4];
            }
            ShowCountDire.text = countPointsDire.ToString();
            EspacioDire4.sprite = null;
            //HandDire.hand[4] = null;
            if (countTurns == 1)
            {
                EspacioDire4.sprite = HandDire.hand[4].Picture;
            }
            countTurns = -1;
        }
    }
    public void invocarDire5()
    {
        if (countTurns == 1)
        {
            if (EspacioDire5.sprite != null)
            {
                countTurns--;
                countTurns2 = 0;
                countPointsDire = countPointsDire + HandDire.hand[5].Power;
            }
            if (HandDire.hand[5].FileType == "Melee")
            {
                if (EspacioDire5.sprite != null && MeleeDire1.sprite == null)
                {
                    MeleeDire1Card = HandDire.hand[5];
                    MeleeDire1.sprite = HandDire.hand[5].Picture;
                }


                else if (EspacioDire5.sprite != null && MeleeDire1.sprite != null && MeleeDire2.sprite == null)
                {
                    MeleeDire2Card = HandDire.hand[5];
                    MeleeDire2.sprite = HandDire.hand[5].Picture;
                }



                else if (EspacioDire5.sprite != null && MeleeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[5].Power;
                }
            }



            else if (HandDire.hand[5].FileType == "Range")
            {
                if (EspacioDire5.sprite != null && RangeDire1.sprite == null)
                {
                    RangeDire1Card = HandDire.hand[5];
                    RangeDire1.sprite = HandDire.hand[5].Picture;
                }
                else if (EspacioDire5.sprite != null && RangeDire1.sprite != null && RangeDire2.sprite == null)
                {
                    RangeDire2Card = HandDire.hand[5];
                    RangeDire2.sprite = HandDire.hand[5].Picture;
                }
                else if (EspacioDire5.sprite != null && RangeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[5].Power;
                }
            }


            else if (HandDire.hand[5].FileType == "Asedy")
            {

                if (EspacioDire5.sprite != null && AsedyDire1.sprite == null)
                {
                    AsedyDire1Card = HandDire.hand[5];
                    AsedyDire1.sprite = HandDire.hand[5].Picture;
                }
                else if (EspacioDire5.sprite != null && AsedyDire1.sprite != null && AsedyDire2.sprite == null)
                {
                    AsedyDire2Card = HandDire.hand[5];
                    AsedyDire2.sprite = HandDire.hand[5].Picture;
                }
                else if (EspacioDire5.sprite != null && AsedyDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[5].Power;
                }
            }


            else if (HandDire.hand[5].FileType == "Efect")
            {


                if (EspacioDire5.sprite != null && CampoDire1.sprite == null)
                {
                    CampoDire1.sprite = HandDire.hand[5].Picture;
                }
                else if (EspacioDire5.sprite != null && CampoDire1.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[5].Power;
                }
            }
            else if (HandDire.hand[5].FileType == "Lider")
            {
                EspacioliderDire.sprite = HandDire.hand[5].Picture;
                LiderDireCard = HandDire.hand[5];
            }
            ShowCountDire.text = countPointsDire.ToString();
            EspacioDire5.sprite = null;
            //HandDire.hand[5] = null;
            if (countTurns == 1)
            {
                EspacioDire5.sprite = HandDire.hand[5].Picture;
            }
            countTurns = -1;
        }
    }
    public void invocarDire6()
    {

        if (countTurns == 1)
        {
            if (EspacioDire6.sprite != null)
            {
                countTurns--;
                countTurns2 = 0;
                countPointsDire = countPointsDire + HandDire.hand[6].Power;
            }
            if (HandDire.hand[6].FileType == "Melee")
            {
                if (EspacioDire6.sprite != null && MeleeDire1.sprite == null)
                {
                    MeleeDire1Card = HandDire.hand[6];
                    MeleeDire1.sprite = HandDire.hand[6].Picture;
                }


                else if (EspacioDire6.sprite != null && MeleeDire1.sprite != null && MeleeDire2.sprite == null)
                {
                    MeleeDire2Card = HandDire.hand[6];
                    MeleeDire2.sprite = HandDire.hand[6].Picture;
                }



                else if (EspacioDire6.sprite != null && MeleeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[6].Power;
                }
            }



            else if (HandDire.hand[6].FileType == "Range")
            {
                if (EspacioDire6.sprite != null && RangeDire1.sprite == null)
                {
                    RangeDire1Card = HandDire.hand[6];
                    RangeDire1.sprite = HandDire.hand[6].Picture;
                }
                else if (EspacioDire6.sprite != null && RangeDire1.sprite != null && RangeDire2.sprite == null)
                {
                    RangeDire2Card = HandDire.hand[6];
                    RangeDire2.sprite = HandDire.hand[6].Picture;
                }
                else if (EspacioDire6.sprite != null && RangeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[6].Power;
                }
            }


            else if (HandDire.hand[6].FileType == "Asedy")
            {

                if (EspacioDire6.sprite != null && AsedyDire1.sprite == null)
                {
                    AsedyDire1Card = HandDire.hand[6];
                    AsedyDire1.sprite = HandDire.hand[6].Picture;
                }
                else if (EspacioDire6.sprite != null && AsedyDire1.sprite != null && AsedyDire2.sprite == null)
                {
                    AsedyDire2Card = HandDire.hand[6];
                    AsedyDire2.sprite = HandDire.hand[6].Picture;
                }
                else if (EspacioDire6.sprite != null && AsedyDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[6].Power;
                }
            }


            else if (HandDire.hand[6].FileType == "Efect")
            {


                if (EspacioDire6.sprite != null && CampoDire1.sprite == null)
                {
                    CampoDire1.sprite = HandDire.hand[6].Picture;
                }
                else if (EspacioDire6.sprite != null && CampoDire1.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[6].Power;
                }
            }
            else if (HandDire.hand[6].FileType == "Lider")
            {
                EspacioliderDire.sprite = HandDire.hand[6].Picture;
                LiderDireCard = HandDire.hand[6];
            }
            ShowCountDire.text = countPointsDire.ToString();
            EspacioDire6.sprite = null;
            //HandDire.hand[6] = null;
            if (countTurns == 1)
            {
                EspacioDire6.sprite = HandDire.hand[6].Picture;
            }
            countTurns = -1;
        }
    }
    public void invocarDire7()
    {
        if (countTurns == 1)
        {
            if (EspacioDire7.sprite != null)
            {
                countTurns--;
                countTurns2 = 0;
                countPointsDire = countPointsDire + HandDire.hand[7].Power;
            }
            if (HandDire.hand[7].FileType == "Melee")
            {
                if (EspacioDire7.sprite != null && MeleeDire1.sprite == null)
                {
                    MeleeDire1Card = HandDire.hand[7];
                    MeleeDire1.sprite = HandDire.hand[7].Picture;
                }


                else if (EspacioDire7.sprite != null && MeleeDire1.sprite != null && MeleeDire2.sprite == null)
                {
                    MeleeDire2Card = HandDire.hand[7];
                    MeleeDire2.sprite = HandDire.hand[7].Picture;
                }



                else if (EspacioDire7.sprite != null && MeleeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[7].Power;
                }
            }



            else if (HandDire.hand[7].FileType == "Range")
            {
                if (EspacioDire7.sprite != null && RangeDire1.sprite == null)
                {
                    RangeDire1Card = HandDire.hand[7];
                    RangeDire1.sprite = HandDire.hand[7].Picture;
                }
                else if (EspacioDire7.sprite != null && RangeDire1.sprite != null && RangeDire2.sprite == null)
                {
                    RangeDire2Card = HandDire.hand[7];
                    RangeDire2.sprite = HandDire.hand[7].Picture;
                }
                else if (EspacioDire7.sprite != null && RangeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[7].Power;
                }
            }


            else if (HandDire.hand[7].FileType == "Asedy")
            {

                if (EspacioDire7.sprite != null && AsedyDire1.sprite == null)
                {
                    AsedyDire1Card = HandDire.hand[7];
                    AsedyDire1.sprite = HandDire.hand[7].Picture;

                }
                else if (EspacioDire7.sprite != null && AsedyDire1.sprite != null && AsedyDire2.sprite == null)
                {
                    AsedyDire2Card = HandDire.hand[7];
                    AsedyDire2.sprite = HandDire.hand[7].Picture;
                }
                else if (EspacioDire7.sprite != null && AsedyDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[7].Power;
                }
            }


            else if (HandDire.hand[7].FileType == "Efect")
            {


                if (EspacioDire7.sprite != null && CampoDire1.sprite == null)
                {
                    CampoDire1.sprite = HandDire.hand[7].Picture;
                }
                else if (EspacioDire7.sprite != null && CampoDire1.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[7].Power;
                }
            }
            else if (HandDire.hand[7].FileType == "Lider")
            {
                EspacioliderDire.sprite = HandDire.hand[7].Picture;
                LiderDireCard = HandDire.hand[7];
            }
            ShowCountDire.text = countPointsDire.ToString();
            EspacioDire7.sprite = null;
            //HandDire.hand[7] = null;
            if (countTurns == 1)
            {
                EspacioDire7.sprite = HandDire.hand[7].Picture;
            }
            countTurns = -1;
        }
    }
    public void invocarDire8()
    {
        if (countTurns == 1)
        {
            if (EspacioDire8.sprite != null)
            {
                countTurns--;
                countTurns2 = 0;
                countPointsDire = countPointsDire + HandDire.hand[8].Power;
            }
            if (HandDire.hand[8].FileType == "Melee")
            {
                if (EspacioDire8.sprite != null && MeleeDire1.sprite == null)
                {
                    MeleeDire1Card = HandDire.hand[8];
                    MeleeDire1.sprite = HandDire.hand[8].Picture;
                }


                else if (EspacioDire8.sprite != null && MeleeDire1.sprite != null && MeleeDire2.sprite == null)
                {
                    MeleeDire2Card = HandDire.hand[8];
                    MeleeDire2.sprite = HandDire.hand[8].Picture;
                }



                else if (EspacioDire8.sprite != null && MeleeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[8].Power;
                }
            }



            else if (HandDire.hand[8].FileType == "Range")
            {
                if (EspacioDire8.sprite != null && RangeDire1.sprite == null)
                {
                    RangeDire1Card = HandDire.hand[8];
                    RangeDire1.sprite = HandDire.hand[8].Picture;
                }
                else if (EspacioDire8.sprite != null && RangeDire1.sprite != null && RangeDire2.sprite == null)
                {
                    RangeDire2Card = HandDire.hand[8];
                    RangeDire2.sprite = HandDire.hand[8].Picture;
                }
                else if (EspacioDire8.sprite != null && RangeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[8].Power;
                }
            }


            else if (HandDire.hand[8].FileType == "Asedy")
            {

                if (EspacioDire8.sprite != null && AsedyDire1.sprite == null)
                {
                    AsedyDire1Card = HandDire.hand[8];
                    AsedyDire1.sprite = HandDire.hand[8].Picture;
                }
                else if (EspacioDire8.sprite != null && AsedyDire1.sprite != null && AsedyDire2.sprite == null)
                {
                    AsedyDire2Card = HandDire.hand[8];
                    AsedyDire2.sprite = HandDire.hand[8].Picture;
                }
                else if (EspacioDire8.sprite != null && AsedyDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[8].Power;
                }
            }


            else if (HandDire.hand[8].FileType == "Efect")
            {


                if (EspacioDire8.sprite != null && CampoDire1.sprite == null)
                {
                    CampoDire1.sprite = HandDire.hand[8].Picture;
                }
                else if ( EspacioDire8.sprite != null && CampoDire1.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[8].Power;
                }
            }
            else if (HandDire.hand[8].FileType == "Lider")
            {
                EspacioliderDire.sprite = HandDire.hand[8].Picture;
                LiderDireCard = HandDire.hand[8];
            }
            ShowCountDire.text = countPointsDire.ToString();
            EspacioDire8.sprite = null;
            //HandDire.hand[8] = null;
            if (countTurns == 1)
            {
                EspacioDire8.sprite = HandDire.hand[8].Picture;
            }
            countTurns = -1;
        }
    }
    public void invocarDire9()
    {
        if (countTurns == 1)
        {
            if (EspacioDire9.sprite != null)
            {
                countTurns--;
                countTurns2 = 0;
                countPointsDire = countPointsDire + HandDire.hand[9].Power;
            }
            if (HandDire.hand[9].FileType == "Melee")
            {
                if (EspacioDire9.sprite != null && MeleeDire1.sprite == null)
                {
                    MeleeDire1Card = HandDire.hand[9];
                    MeleeDire1.sprite = HandDire.hand[9].Picture;
                }


                else if (EspacioDire9.sprite != null && MeleeDire1.sprite != null && MeleeDire2.sprite == null)
                {
                    MeleeDire2Card = HandDire.hand[9];
                    MeleeDire2.sprite = HandDire.hand[9].Picture;
                }



                else if (EspacioDire9.sprite != null && MeleeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[9].Power;
                }
            }



            else if (HandDire.hand[9].FileType == "Range")
            {
                if (EspacioDire9.sprite != null && RangeDire1.sprite == null)
                {
                    RangeDire1Card = HandDire.hand[9];
                    RangeDire1.sprite = HandDire.hand[9].Picture;

                }
                else if (EspacioDire9.sprite != null && RangeDire1.sprite != null && RangeDire2.sprite == null)
                {
                    RangeDire2Card = HandDire.hand[9];
                    RangeDire2.sprite = HandDire.hand[9].Picture;

                }
                else if (EspacioDire9.sprite != null && RangeDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[9].Power;
                }
            }


            else if (HandDire.hand[9].FileType == "Asedy")
            {

                if (EspacioDire9.sprite != null && AsedyDire1.sprite == null)
                {
                    AsedyDire1Card = HandDire.hand[9];
                    AsedyDire1.sprite = HandDire.hand[9].Picture;
                }
                else if (EspacioDire9.sprite != null && AsedyDire1.sprite != null && AsedyDire2.sprite == null)
                {
                    AsedyDire2Card = HandDire.hand[9];
                    AsedyDire2.sprite = HandDire.hand[9].Picture;
                }
                else if (EspacioDire9.sprite != null && AsedyDire2.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[9].Power;
                }
            }


            else if (HandDire.hand[9].FileType == "Efect")
            {


                if (EspacioDire9.sprite != null && CampoDire1.sprite == null)
                {
                    CampoDire1.sprite = HandDire.hand[9].Picture;
                }
                else if ( EspacioDire9.sprite != null && CampoDire1.sprite != null)
                {
                    countTurns++;
                    countPointsDire = countPointsDire - HandDire.hand[9].Power;
                }
            }
            else if (HandDire.hand[9].FileType == "Lider")
            {
                EspacioliderDire.sprite = HandDire.hand[9].Picture;
                LiderDireCard = HandDire.hand[9];
            }
            ShowCountDire.text = countPointsDire.ToString();
            EspacioDire9.sprite = null;
            //HandDire.hand[9] = null;
            if (countTurns == 1)
            {
                EspacioDire9.sprite = HandDire.hand[9].Picture;
            }
            countTurns = -1;
        }
    }
    //efectos de objetos
    public void ActivarEfectoRadiant()
    {
        if (countTurns == 1) {
            if (CampoRadiant1.sprite != null)
            {
                if (CampoRadiant1.sprite.name == "Falcon Blade")
                {
                    //toma un numero del 0 al 2 ,si es 0 se sube el poder segun la cantidad de cartas melee que no hallan vacia (3 por cada carta),en rango con 1 y en asedio con 2,el numero es aleatorio
                    int random = UnityEngine.Random.Range(0, 3);
                    if (random == 0)
                    {
                        if (MeleeRadiant.sprite != null)
                        {
                            countPointsRadiant += 3;
                            if (MeleeRadiant2.sprite != null)
                            {
                                countPointsRadiant += 3;
                            }
                        }
                    }
                    else if (random == 1)
                    {
                        if (RangeRadiant1.sprite != null)
                        {
                            countPointsRadiant += 3;
                            if (RangeRadiant2.sprite != null)
                            {
                                countPointsRadiant += 3;
                            }
                        }
                    }
                    else if (random == 3)
                    {
                        if (AsedyRadiant1.sprite != null)
                        {
                            countPointsRadiant += 3;
                            if (AsedyRadiant2.sprite != null) 
                            {
                                countPointsRadiant += 3;
                            }
                        }
                    }
                }

                if (CampoRadiant1.sprite.name == "Dominator Helm")
                {
                    //hace lo mismo que lo anterior pero en el campo rival 
                    int random2 = UnityEngine.Random.Range(0, 3);
                    if (random2 == 0)
                    {
                        if (MeleeDire1.sprite != null)
                        {
                            countPointsDire -= 3;
                            if (MeleeDire2.sprite != null)
                            {
                                countPointsDire -= 3;
                            }
                        }
                    }
                    else if (random2 == 1)
                    {
                        if (RangeDire1.sprite != null)
                        {
                            countPointsDire -= 3;
                            if (RangeDire2.sprite != null)
                            {
                                countPointsDire -= 3;
                            }
                        }
                    }
                    else if (random2 == 3)
                    {
                        if (AsedyDire1.sprite != null)
                        {
                            countPointsDire -= 3;
                            if (AsedyDire2.sprite != null)
                            {
                                countPointsDire -= 3;
                            }
                        }
                    }
                }
                
                if (CampoRadiant1.sprite.name == "Octarine")
                {
            //hace lo mismo que lo anterior pero esta vez en vez de reducir elimina los objetos
                int random3 = UnityEngine.Random.Range(0, 3);
                    if (CampoRadiant1.sprite  != null) {
                        if (random3 == 0)
                        {
                            countPointsDire -= MeleeDire1Card.Power;
                            countPointsDire -= MeleeDire2Card.Power;
                            MeleeDire1.sprite = null;
                            MeleeDire2.sprite = null;
                            MeleeDire1Card = null;
                            MeleeDire2Card = null;
                        }
                        else if (random3 == 1)
                        {
                            countPointsDire -= RangeDire1Card.Power;
                            countPointsDire -= RangeDire2Card.Power;
                            RangeDire1.sprite = null;
                            RangeDire2.sprite = null;
                            RangeDire1Card = null;
                            RangeDire2Card = null;

                        }
                        else if (random3 == 2) {
                            countPointsDire -= AsedyDire1Card.Power;
                            countPointsDire -= AsedyDire2Card.Power;
                            AsedyDire1.sprite = null;
                            AsedyDire2.sprite = null;
                            AsedyDire1Card = null;
                            AsedyDire2Card = null;

                        }
                    }
                }
            }
            ShowCountRadiant.text = countPointsRadiant.ToString();
            ShowCountDire.text = countPointsDire.ToString();
        }
        CampoRadiant1.sprite = null;
    }
    public void ActivarEfectoDire()
    {
        if (countTurns == 0) {
            if (CampoDire1.sprite != null)
                {
            
                if (CampoDire1.sprite.name == "Desolator")
            {
                 int random = UnityEngine.Random.Range(0, 3);
                 if (random == 0)
                 {
                     if (MeleeDire1.sprite != null)
                     {
                         countPointsDire += 3;
                         if (MeleeDire2.sprite != null)
                         {
                             countPointsDire += 3;
                         }
                     }
                 }
                 else if (random == 1)
                 {
                     if (RangeDire1.sprite != null)
                     {
                         countPointsDire += 3;
                         if (RangeDire2.sprite != null)
                         {
                             countPointsDire += 3;
                         }
                     }
                 }
                 else if (random == 3)
                 {
                     if (AsedyDire1.sprite != null)
                     {
                         countPointsDire += 3;
                         if (AsedyDire2.sprite != null)
                         {
                             countPointsDire += 3;
                         }
                     }
                 }
            }
                if (CampoDire1.sprite.name == "Gleipir")
                    {
                        int random2 = UnityEngine.Random.Range(0, 3);
                        if (random2 == 0)
                        {
                            if (MeleeRadiant.sprite != null)
                            {
                                countPointsRadiant -= 3;
                                if (MeleeRadiant2.sprite != null)
                                {
                                    countPointsDire -= 3;
                                }
                            }
                        }
                        else if (random2 == 1)
                        {
                            if (RangeRadiant1.sprite != null)
                            {
                                countPointsRadiant -= 3;
                                if (RangeRadiant2.sprite != null)
                                {
                                    countPointsRadiant -= 3;
                                }
                            }
                        }
                        else if (random2 == 3)
                        {
                            if (AsedyRadiant1.sprite != null)
                            {
                                countPointsRadiant -= 3;
                                if (AsedyRadiant2.sprite != null)
                                {
                                    countPointsRadiant -= 3;
                                }
                            }
                        }
                    }
                if (CampoDire1.sprite.name == "Mask of Madness")
                {
                    int random3 = UnityEngine.Random.Range(0, 2);
                    if (CampoDire1.sprite != null)
                    {
                        if (random3 == 0)
                        {
                            countPointsRadiant -= MeleeRadiantCard.Power;
                            countPointsRadiant -= MeleeRadiant2Card.Power;
                            MeleeRadiant.sprite = null;
                            MeleeRadiant2.sprite = null;
                        }
                        else if (random3 == 1)
                        {
                            countPointsRadiant -= RangeRadiant1Card.Power;
                            countPointsRadiant -= RangeRadiant2Card.Power;
                            RangeRadiant1.sprite = null;
                            RangeRadiant2.sprite = null;
                        }
                        else if (random3 == 2)
                        {
                            countPointsRadiant -= AsedyRadiant1Card.Power;
                            countPointsRadiant -= AsedyRadiant2Card.Power;
                            AsedyRadiant1.sprite = null;
                            AsedyRadiant2.sprite = null;
                        }
                    }
                }
            ShowCountRadiant.text = countPointsRadiant.ToString();
            ShowCountDire.text = countPointsDire.ToString();
            }
            CampoDire1.sprite = null;
        }
    }

    //efectos de zonas 
    public void PoderZonaMelee1Radiant()
    {
        if (countTurns == 0)
        {
            if (MeleeRadiant.sprite != null)
            {
                if (MeleeRadiantCard.CardName == "Jugernaut")
                {
                    //golpe critico ...sube su poder n veces siendo n un numero aleatorio del 0 al 3
                    int random = UnityEngine.Random.Range(1, 2);
                    countPointsRadiant += MeleeRadiantCard.Power + random * random;
                    ShowCountRadiant.text = countPointsRadiant.ToString();
                    random = 1;
                }
                else if (MeleeRadiantCard.CardName == "Dragon Knight")
                {
                    //elimina una carta de asedio al convertirse en dragon
                    if (AsedyDire1.sprite != null)
                    {
                        AsedyDire1.sprite = null;
                    }
                    else if (AsedyDire1.sprite == null && AsedyDire2.sprite != null)
                    {
                        AsedyDire2.sprite = null;
                    }
                }
                else if (MeleeRadiantCard.CardName == "Abaddon")
                {
                    //pone un campo o sustituye el actual por otro
                    CampoRadiant1.sprite = Falcon_Blade.Picture;
                }
                countTurns++;
            }
        }
    }
    public void PoderZonaMelee2Radiant()
    {
        if (countTurns == 0) {
            if (MeleeRadiant2.sprite != null)
            {
                if (MeleeRadiant2Card.CardName == "Jugernaut")
                {
                    //golpe critico ...sube su poder n veces siendo n un numero aleatorio del 0 al 3
                    int random = UnityEngine.Random.Range(1, 2);
                    countPointsDire += MeleeRadiant2Card.Power + random * random;
                    ShowCountRadiant.text = countPointsRadiant.ToString();
                    random = 1;
                }
                else if (MeleeRadiant2Card.CardName == "Dragon Knight")
                {
                    //elimina una carta de asedio al convertirse en dragon
                    if (AsedyDire1.sprite != null)
                    {
                        AsedyDire1.sprite = null;
                    }
                    else if (AsedyDire1.sprite == null && AsedyDire2.sprite != null)
                    {
                        AsedyDire2.sprite = null;
                    }
                }
                else if (MeleeRadiant2Card.CardName == "Abaddon")
                {
                    //pone un campo o sustituye el actual por otro
                    CampoRadiant1.sprite = Falcon_Blade.Picture;
                }
            }
            countTurns++;
        }
    }
    public void PoderZonaRangeRadiant()
    {
        //elimina la carta con menos poder
        if (countTurns == 0) {
            if (RangeRadiant1.sprite != null)
            {
                if (RangeRadiant1Card.CardName == "Lina")
                {
                    if (RangeDire1.sprite != null)
                    {
                        if (RangeDire2.sprite != null)
                        {
                            if (RangeDire1Card.Power < RangeDire2Card.Power)
                            {
                                countPointsDire -= RangeDire1Card.Power;
                                RangeDire1.sprite = null;
                                ShowCountDire.text = countPointsDire.ToString();
                            }
                            else
                            {
                                countPointsDire -= RangeDire2Card.Power;
                                RangeDire2.sprite = null;
                                ShowCountDire.text = countPointsDire.ToString();
                            }
                        }
                    }
                }
                else if (RangeRadiant1Card.CardName == "Phoenix")
                {
                    EspacioRadiant.sprite = DeckRadiant.deck[0].Picture;
                    HandRadiant.hand[0] = DeckRadiant.deck[0];
                }
                countTurns++;
            }
        }
    }
    public void PoderZonaRange2Radiant()
    {
        if (countTurns == 0)
        {
            if (RangeRadiant2.sprite != null)
            {
                if (RangeRadiant2Card.CardName == "Lina")
                {
                    if (RangeDire1.sprite != null)
                    {
                        if (RangeDire2.sprite != null)
                        {
                            if (RangeDire1Card.Power < RangeDire2Card.Power)
                            {
                                countPointsDire -= RangeDire1Card.Power;
                                RangeDire1.sprite = null;
                                ShowCountDire.text = countPointsDire.ToString();
                            }
                            else
                            {
                                countPointsDire -= RangeDire2Card.Power;
                                RangeDire2.sprite = null;
                                ShowCountDire.text = countPointsDire.ToString();
                            }
                        }
                    }
                }
                else if (RangeRadiant2Card.CardName == "Phoenix")
                {
                    EspacioRadiant.sprite = DeckRadiant.deck[0].Picture;
                    HandRadiant.hand[0] = DeckRadiant.deck[0];
                }
                countTurns++;
            }
        }
    }
    public void PoderZonaAsedy1Radiant()
    {
        //eliminar la carta con mas poder de la zona melee
        if (AsedyRadiant1.sprite != null)
        {
            if (countTurns == 0) 
            {
                if (AsedyRadiant1Card.CardName == "Earthshaker")
                {
                    if (MeleeDire1.sprite != null)
                    {
                        if (MeleeDire2.sprite != null)
                        {
                            if (MeleeDire1Card.Power > MeleeDire2Card.Power)
                            {
                                countPointsDire -= MeleeDire1Card.Power;
                                MeleeDire1.sprite = null;
                                ShowCountDire.text = countPointsDire.ToString();

                            }
                            else
                            {
                                countPointsDire -= MeleeDire2Card.Power;
                                MeleeDire2.sprite = null;
                                ShowCountDire.text = countPointsDire.ToString();
                            }
                        }
                    }
                }
                //envia una carta aleatoria del campo rango dire a una zona rango del campo randiant
                else if (AsedyRadiant1Card.CardName == "Tiny")
                {
                    if (RangeDire1.sprite != null)
                    {
                        if (RangeDire2.sprite != null)
                        {
                            if (RangeDire1Card.Power > RangeDire2Card.Power)
                            {
                                countPointsDire -= RangeDire1Card.Power;
                                ShowCountDire.text = countPointsDire.ToString();
                                if (RangeRadiant1.sprite == null)
                                {
                                    RangeRadiant1.sprite = RangeDire1.sprite;
                                    RangeDire1.sprite = null;
                                }
                                else if (RangeRadiant1.sprite != null && RangeRadiant2.sprite == null)
                                {
                                    RangeRadiant2.sprite = RangeDire1.sprite;
                                    RangeDire1.sprite = null;
                                }
                            }
                            else
                            {
                                countPointsDire -= RangeDire2Card.Power;
                                RangeDire2.sprite = null;
                                ShowCountDire.text = countPointsDire.ToString();
                                if (RangeRadiant1.sprite == null)
                                {
                                    RangeRadiant1.sprite = RangeDire2.sprite;
                                    RangeDire2.sprite = null;
                                }
                                else if (RangeRadiant1.sprite != null && RangeRadiant2.sprite == null)
                                {
                                    RangeRadiant2.sprite = RangeDire2.sprite;
                                    RangeDire2.sprite = null;
                                }
                            }
                        }
                    }
                }
                countTurns++;
            }

        }
    }
    public void PoderZonaAsedy2Radiant()
    {
        if (AsedyRadiant2.sprite != null)
        {
            if (countTurns == 0)
            {
                if (AsedyRadiant2Card.CardName == "Earthshaker")
                {
                    if (MeleeDire1.sprite != null)
                    {
                        if (MeleeDire2.sprite != null)
                        {
                            if (MeleeDire1Card.Power > MeleeDire2Card.Power)
                            {
                                countPointsDire -= MeleeDire1Card.Power;
                                MeleeDire1.sprite = null;
                                ShowCountDire.text = countPointsDire.ToString();

                            }
                            else
                            {
                                countPointsDire -= MeleeDire2Card.Power;
                                MeleeDire2.sprite = null;
                                ShowCountDire.text = countPointsDire.ToString();
                            }
                        }
                    }
                }
                //envia una carta aleatoria del campo rango dire a una zona rango del campo randiant
                else if (AsedyRadiant2Card.CardName == "Tiny")
                {
                    if (RangeDire1.sprite != null)
                    {
                        if (RangeDire2.sprite != null)
                        {
                            if (RangeDire1Card.Power > RangeDire2Card.Power)
                            {
                                countPointsDire -= RangeDire1Card.Power;
                                ShowCountDire.text = countPointsDire.ToString();
                                if (RangeRadiant1.sprite == null)
                                {
                                    RangeRadiant1.sprite = RangeDire1.sprite;
                                    RangeDire1.sprite = null;
                                }
                                else if (RangeRadiant1.sprite != null && RangeRadiant2.sprite == null)
                                {
                                    RangeRadiant2.sprite = RangeDire1.sprite;
                                    RangeDire1.sprite = null;
                                }
                            }
                            else
                            {
                                countPointsDire -= RangeDire2Card.Power;
                                RangeDire2.sprite = null;
                                ShowCountDire.text = countPointsDire.ToString();
                                if (RangeRadiant1.sprite == null)
                                {
                                    RangeRadiant1.sprite = RangeDire2.sprite;
                                    RangeDire2.sprite = null;
                                }
                                else if (RangeRadiant1.sprite != null && RangeRadiant2.sprite == null)
                                {
                                    RangeRadiant2.sprite = RangeDire2.sprite;
                                    RangeDire2.sprite = null;
                                }
                            }
                        }
                    }
                }
                countTurns++;
            }

        }

    }

    public void PoderLiderRadiant()
    {
        //cataclismo ...elimina todas las cartas en el campo y quita la mitad de los puntos de poder del adversario
    }

    public void PoderZonaMelee1Dire()
    {
        if (countTurns == 0)
        {
            if (MeleeDire1.sprite != null)
            {
                if (MeleeDire1Card.CardName == "Phantom Assassin")
                {
                    //golpe critico ...sube su poder n veces siendo n un numero aleatorio del 0 al 3
                    int random = UnityEngine.Random.Range(1, 2);
                    countPointsDire += MeleeDire1Card.Power + random * random;
                    ShowCountDire.text = countPointsDire.ToString();
                    random = 1;
                }
                else if (MeleeDire1Card.CardName == "Centaure Waruner")
                {
                    //elimina una carta de asedio
                    if (AsedyRadiant1.sprite != null)
                    {
                        AsedyRadiant1.sprite = null;
                    }
                    else if (AsedyRadiant1.sprite == null && AsedyRadiant2.sprite != null)
                    {
                        AsedyRadiant2.sprite = null;
                    }
                }
                else if (MeleeDire1Card.CardName == "Sven")
                {
                    //pone un campo o sustituye el actual por otro
                    CampoDire1.sprite = Desolator.Picture;
                }
                countTurns++;
            }
        }
    }
    public void PoderZonaMelee2Dire()
    {
        if (countTurns == 0)
        {
            if (MeleeDire2.sprite != null)
            {
                if (MeleeDire2Card.CardName == "Phantom Assassin")
                {
                    //golpe critico ...sube su poder n veces siendo n un numero aleatorio del 0 al 3
                    int random = UnityEngine.Random.Range(1, 2);
                    countPointsDire += MeleeDire2Card.Power + random * random;
                    ShowCountDire.text = countPointsDire.ToString();
                    random = 1;
                }
                else if (MeleeDire2Card.CardName == "Centaure Waruner")
                {
                    //elimina una carta de asedio
                    if (AsedyRadiant1.sprite != null)
                    {
                        AsedyRadiant1.sprite = null;
                    }
                    else if (AsedyRadiant1.sprite == null && AsedyRadiant2.sprite != null)
                    {
                        AsedyRadiant2.sprite = null;
                    }
                }
                else if (MeleeDire2Card.CardName == "Sven")
                {
                    //pone un campo o sustituye el actual por otro
                    CampoDire1.sprite = Desolator.Picture;
                }
                countTurns++;
            }
        }
    }
    public void PoderZonaRange1Dire()
    {
        //elimina la carta con menos poder
        if (countTurns == 0)
        {
            if (RangeDire1.sprite != null)
            {
                if (RangeDire1Card.CardName == "Weaver")
                {
                    if (RangeRadiant1.sprite != null)
                    {
                        if (RangeRadiant2.sprite != null)
                        {
                            if (RangeRadiant1Card.Power < RangeRadiant2Card.Power)
                            {
                                countPointsRadiant -= RangeRadiant1Card.Power;
                                RangeRadiant1.sprite = null;
                                ShowCountDire.text = countPointsDire.ToString();
                            }
                            else
                            {
                                countPointsRadiant -= RangeRadiant2Card.Power;
                                RangeRadiant2.sprite = null;
                                ShowCountDire.text = countPointsDire.ToString();
                            }
                        }
                    }
                }
                else if (RangeDire1Card.CardName == "Shadow Field")
                {
                    EspacioDire9.sprite = DeckDire.deck[0].Picture;
                    HandDire.hand[9] = DeckDire.deck[0];
                }
                countTurns++;
            }
        }
    }
    public void PoderZonaRange2Dire()
    {
        //elimina la carta con menos poder
        if (countTurns == 0)
        {
            if (RangeDire2.sprite != null)
            {
                if (RangeDire2Card.CardName == "Weaver")
                {
                    if (RangeRadiant1.sprite != null)
                    {
                        if (RangeRadiant2.sprite != null)
                        {
                            if (RangeRadiant1Card.Power < RangeRadiant2Card.Power)
                            {
                                countPointsRadiant -= RangeRadiant1Card.Power;
                                RangeRadiant1.sprite = null;
                                ShowCountDire.text = countPointsDire.ToString();
                            }
                            else
                            {
                                countPointsRadiant -= RangeRadiant2Card.Power;
                                RangeRadiant2.sprite = null;
                                ShowCountDire.text = countPointsDire.ToString();
                            }
                        }
                    }
                }
                else if (RangeDire2Card.CardName == "Shadow Field")
                {
                    EspacioDire9.sprite = DeckDire.deck[0].Picture;
                    HandDire.hand[9] = DeckDire.deck[0];
                }
                countTurns++;
            }
        }
    }
    public void PoderZonaAsedy1Dire()
    {
        //eliminar la carta con mas poder de la zona melee
        if (AsedyDire1.sprite != null)
        {
            if (countTurns == 0)
            {
                if (AsedyDire1Card.CardName == "Razor")
                {
                    if (MeleeRadiant.sprite != null)
                    {
                        if (MeleeRadiant2.sprite != null)
                        {
                            if (MeleeRadiantCard.Power > MeleeRadiant2Card.Power)
                            {
                                countPointsRadiant -= MeleeRadiantCard.Power;
                                MeleeRadiant.sprite = null;
                                ShowCountRadiant.text = countPointsRadiant.ToString();

                            }
                            else
                            {
                                countPointsRadiant -= MeleeRadiant2Card.Power;
                                MeleeDire2.sprite = null;
                                ShowCountRadiant.text = countPointsRadiant.ToString();
                            }
                        }
                    }
                }
                //envia una carta aleatoria del campo rango dire a una zona rango del campo randiant
                else if (AsedyDire1Card.CardName == "Tiny")
                {
                    if (RangeRadiant1.sprite != null)
                    {
                        if (RangeRadiant2.sprite != null)
                        {
                            if (RangeRadiant1Card.Power > RangeRadiant2Card.Power)
                            {
                                countPointsRadiant -= RangeRadiant1Card.Power;
                                ShowCountRadiant.text = countPointsRadiant.ToString();
                                if (RangeDire1.sprite != null)
                                {
                                    RangeDire1.sprite = RangeRadiant1.sprite;
                                    RangeRadiant1.sprite = null;
                                }
                                else if (RangeDire1.sprite != null && RangeDire2.sprite == null)
                                {
                                    RangeDire2.sprite = RangeRadiant1.sprite;
                                    RangeRadiant1.sprite = null;
                                }
                            }
                            else
                            {
                                countPointsRadiant -= RangeRadiant2Card.Power;
                                RangeRadiant2.sprite = null;
                                ShowCountRadiant.text = countPointsRadiant.ToString();
                                if (RangeDire1.sprite == null)
                                {
                                    RangeDire1.sprite = RangeRadiant2.sprite;
                                    RangeRadiant2.sprite = null;
                                }
                                else if (RangeDire1.sprite != null && RangeDire2.sprite == null)
                                {
                                    RangeDire2.sprite = RangeRadiant2.sprite;
                                    RangeRadiant2.sprite = null;
                                }
                            }
                        }
                    }
                }
                countTurns++;
            }

        }
    }
    public void PoderZonaAsedy2Dire()
    {
        //eliminar la carta con mas poder de la zona melee
        if (AsedyDire2.sprite != null)
        {
            if (countTurns == 0)
            {
                if (AsedyDire2Card.CardName == "Razor")
                {
                    if (MeleeRadiant.sprite != null)
                    {
                        if (MeleeRadiant2.sprite != null)
                        {
                            if (MeleeRadiantCard.Power > MeleeRadiant2Card.Power)
                            {
                                countPointsRadiant -= MeleeRadiantCard.Power;
                                MeleeRadiant.sprite = null;
                                ShowCountRadiant.text = countPointsRadiant.ToString();

                            }
                            else
                            {
                                countPointsRadiant -= MeleeRadiant2Card.Power;
                                MeleeDire2.sprite = null;
                                ShowCountRadiant.text = countPointsRadiant.ToString();
                            }
                        }
                    }
                }
                //envia una carta aleatoria del campo rango dire a una zona rango del campo randiant
                else if (AsedyDire2Card.CardName == "Tiny")
                {
                    if (RangeRadiant1.sprite != null)
                    {
                        if (RangeRadiant2.sprite != null)
                        {
                            if (RangeRadiant1Card.Power > RangeRadiant2Card.Power)
                            {
                                countPointsRadiant -= RangeRadiant1Card.Power;
                                ShowCountRadiant.text = countPointsRadiant.ToString();
                                if (RangeDire1.sprite != null)
                                {
                                    RangeDire1.sprite = RangeRadiant1.sprite;
                                    RangeRadiant1.sprite = null;
                                }
                                else if (RangeDire1.sprite != null && RangeDire2.sprite == null)
                                {
                                    RangeDire2.sprite = RangeRadiant1.sprite;
                                    RangeRadiant1.sprite = null;
                                }
                            }
                            else
                            {
                                countPointsRadiant -= RangeRadiant2Card.Power;
                                RangeRadiant2.sprite = null;
                                ShowCountRadiant.text = countPointsRadiant.ToString();
                                if (RangeDire1.sprite == null)
                                {
                                    RangeDire1.sprite = RangeRadiant2.sprite;
                                    RangeRadiant2.sprite = null;
                                }
                                else if (RangeDire1.sprite != null && RangeDire2.sprite == null)
                                {
                                    RangeDire2.sprite = RangeRadiant2.sprite;
                                    RangeRadiant2.sprite = null;
                                }
                            }
                        }
                    }
                }
                countTurns++;
            }

        }
    }
    public void PoderLiderDire()
    {
        //multidisparo...elimina todas las cartas de cuerpo a cuerpo y rango del rival aumentando en 1/3 los puntos de poder

    }
    public void ShowCardStadistics()
    {

    }
}