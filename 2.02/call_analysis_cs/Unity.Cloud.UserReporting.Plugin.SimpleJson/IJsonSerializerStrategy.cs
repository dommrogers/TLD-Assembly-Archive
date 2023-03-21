using System;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud.UserReporting.Plugin.SimpleJson;

public interface IJsonSerializerStrategy
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	bool TrySerializeNonPrimitiveObject(object input, out object output);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	object DeserializeObject(object value, Type type);
}
