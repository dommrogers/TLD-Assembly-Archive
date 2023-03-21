using System;
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
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
	[Calls(Type = typeof(TransformVolume), Member = "GetBounds")]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	public bool IsInBounds(Vector3[] points)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 16)]
	public bool IsOnBorder(Vector3[] points)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 8)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public bool IsInVolume(Vector3[] points)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(TransformVolume), Member = "GetSideDirection")]
	[Calls(Type = typeof(TransformVolume), Member = "GetSidePosition")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Plane), Member = "GetSide")]
	public bool IsInVolume(Vector3 position)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(TransformVolume), Member = "GetGameObjectsInBounds")]
	[CalledBy(Type = typeof(TransformVolume), Member = "GetBounds")]
	[CallsUnknownMethods(Count = 30)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(TransformVolume), Member = "IsInBounds")]
	public Vector3[] GetCorners()
	{
		return null;
	}

	[Calls(Type = typeof(TransformVolume), Member = "GetBounds")]
	[Calls(Type = typeof(TransformVolume), Member = "GetCorners")]
	[CallerCount(Count = 0)]
	public Bounds GetBounds()
	{
		return default(Bounds);
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Bounds), Member = "Encapsulate")]
	[CalledBy(Type = typeof(TransformVolume), Member = "IsInBounds")]
	[CalledBy(Type = typeof(TransformVolume), Member = "IsInBounds")]
	[CalledBy(Type = typeof(TransformVolume), Member = "GetBounds")]
	[CalledBy(Type = typeof(TransformVolume), Member = "GetGameObjectsInBounds")]
	[CallsUnknownMethods(Count = 10)]
	public Bounds GetBounds(Vector3[] points)
	{
		return default(Bounds);
	}

	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(Bounds), Member = "Intersects")]
	[Calls(Type = typeof(Renderer), Member = "get_bounds")]
	[Calls(Type = typeof(GameObject), Member = "get_layer")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransformVolume), Member = "GetBounds")]
	[Calls(Type = typeof(TransformVolume), Member = "GetCorners")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public GameObject[] GetGameObjectsInBounds(LayerMask layerMask)
	{
		return null;
	}

	[CalledBy(Type = typeof(TransformVolume), Member = "IsInVolume")]
	[CalledBy(Type = typeof(TransformVolume), Member = "<IsOnBorder>b__9_0")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	public Vector3 GetSideDirection(int side)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[CalledBy(Type = typeof(TransformVolume), Member = "IsInVolume")]
	[CalledBy(Type = typeof(TransformVolume), Member = "<IsOnBorder>b__9_0")]
	[CallsUnknownMethods(Count = 18)]
	public Vector3 GetSidePosition(int side)
	{
		return default(Vector3);
	}

	[CallerCount(Count = 0)]
	public float GetSizeAxis(int side)
	{
		return default(float);
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public TransformVolume()
	{
	}
}
