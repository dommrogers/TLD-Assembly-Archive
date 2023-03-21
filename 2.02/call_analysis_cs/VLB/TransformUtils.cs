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
		[CallerCount(Count = 2)]
		public Packed()
		{
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusion")]
	[CallsUnknownMethods(Count = 12)]
	public static Packed GetWorldPacked(this Transform self)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnWillCameraRender")]
	[Calls(Type = typeof(Quaternion), Member = "op_Equality")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static bool IsSame(this Transform self, Packed packed)
	{
		return default(bool);
	}
}
