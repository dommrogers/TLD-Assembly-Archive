using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AmplifyBloom;

[Serializable]
public class AmplifyBokehData
{
	internal RenderTexture BokehRenderTexture;

	internal Vector4[] Offsets;

	[DeduplicatedMethod]
	[CallerCount(Count = 71)]
	public AmplifyBokehData(Vector4[] offsets)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(AmplifyUtils), Member = "ReleaseTempRenderTarget")]
	public void Destroy()
	{
	}
}
