using System;
using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class AkRTPCPlayableBehaviour : PlayableBehaviour
{
	private bool m_OverrideTrackObject;

	private RTPC m_Parameter;

	private GameObject m_RTPCObject;

	private bool m_SetRTPCGlobally;

	public float RTPCValue;

	public bool setRTPCGlobally
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public bool overrideTrackObject
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public GameObject rtpcObject
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		set
		{
		}
	}

	public RTPC parameter
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(AkSoundEngine), Member = "SetRTPCValue")]
	[Calls(Type = typeof(RTPC), Member = "SetGlobalValue")]
	[CallsUnknownMethods(Count = 4)]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public AkRTPCPlayableBehaviour()
	{
	}
}
