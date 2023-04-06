using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LinkLightIntensityToEmissiveTex : MonoBehaviour
{
	public Light m_SourceLight;

	public Material m_DestinationMaterial;

	public float m_IntensityMultiplier;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LinkLightIntensityToEmissiveTex()
	{
	}
}
