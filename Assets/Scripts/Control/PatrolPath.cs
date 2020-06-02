using UnityEngine;

namespace RPG.Control
{
    public class PatrolPath : MonoBehaviour
    {
        private void OnDrawGizmos() 
        {            
            for (int i = 0; i < transform.childCount; i++)
            {
                Vector3 position = GetPositionAtIndex(i);
                Gizmos.DrawSphere(position, 0.2f);
                Gizmos.DrawLine(position, GetPositionAtIndex(GetNextIndex(i)));
            }
        }

        public int GetNextIndex(int i) 
        {
            return (i + 1) % transform.childCount;
        }

        public Vector3 GetPositionAtIndex(int i)
        {
            return transform.GetChild(i).position;
        }
    }
}


