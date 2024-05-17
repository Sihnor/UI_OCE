using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance;
        
        public event Action<float> QuestProgress;
        
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        
        public void SetQuestProgress(float progress)
        {
            QuestProgress?.Invoke(progress);
        }
    }
}