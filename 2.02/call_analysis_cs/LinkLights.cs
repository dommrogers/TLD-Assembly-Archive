using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LinkLights : MonoBehaviour
{
	public Light m_SourceLight;

	public bool m_LinkIntensity;

	public float m_IntensityMultiplier;

	public bool m_LinkColor;

	private Light m_ThisLight;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	private void Update()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public LinkLights()
	{
	}
}
