using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class AnimationStateRef
{
	public RuntimeAnimatorController m_Target;

	public string m_StateName;

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public AnimationStateRef()
	{
	}
}
