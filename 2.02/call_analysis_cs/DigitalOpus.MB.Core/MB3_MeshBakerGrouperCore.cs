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
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal bool _003CDoClustering_003Eb__0(Renderer x)
		{
			return default(bool);
		}
	}

	public GrouperData d;

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	public abstract Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	public abstract void DrawGizmos(Bounds sourceObjectBounds);

	[CallsUnknownMethods(Count = 83)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(MB3_MeshBakerGrouperCore), Member = "AddMeshBaker")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(MB3_MeshBakerGrouperCore), Member = "GroupByLightmapIndex")]
	[CallsDeduplicatedMethods(Count = 32)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LODGroup), Member = "GetLODs")]
	public void DoClustering(MB3_TextureBaker tb, MB3_MeshBakerGrouper grouper)
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperCore), Member = "DoClustering")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Renderer), Member = "get_lightmapIndex")]
	[Calls(Type = typeof(Renderer), Member = "get_lightmapIndex")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	private Dictionary<int, List<Renderer>> GroupByLightmapIndex(List<Renderer> gaws)
	{
		return null;
	}

	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(MB3_MeshBakerGrouperCore), Member = "DoClustering")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsUnknownMethods(Count = 27)]
	[Calls(Type = typeof(Mesh), Member = "get_vertexCount")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MB_Utility), Member = "GetMesh")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private void AddMeshBaker(MB3_TextureBaker tb, string key, List<Renderer> gaws)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	protected MB3_MeshBakerGrouperCore()
	{
	}
}
