using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ObjectDependency : MonoBehaviour
{
	public GameObject m_Dependency;

	private float m_CheckTime;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ObjectDependency), Member = "CheckDependency")]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ObjectDependency), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private void CheckDependency()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ObjectDependency()
	{
	}
}
