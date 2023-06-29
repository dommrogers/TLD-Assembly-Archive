using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InteractiveObjects;

public class TrackableItemType : ScriptableObject
{
	public string m_SpriteName;

	public Color m_ShortwaveLightColor;

	public AK.Wwise.Event m_SwitchTrackingModeAudioEvent;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public TrackableItemType()
	{
	}
}
