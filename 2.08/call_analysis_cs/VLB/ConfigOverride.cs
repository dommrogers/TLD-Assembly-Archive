using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public class ConfigOverride : Config
{
	public const string kAssetName = "VLBConfigOverride";

	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ConfigOverride()
	{
	}
}
