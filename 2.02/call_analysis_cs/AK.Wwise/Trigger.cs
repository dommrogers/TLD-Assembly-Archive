using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AK.Wwise;

[Serializable]
public class Trigger : BaseType
{
	public WwiseTriggerReference WwiseObjectReference;

	public override WwiseObjectReference ObjectReference
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public override WwiseObjectType WwiseObjectType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	public void Post(GameObject gameObject)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Trigger()
	{
	}
}
