using AK.Wwise;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Audio;

public class AudioMaterialTagMapping : ScriptableObject
{
	private AK.Wwise.Switch m_Default;

	private string[] m_Tags;

	private AK.Wwise.Switch[] m_Switches;

	[CalledBy(Type = typeof(GameAudioManager), Member = "SetMaterialSwitch")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AK.Wwise.Switch), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void SetSwitchByTag(string tag, GameObject emitter)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public AudioMaterialTagMapping()
	{
	}
}
