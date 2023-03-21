using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LinkLightIntensityToEmissiveTex : MonoBehaviour
{
	public Light m_SourceLight;

	public Material m_DestinationMaterial;

	public float m_IntensityMultiplier;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LinkLightIntensityToEmissiveTex()
	{
	}
}
