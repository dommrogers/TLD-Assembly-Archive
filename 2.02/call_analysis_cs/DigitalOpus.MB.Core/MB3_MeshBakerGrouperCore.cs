using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace DigitalOpus.MB.Core;

[Serializable]
public abstract class MB3_MeshBakerGrouperCore
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public Renderer r;

		public Predicate<Renderer> _003C_003E9__0;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 1)]
		internal bool _003CDoClustering_003Eb__0(Renderer x)
		{
			return false;
		}
	}

	public GrouperData d;

	public abstract Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection);

	public abstract void DrawGizmos(Bounds sourceObjectBounds);

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >.KeyCollection.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(MB3_MeshBakerGrouperCore), Member = "GroupByLightmapIndex")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponentInParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(LODGroup), Member = "GetLODs")]
	[Calls(Type = typeof(Array), Member = "Find")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(List<>), Member = "Contains")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(MB3_MeshBakerGrouperCore), Member = "AddMeshBaker")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 83)]
	public void DoClustering(MB3_TextureBaker tb, MB3_MeshBakerGrouper grouper)
	{
	}

	[CalledBy(Type = typeof(MB3_MeshBakerGrouperCore), Member = "DoClustering")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Renderer), Member = "get_lightmapIndex")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 21)]
	private Dictionary<int, List<Renderer>> GroupByLightmapIndex(List<Renderer> gaws)
	{
		return null;
	}

	[CalledBy(Type = typeof(MB3_MeshBakerGrouperCore), Member = "DoClustering")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MB_Utility), Member = "GetMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Mesh), Member = "get_vertexCount")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 27)]
	private void AddMeshBaker(MB3_TextureBaker tb, string key, List<Renderer> gaws)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	protected MB3_MeshBakerGrouperCore()
	{
	}
}
