using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace DigitalOpus.MB.Core;

[Serializable]
public class ShaderTextureProperty
{
	public string name;

	public bool isNormalMap;

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ShaderTextureProperty(string n, bool norm)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public override bool Equals(object obj)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override int GetHashCode()
	{
		return 0;
	}

	[CalledBy(TypeFullName = "DigitalOpus.MB.Core.MB3_TextureCombinerPipeline.<__Step3_BuildAndSaveAtlasesAndStoreResults>d__13", Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static string[] GetNames(List<ShaderTextureProperty> props)
	{
		return null;
	}
}
