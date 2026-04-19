using CLogic.Runtime.DataSaving;
namespace CLogic.Conditionals
{
    public abstract class PersistentConditional<T> : ConditionalEvaluator
    {
        public string section;
        public string id;
        
        public T defaultValue;
        
        protected abstract bool EvaluatePersistent(T persistentValue);
        
        public override bool Evaluate() => EvaluatePersistent(GameSaver.GetData(id, section, defaultValue));
    }
}
