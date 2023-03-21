using Cpp2ILInjected.CallAnalysis;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB2_UpdateSkinnedMeshBoundsFromBones : MonoBehaviour
{
	private SkinnedMeshRenderer smr;

	private Transform[] bones;

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	private void Start()
	{
	}

	[Calls(Type = typeof(MB3_MeshCombiner), Member = "UpdateSkinnedMeshApproximateBoundsFromBonesStatic")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public MB2_UpdateSkinnedMeshBoundsFromBones()
	{
	}
}
