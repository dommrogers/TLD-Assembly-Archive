using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Rendering;

public class DynamicResolutionConfig : ScriptableObject
{
	private float m_StaticScalingMin;

	private float m_StaticScalingMax;

	private DynamicResolutionPlatformConfig m_XboxOneS;

	private DynamicResolutionPlatformConfig m_XboxOneX;

	private DynamicResolutionPlatformConfig m_PS4;

	private DynamicResolutionPlatformConfig m_PS4Pro;

	private DynamicResolutionPlatformConfig m_SwitchHandheld;

	private DynamicResolutionPlatformConfig m_SwitchDocked;

	private DynamicResolutionPlatformConfig m_SteamDeck;

	public float StaticScalingMin
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	public float StaticScalingMax
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	[CallerCount(Count = 0)]
	public DynamicResolutionPlatformConfig GetPlatformConfig()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public DynamicResolutionConfig()
	{
	}
}
