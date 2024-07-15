using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MouseActionComponent : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private UnityEvent<GameObject> _leftButtonActionWithObject;
    [SerializeField] private UnityEvent<GameObject> _rightButtonActionWithObject;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Right)
        {
            _rightButtonActionWithObject?.Invoke(gameObject);
        }
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            _leftButtonActionWithObject?.Invoke(gameObject);
        }
    }
}
