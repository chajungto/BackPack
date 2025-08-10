using UnityEngine;

[CreateAssetMenu(fileName = "NewNPC", menuName = "NPC/NPCData")]

public class NPCData : ScriptableObject
{
    //NPC ���̵�
    [SerializeField] private string npcId;
    public string NpcId { get { return npcId; } set { npcId = value; } }

    //NPC �̸�
    [SerializeField] private string npcName;        
    public string NpcName { get { return npcName; } set { npcName = value; } }
}   
