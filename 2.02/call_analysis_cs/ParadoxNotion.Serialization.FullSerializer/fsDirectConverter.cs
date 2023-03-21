using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public abstract class fsDirectConverter : fsBaseConverter
{
	public abstract Type ModelType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
	}

	[CallerCount(Count = 2)]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 19)]
	public sealed override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckType")]
	public sealed override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract fsResult DoSerialize(TModel model, Dictionary<string, fsData> serialized);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract fsResult DoDeserialize(Dictionary<string, fsData> data, ref TModel model);

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	protected fsDirectConverter()
	{
	}
}
