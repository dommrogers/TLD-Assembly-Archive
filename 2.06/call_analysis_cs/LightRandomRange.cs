using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LightRandomRange : MonoBehaviour
{
	public float m_IntervalSeconds;

	public float m_Min;

	public float m_Max;

	private float m_CurrentTime;

	private float m_Destination;

	private float m_LightRangeStart;

	private Light m_Light;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Mathf), Member = "SmoothStep")]
	[Calls(Type = typeof(Light), Member = "set_range")]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	public float GetRange()
	{
		return default(float);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LightRandomRange()
	{
	}
}
