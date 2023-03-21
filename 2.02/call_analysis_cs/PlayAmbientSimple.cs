using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PlayAmbientSimple : BaseSimpleAudioComponent
{
	public AK.Wwise.Event m_Event;

	public MultiPositionTypeLabel m_MultiPositionType;

	public float m_Radius;

	public bool m_StopWhenDisabled;

	public bool IsSimpleAmbient
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "AddAmbient")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PlayAudioSimpleManager), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public PlayAmbientSimple()
	{
	}
}
