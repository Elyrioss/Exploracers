using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

/*Summary :
 * 
 * Manages board interactions
 */
public class BoardInteraction : MonoBehaviour
{   
    // Clicking on a card allows you to show the card in full screen
    [SerializeField] private GameObject m_mask;
    [SerializeField] private Image m_showVerticalCard;
    [SerializeField] private Image m_showHorizontalCard;

    //Ray cast UI
    [SerializeField] GraphicRaycaster m_raycaster;
    PointerEventData m_pointerEventData;
    [SerializeField] EventSystem m_eventSystem;
    [SerializeField] RectTransform m_canvasRect;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!m_mask.activeSelf)
            {
                //Set up the new Pointer Event
                m_pointerEventData = new PointerEventData(m_eventSystem);
                //Set the Pointer Event Position to that of the game object
                m_pointerEventData.position = Input.mousePosition;

                //Create a list of Raycast Results
                List<RaycastResult> results = new List<RaycastResult>();

                //Raycast using the Graphics Raycaster and mouse click position
                m_raycaster.Raycast(m_pointerEventData, results);

                if (results.Count > 0)
                {
                    BoardCard resultCard = results[0].gameObject.GetComponent<BoardCard>();
                    if(resultCard != null)
                    {
                        m_mask.SetActive(true);
                        if (resultCard.GetCardOrientation())
                        {
                            m_showHorizontalCard.gameObject.SetActive(true);
                            m_showHorizontalCard.sprite = resultCard.GetCardImage();
                        }
                        else
                        {
                            m_showVerticalCard.gameObject.SetActive(true);
                            m_showVerticalCard.sprite = resultCard.GetCardImage();
                        }


                    }                    
                }
            }
            else
            {
                m_mask.SetActive(false);
                m_showVerticalCard.gameObject.SetActive(false);
                m_showHorizontalCard.gameObject.SetActive(false);
                m_showVerticalCard.sprite = null;
            }
        }           
    }
}
