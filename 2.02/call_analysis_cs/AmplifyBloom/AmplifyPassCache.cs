using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AmplifyBloom;

[Serializable]
public class AmplifyPassCache
{
	internal Vector4[] Offsets;

	internal Vector4[] Weights;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public AmplifyPassCache()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void Destroy()
	{
	}
}
