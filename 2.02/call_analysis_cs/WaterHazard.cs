using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WaterHazard : MonoBehaviour
{
	private Material m_LocalMaterial;

	private float m_WindAngle;

	private float m_WindSpeed;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WaterHazard()
	{
	}
}
