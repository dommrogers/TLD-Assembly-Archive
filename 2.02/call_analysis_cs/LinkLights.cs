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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LinkLights()
	{
	}
}
