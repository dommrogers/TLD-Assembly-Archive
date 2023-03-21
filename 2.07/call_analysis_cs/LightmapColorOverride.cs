using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightmapColorOverride : MonoBehaviour
{
	public Color m_Color;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(DarkLightingManager), Member = "UpdateLightmaps")]
	[CallsUnknownMethods(Count = 4)]
	public bool IsEnabled()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LightmapColorOverride()
	{
	}
}
