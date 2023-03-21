using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimationEventStack
{
	public string m_Name;

	public int m_NameHash;

	public AnimatorControllerParameterType m_Type;

	public RuntimeAnimatorController m_Target;

	public int m_Top;

	public AnimationEventValue[] m_Stack;

	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeRecreateEventArrays")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public AnimationEventStack(string name, AnimatorControllerParameterType type, RuntimeAnimatorController target)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void Push(AnimationEventValue value)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public AnimationEventValue Pop()
	{
		return default(AnimationEventValue);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Reset()
	{
	}
}
