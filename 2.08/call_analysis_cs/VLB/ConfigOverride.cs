using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public class ConfigOverride : Config
{
	public const string kAssetName = "VLBConfigOverride";

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ConfigOverride()
	{
	}
}
