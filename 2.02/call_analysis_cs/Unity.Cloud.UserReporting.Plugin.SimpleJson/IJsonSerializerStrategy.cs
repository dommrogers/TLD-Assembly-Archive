using System;

namespace Unity.Cloud.UserReporting.Plugin.SimpleJson;

public interface IJsonSerializerStrategy
{
	bool TrySerializeNonPrimitiveObject(object input, out object output);

	object DeserializeObject(object value, Type type);
}
