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

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AmplifyStarlineCache), Member = ".ctor")]
	[CalledBy(Type = typeof(AmplifyGlare), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public AmplifyGlareCache()
	{
	}

	[CalledBy(Type = typeof(AmplifyGlare), Member = "Destroy")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	public void Destroy()
	{
	}
}
