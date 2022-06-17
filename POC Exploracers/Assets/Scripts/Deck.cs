using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    private const int CARD_NUMBER = 30;
    private int m_cardsInDeck;
    private int m_cardsInHand;

    [SerializeField] List<DeckCards> m_BaseCards;
    private List<DeckCards> m_currentDeck;

    public void Initialise()
    {
        m_cardsInDeck = CARD_NUMBER;
        m_currentDeck = m_BaseCards;
    }

    public List<DeckCards> Draw(int cardsToDraw)
    {
        List<DeckCards> cardResults = new List<DeckCards>();
        List<int> nums = new List<int>();

        while (cardResults.Count < cardsToDraw)
        {
            int num = Random.Range(0, CARD_NUMBER);
          
            if (!nums.Contains(num))
            {
                nums.Add(num);
                cardResults.Add(m_currentDeck[num]);
                m_currentDeck.RemoveAt(num);
                m_currentDeck.TrimExcess();
            }
        }

        return cardResults;
    }

}
