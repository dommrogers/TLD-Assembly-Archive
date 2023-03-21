using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FlareRandomBrightness : MonoBehaviour
{
	public float m_IntervalSeconds;

	public float m_Min;

	public float m_Max;

	private float m_CurrentTime;

	private float m_Destination;

	private float m_FlareBrightnessStart;

	private LensFlare m_LensFlare;

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Random), Member = "Range")]
	private void Start()
	{
	}

	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public FlareRandomBrightness()
	{
	}
}
