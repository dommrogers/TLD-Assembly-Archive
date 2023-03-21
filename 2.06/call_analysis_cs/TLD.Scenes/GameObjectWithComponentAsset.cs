using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace TLD.Scenes;

internal class GameObjectWithComponentAsset : AssetReferenceUIRestriction
{
	private Type _003CComponentType_003Ek__BackingField;

	private Type ComponentType
	{
		[CallerCount(Count = 98)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 265)]
		set
		{
		}
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public GameObjectWithComponentAsset(Type type)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public override bool ValidateAsset(UnityEngine.Object obj)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool ValidateAsset(string path)
	{
		return default(bool);
	}
}
