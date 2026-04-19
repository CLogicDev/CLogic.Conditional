using EditorAttributes;
using UnityEngine;
namespace CLogic.Conditionals.Test.Tests
{
    public class ConditionalTest : MonoBehaviour
    {
        public ConditionalEvaluator evaluator;
        
        [Button]
        public void CheckCondition()
        {
            Debug.Log(evaluator.Evaluate().ToString());
        }
    }
}
