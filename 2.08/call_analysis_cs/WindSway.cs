using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WindSway : MonoBehaviour
{
	public float m_ForceMultiplier;

	public float m_MaxWindSpeed;

	public MinMax m_RandomForceMultiplier;

	public MinMax m_RandomForceChangeTime;

	private float m_WindFactor;

	private float m_SwayDirection;

	private float m_CurRandomForceMultiplier;

	private float m_CurRandomForceTimer;

	private ConstantForce m_ConstantForce;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Random), Member = "Range")]
	[Calls(Type = typeof(Random), Member = "Range")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void FixedUpdate()
	{
	}

	[CallerCount(Count = 0)]
	public WindSway()
	{
	}
}
