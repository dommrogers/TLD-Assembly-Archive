using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace SimpleLightProbePlacer;

public class TransformVolume : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Vector3, Vector3, Vector3> _003C_003E9__14_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal Vector3 _003CGetBounds_003Eb__14_0(Vector3 result, Vector3 point)
		{
			return default(Vector3);
		}
	}

	private Volume m_volume;

	public Volume Volume
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Volume);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public Vector3 Origin
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
	}

	public Vector3 Size
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector3);
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransformVolume), Member = "GetCorners")]
	[Calls(Type = typeof(TransformVolume), Member = "GetBounds")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	public bool IsInBounds(Vector3[] points)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "All")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 14)]
	public bool IsOnBorder(Vector3[] points)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "All")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public bool IsInVolume(Vector3[] points)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransformVolume), Member = "GetSideDirection")]
	[Calls(Type = typeof(TransformVolume), Member = "GetSidePosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Plane), Member = "GetSide")]
	[CallsDeduplicatedMethods(Count = 1)]
	public bool IsInVolume(Vector3 position)
	{
		return false;
	}

	[CalledBy(Type = typeof(TransformVolume), Member = "IsInBounds")]
	[CalledBy(Type = typeof(TransformVolume), Member = "GetBounds")]
	[CalledBy(Type = typeof(TransformVolume), Member = "GetGameObjectsInBounds")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 30)]
	public Vector3[] GetCorners()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransformVolume), Member = "GetCorners")]
	[Calls(Type = typeof(TransformVolume), Member = "GetBounds")]
	public Bounds GetBounds()
	{
		return default(Bounds);
	}

	[CalledBy(Type = typeof(TransformVolume), Member = "IsInBounds")]
	[CalledBy(Type = typeof(TransformVolume), Member = "GetBounds")]
	[CalledBy(Type = typeof(TransformVolume), Member = "GetGameObjectsInBounds")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Enumerable), Member = "Aggregate")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 10)]
	public Bounds GetBounds(Vector3[] points)
	{
		return default(Bounds);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "FindObjectsOfType")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(TransformVolume), Member = "GetCorners")]
	[Calls(Type = typeof(TransformVolume), Member = "GetBounds")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 30)]
	public GameObject[] GetGameObjectsInBounds(LayerMask layerMask)
	{
		return null;
	}

	[CalledBy(Type = typeof(TransformVolume), Member = "IsInVolume")]
	[CalledBy(Type = typeof(TransformVolume), Member = "<IsOnBorder>b__9_0")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	public Vector3 GetSideDirection(int side)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(TransformVolume), Member = "IsInVolume")]
	[CalledBy(Type = typeof(TransformVolume), Member = "<IsOnBorder>b__9_0")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 18)]
	public Vector3 GetSidePosition(int side)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public float GetSizeAxis(int side)
	{
		return 0f;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	public TransformVolume()
	{
	}
}
