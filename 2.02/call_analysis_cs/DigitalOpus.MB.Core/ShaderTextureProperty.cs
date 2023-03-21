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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsUnknownMethods(Count = 2)]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MB3_TextureCombinerPipeline._003C__Step3_BuildAndSaveAtlasesAndStoreResults_003Ed__13), Member = "MoveNext")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public static string[] GetNames(List<ShaderTextureProperty> props)
	{
		return null;
	}
}
