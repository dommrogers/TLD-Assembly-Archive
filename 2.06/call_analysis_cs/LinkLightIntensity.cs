using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LinkLightIntensity : MonoBehaviour
{
	public Light m_SourceLight;

	public float m_IntensityMultiplier;

	private Light m_ThisLight;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public LinkLightIntensity()
	{
	}
}
