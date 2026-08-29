# CLogic.Conditional

The CLogic Conditional system provides an inteface through which certain states can be evaluated to check
whether a condition is met. It helps reduce tight coupling of related systems.

For example, a sprinting system might require the player to have greater than X amount of health
and/or greater than Y amount of stamina. Instead of checking for them individually, you can evaluate
a conditional that will do the required check.

# Usage

At its core, there are 2 ways to use the system
- Using the interface `IConditional`
- Using the ScriptableObject Architecture Pattern (SOAP)

For more details on SOAP, feel free to read this [article](https://medium.com/@simon.nordon/unity-architecture-scriptable-object-pattern-0a6c25b2d741) by Simon Nordon

## Using `IConditional`

The `IConditional` interface is ultimately what this library provides. The interface exposes a `public bool Evaluate()` contract
that inheritors can edit to whatever kind of logic.

## Using SOAP

The library also exposes an `abstract class ConditionalEvaluator` that scriptableobjects can inherit from. The use-case above
remains the same as it also implements `IConditional`. This is useful in cases where your consumer only needs information about the condition.
SOAP allows you to simply slot it in the required field.

---

That's about it.
