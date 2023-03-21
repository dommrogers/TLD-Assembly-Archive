using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public class ConfigOverride : Config
{
	public const string kAssetName = "VLBConfigOverride";

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public ConfigOverride()
	{
	}
}
