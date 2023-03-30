using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

[Serializable]
public class AnimationEventData
{
	public AnimationEventType m_Type;

	public string m_Name;

	public float m_FrameStart;

	public float m_FrameEnd;

	public bool m_TriggerOnExit;

	public AnimationEventValue m_Value;

	public RuntimeAnimatorController m_Target;

	public int m_TargetCycleOffsetParamHash;

	public TextAsset m_SubtitleAsset;

	private string m_CachedName;

	private RuntimeAnimatorController m_CachedTarget;

	private string m_CachedString;

	[CalledBy(Type = typeof(AnimationEvents), Member = "MaybeRecreateEventArrays")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "PushAnimationEventValue")]
	[CalledBy(Type = typeof(AnimationEvents), Member = "PopAnimationEventValue")]
	[CallerCount(Count = 4)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	public string Key()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public AnimationEventData()
	{
	}
}
