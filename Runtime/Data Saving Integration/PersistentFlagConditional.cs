using System;
using UnityEngine;
namespace CLogic.Conditional
{
    [CreateAssetMenu(menuName = "CLogic/Conditionals/Persistent Flag Conditional", fileName = "Persistent Flag Conditional")]
    public class PersistentFlagConditional : PersistentConditional<bool>
    {
        public bool requiredValue;
        
        protected override bool EvaluatePersistent(bool persistentValue) => persistentValue == requiredValue;
    }
}
