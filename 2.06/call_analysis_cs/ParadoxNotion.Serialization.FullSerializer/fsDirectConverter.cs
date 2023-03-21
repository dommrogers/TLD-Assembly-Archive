using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public abstract class fsDirectConverter : fsBaseConverter
{
	public abstract Type ModelType
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	protected fsDirectConverter()
	{
	}
}
public abstract class fsDirectConverter<TModel> : fsDirectConverter
{
	public override Type ModelType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 13)]
	public sealed override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public sealed override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract fsResult DoSerialize(TModel model, Dictionary<string, fsData> serialized);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract fsResult DoDeserialize(Dictionary<string, fsData> data, ref TModel model);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected fsDirectConverter()
	{
	}
}
