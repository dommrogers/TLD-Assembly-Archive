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
			[CallerCount(Count = 7)]
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
				return 0;
			}

			[DeduplicatedMethod]
			[CallerCount(Count = 7)]
			public ItemComparer()
			{
			}
		}

		public Vector3 sortAxis;

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Vector3), Member = "get_zero")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Debug), Member = "Log")]
		[Calls(Type = typeof(List<>), Member = ".ctor")]
		[Calls(Type = typeof(Vector3), Member = "get_forward")]
		[Calls(Type = typeof(Object), Member = "op_Inequality")]
		[Calls(Type = typeof(GameObject), Member = "get_transform")]
		[Calls(Type = typeof(Transform), Member = "get_position")]
		[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
		[Calls(Type = typeof(List<>), Member = "Add")]
		[Calls(Type = typeof(List<>), Member = "Sort")]
		[Calls(Type = typeof(Debug), Member = "LogError")]
		[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 31)]
		public void SortByDistanceAlongAxis(List<GameObject> gos)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public ZSortObjects()
		{
		}
	}

	public static bool DO_INTEGRITY_CHECKS;

	public Vector3 sortAxis;

	public abstract MB2_TextureBakeResults textureBakeResults { get; set; }

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[CalledBy(TypeFullName = "MB3_TextureBaker.<CreateAtlasesCoroutine>d__94", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(MB3_MeshBakerCommon), Member = "GetTextureBaker")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(MB_Utility), Member = "GetGOMaterials")]
	[Calls(Type = typeof(MB_Utility), Member = "GetMesh")]
	[Calls(Type = typeof(Application), Member = "get_isPlaying")]
	[Calls(Type = typeof(Object), Member = "GetInstanceID")]
	[Calls(Type = typeof(MB_Utility), Member = "doSubmeshesShareVertsOrTris")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 37)]
	public static bool DoCombinedValidate(MB3_MeshBakerRoot mom, MB_ObjsToCombineTypes objToCombineType, MB2_EditorMethodsInterface editorMethods, MB2_ValidationLevel validationLevel)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	protected MB3_MeshBakerRoot()
	{
	}
}
