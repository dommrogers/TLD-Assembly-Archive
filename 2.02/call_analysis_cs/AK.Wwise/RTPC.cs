using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AK.Wwise;

[Serializable]
public class RTPC : BaseType
{
	public WwiseRtpcReference WwiseObjectReference;

	public override WwiseObjectReference ObjectReference
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public override WwiseObjectType WwiseObjectType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[CallsUnknownMethods(Count = 1)]
	public void SetValue(GameObject gameObject, float value)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(AkSoundEngine), Member = "GetAkGameObjectID")]
	[Calls(Type = typeof(AkSoundEngine), Member = "PreGameObjectAPICall")]
	[CalledBy(Type = typeof(RTPC), Member = "GetGlobalValue")]
	[CallsUnknownMethods(Count = 2)]
	public float GetValue(GameObject gameObject)
	{
		return default(float);
	}

	[CalledBy(Type = typeof(AkRTPCPlayableBehaviour), Member = "ProcessFrame")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	public void SetGlobalValue(float value)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RTPC), Member = "GetValue")]
	public float GetGlobalValue()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public RTPC()
	{
	}
}
