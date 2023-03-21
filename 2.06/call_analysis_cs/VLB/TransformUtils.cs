using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public static class TransformUtils
{
	public class Packed
	{
		public Vector3 position;

		public Quaternion rotation;

		public Vector3 lossyScale;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public Packed()
		{
		}
	}

	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusion")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public static Packed GetWorldPacked(this Transform self)
	{
		return null;
	}

	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnWillCameraRender")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public static bool IsSame(this Transform self, Packed packed)
	{
		return false;
	}
}
