using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightmapColorOverride : MonoBehaviour
{
	public Color m_Color;

	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateLightmaps")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public bool IsEnabled()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public LightmapColorOverride()
	{
	}
}
