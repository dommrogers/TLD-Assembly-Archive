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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 80)]
		get
		{
			return null;
		}
		[CallerCount(Count = 279)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor")]
	[CallsUnknownMethods(Count = 5)]
	public GameObjectWithComponentAsset(Type type)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(GameObject), Member = "TryGetComponent")]
	public override bool ValidateAsset(UnityEngine.Object obj)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool ValidateAsset(string path)
	{
		return default(bool);
	}
}
