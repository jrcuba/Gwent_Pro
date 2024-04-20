using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Card",menuName ="New Card")]

public class Card : ScriptableObject
{
    public int Power;
    public string CardName;
    public string Faction;
    public string Description;
    public string Type;
    public string FileType;
    public string Efect;
    public Sprite Picture;
}
