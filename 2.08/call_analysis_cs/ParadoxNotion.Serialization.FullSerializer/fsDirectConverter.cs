using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public abstract class fsDirectConverter : fsBaseConverter
{
	public abstract Type ModelType { get; }

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
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
	[CallsUnknownMethods(Count = 3)]
	public sealed override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
	{
		serialized = null;
		return default(fsResult);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[Calls(Type = typeof(fsData), Member = "Cast")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public sealed override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
	{
		return default(fsResult);
	}

	protected abstract fsResult DoSerialize(TModel model, Dictionary<string, fsData> serialized);

	protected abstract fsResult DoDeserialize(Dictionary<string, fsData> data, ref TModel model);

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected fsDirectConverter()
	{
	}
}
