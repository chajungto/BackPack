using System.Collections.Generic;
using UnityEngine;

public class NPCDetector : MonoBehaviour
{
    [SerializeField] private NPC _nearest = null;               //가장 가까운 물체

    private HashSet<NPC> m_NPCs = new HashSet<NPC>();           //NPC HashSet

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("NPC"))
        {
            if(collision.gameObject.TryGetComponent<NPC>(out NPC npc))
            {
                m_NPCs.Add(npc);

            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("NPC"))
        {
            if (collision.gameObject.TryGetComponent<NPC>(out NPC npc))
            {
                m_NPCs.Remove(npc);

            }
        }
    }

    private void Update()
    {
        float minDistSqr = Mathf.Infinity;
        NPC nearNPC = null;

        foreach (var nObject in m_NPCs)
        {
            float distSqr = (nObject.transform.position - transform.position).sqrMagnitude;
            if (distSqr < minDistSqr)
            {
                minDistSqr = distSqr;
                nearNPC = nObject;
            }
        }

        if (_nearest != nearNPC)
        {
            if (_nearest != null) _nearest.NameCanvas.UndoArrowMove();
            _nearest = nearNPC;
            if (_nearest != null) _nearest.NameCanvas.DoArrowMove();
        }
    }

}
