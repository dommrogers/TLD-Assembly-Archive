using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LinkLights : MonoBehaviour
{
	public Light m_SourceLight;

	public bool m_LinkIntensity;

	public float m_IntensityMultiplier;

	public bool m_LinkColor;

	private Light m_ThisLight;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public LinkLights()
	{
	}
}
