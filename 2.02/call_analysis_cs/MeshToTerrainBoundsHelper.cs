using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class MeshToTerrainBoundsHelper : MonoBehaviour
{
	public Action OnBoundChanged;

	public Action OnDestroyed;

	public Bounds bounds;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MeshToTerrainBoundsHelper()
	{
	}
}
