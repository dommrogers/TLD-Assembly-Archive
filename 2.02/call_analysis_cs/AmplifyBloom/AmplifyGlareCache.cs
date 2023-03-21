using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace AmplifyBloom;

[Serializable]
public class AmplifyGlareCache
{
	internal AmplifyStarlineCache[] Starlines;

	internal Vector4 AverageWeight;

	internal Vector4[,] CromaticAberrationMat;

	internal int TotalRT;

	internal GlareDefData GlareDef;

	internal StarDefData StarDef;

	internal int CurrentPassCount;

	[CalledBy(Type = typeof(AmplifyGlare), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AmplifyStarlineCache), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 14)]
	public AmplifyGlareCache()
	{
	}

	[CalledBy(Type = typeof(AmplifyGlare), Member = "Destroy")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public void Destroy()
	{
	}
}
