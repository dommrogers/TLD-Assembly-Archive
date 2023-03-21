using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class AnimationStateRef
{
	public RuntimeAnimatorController m_Target;

	public string m_StateName;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public AnimationStateRef()
	{
	}
}
