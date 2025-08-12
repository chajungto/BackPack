using System.Collections.Generic;
using UnityEngine;

public class ObjectDetector : MonoBehaviour
{
    [SerializeField] private Object _nearest = null;               //가장 가까운 물체

    private HashSet<Object> m_objects = new HashSet<Object>();           //NPC HashSet

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Object>(out Object obj))
        {
            m_objects.Add(obj);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Object>(out Object obj))
        {
            m_objects.Remove(obj);
        }
    }

    private void Update()
    {
        float minDistSqr = Mathf.Infinity;
        Object nearObj = null;

        foreach (var nObject in m_objects)
        {
            float distSqr = (nObject.transform.position - transform.position).sqrMagnitude;
            if (distSqr < minDistSqr)
            {
                minDistSqr = distSqr;
                nearObj = nObject;
            }
        }

        if (_nearest != nearObj)
        {
            if (_nearest != null) _nearest.NameCanvas.UndoArrowMove();
            _nearest = nearObj;
            if (_nearest != null) _nearest.NameCanvas.DoArrowMove();
        }
    }

}
