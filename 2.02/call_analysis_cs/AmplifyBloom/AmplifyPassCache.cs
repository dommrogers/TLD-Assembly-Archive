using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AmplifyBloom;

[Serializable]
public class AmplifyPassCache
{
	internal Vector4[] Offsets;

	internal Vector4[] Weights;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public AmplifyPassCache()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void Destroy()
	{
	}
}
