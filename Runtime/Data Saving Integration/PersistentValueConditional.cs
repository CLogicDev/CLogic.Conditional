using System;
using UnityEngine;
namespace CLogic.Conditional
{
    [CreateAssetMenu(menuName =  "CLogic/Conditionals/Persistent Value Conditional", fileName = "Persistent Value Conditional")]
    public class PersistentValueConditional : PersistentConditional<float>
    {
        public enum ValueComparison
        {
            Equals,
            NotEquals,
            LessThan,
            LessThanOrEquals,
            GreaterThan,
            GreaterThanOrEquals,
        }
        
        public ValueComparison comparison;
        
        public float comparisonValue;
        
        protected override bool EvaluatePersistent(float persistentValue)
        {
            return comparison switch
            {
                ValueComparison.Equals => persistentValue == comparisonValue,
                ValueComparison.NotEquals => persistentValue != comparisonValue,
                ValueComparison.LessThan => persistentValue < comparisonValue,
                ValueComparison.LessThanOrEquals => persistentValue <= comparisonValue,
                ValueComparison.GreaterThan => persistentValue > comparisonValue,
                ValueComparison.GreaterThanOrEquals => persistentValue >= comparisonValue,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
