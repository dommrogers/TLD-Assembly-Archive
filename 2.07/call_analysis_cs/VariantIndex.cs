using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class VariantIndex : StateMachineBehaviour
{
	public enum Type
	{
		Random,
		ConsecuativeNegative,
		ConsecuativePositive
	}

	public int m_MaxIndex;

	public string m_IntParam;

	public static int m_LastIndex;

	public Type m_Type;

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	public VariantIndex()
	{
	}
}
