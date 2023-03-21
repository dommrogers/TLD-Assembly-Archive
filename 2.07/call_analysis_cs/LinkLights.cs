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
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Light), Member = "set_intensity")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	public LinkLights()
	{
	}
}
