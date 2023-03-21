using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WindKiller : MonoBehaviour
{
	private Collider m_Collider;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 6)]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public bool PointInside(Vector3 pos)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public WindKiller()
	{
	}
}
