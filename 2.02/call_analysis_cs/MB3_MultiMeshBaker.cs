using Cpp2ILInjected.CallAnalysis;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB3_MultiMeshBaker : MB3_MeshBakerCommon
{
	protected MB3_MultiMeshCombiner _meshCombiner;

	public override MB3_MeshCombiner meshCombiner
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 11)]
	public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Object), Member = "get_name")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MB3_MultiMeshCombiner), Member = ".ctor")]
	[Calls(Type = typeof(MB3_MeshBakerCommon), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	public MB3_MultiMeshBaker()
	{
	}
}
