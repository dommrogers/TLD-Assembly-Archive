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

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public static Packed GetWorldPacked(this Transform self)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnWillCameraRender")]
	[CallsUnknownMethods(Count = 4)]
	public static bool IsSame(this Transform self, Packed packed)
	{
		return default(bool);
	}
}
