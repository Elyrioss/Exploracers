using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{

    [SerializeField] private Deck m_deck;
    void Start()
    {
        m_deck.Initialise();
        m_deck.Draw(5);
    }
}
