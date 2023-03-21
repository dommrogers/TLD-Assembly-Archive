using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using DigitalOpus.MB.Core;
using UnityEngine;

public abstract class MB3_MeshBakerRoot : MonoBehaviour
{
	public class ZSortObjects
	{
		public class Item
		{
			public GameObject go;

			public Vector3 point;

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public Item()
			{
			}
		}

		public class ItemComparer : IComparer<Item>
		{
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 2)]
			public int Compare(Item a, Item b)
			{
				return default(int);
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 2)]
			public ItemComparer()
			{
			}
		}

		public Vector3 sortAxis;

		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(Transform), Member = "get_position")]
		[Calls(Type = typeof(Vector3), Member = "get_forward")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(GameObject), Member = "get_transform")]
		[CallsUnknownMethods(Count = 31)]
		public void SortByDistanceAlongAxis(List<GameObject> gos)
		{
		}

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public ZSortObjects()
		{
		}
	}

	public static bool DO_INTEGRITY_CHECKS;

	public Vector3 sortAxis;

	public abstract MB2_TextureBakeResults textureBakeResults
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		set;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(MB3_TextureBaker._003CCreateAtlasesCoroutine_003Ed__94), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 37)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "GetInstanceID")]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MB3_MeshBakerCommon), Member = "GetTextureBaker")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
	[Calls(Type = typeof(MB_Utility), Member = "GetMesh")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(MB_Utility), Member = "doSubmeshesShareVertsOrTris")]
	public static bool DoCombinedValidate(MB3_MeshBakerRoot mom, MB_ObjsToCombineTypes objToCombineType, MB2_EditorMethodsInterface editorMethods, MB2_ValidationLevel validationLevel)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected MB3_MeshBakerRoot()
	{
	}
}
