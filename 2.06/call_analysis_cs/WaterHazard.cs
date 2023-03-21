using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WaterHazard : MonoBehaviour
{
	private Material m_LocalMaterial;

	private float m_WindAngle;

	private float m_WindSpeed;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[CallsUnknownMethods(Count = 3)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public WaterHazard()
	{
	}
}
