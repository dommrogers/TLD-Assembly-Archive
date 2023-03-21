using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WindKiller : MonoBehaviour
{
	private Collider m_Collider;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public bool PointInside(Vector3 pos)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public WindKiller()
	{
	}
}
