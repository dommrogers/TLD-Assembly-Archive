using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectDependency : MonoBehaviour
{
	public GameObject m_Dependency;

	private float m_CheckTime;

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	private void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private void CheckDependency()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public ObjectDependency()
	{
	}
}
