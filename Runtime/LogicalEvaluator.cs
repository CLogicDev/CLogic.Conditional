using System;
using System.Linq;
namespace CLogic.Conditional
{
    public class LogicalEvaluator : ConditionalEvaluator
    {
        public enum LogicalOperationType
        {
            NOT,
            AND,
            OR,
            XOR,
            XNOR
        }
        
        public ConditionalEvaluator[] evaluators;
        public LogicalOperationType logicalOperationType;
        
        public override bool Evaluate()
        {
            return logicalOperationType switch
            {
                LogicalOperationType.NOT => !evaluators[0],
                LogicalOperationType.AND => evaluators.All(x => x.Evaluate()),
                LogicalOperationType.OR => evaluators.Any(x => x.Evaluate()),
                LogicalOperationType.XOR => evaluators.Count(x => x.Evaluate()) % 2 == 1,
                LogicalOperationType.XNOR => evaluators.Count(x => x.Evaluate()) % 2 == 0,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
