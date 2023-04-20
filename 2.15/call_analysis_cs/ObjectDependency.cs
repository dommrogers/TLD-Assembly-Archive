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
	[Calls(Type = typeof(ObjectDependency), Member = "CheckDependency")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(ObjectDependency), Member = "Update")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	private void CheckDependency()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ObjectDependency()
	{
	}
}
