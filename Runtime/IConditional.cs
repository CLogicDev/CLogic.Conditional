using System;
using UnityEngine;
namespace CLogic.Conditional
{
    public interface IConditional
    {
        public bool Evaluate();
    }
    
    [Serializable]
    public readonly struct StaticConditional : IConditional
    {
        private readonly bool staticValue;
        
        public bool Evaluate() => staticValue;
        
        private StaticConditional(bool staticValue)
        {
            this.staticValue = staticValue;
        }
        
        public static StaticConditional FromBool(bool staticValue) => new (staticValue);
    }
    
    public abstract class ConditionalEvaluator : ScriptableObject, IConditional
    {
        public abstract bool Evaluate();
        
        public static implicit operator bool(ConditionalEvaluator evaluator) => evaluator == null || evaluator.Evaluate();
        
        public virtual void Reset() {  }
    }
}
