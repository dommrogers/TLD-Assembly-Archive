using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting.Plugin.SimpleJson.Reflection;

namespace Unity.Cloud.UserReporting.Plugin.SimpleJson;

public class PocoJsonSerializerStrategy : IJsonSerializerStrategy
{
	internal IDictionary<Type, ReflectionUtils.ConstructorDelegate> ConstructorCache;

	internal IDictionary<Type, IDictionary<string, ReflectionUtils.GetDelegate>> GetCache;

	internal IDictionary<Type, IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>>> SetCache;

	internal static readonly Type[] EmptyTypes;

	internal static readonly Type[] ArrayConstructorParameterTypes;

	private static readonly string[] Iso8601Format;

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(SimpleJson), Member = "get_PocoJsonSerializerStrategy")]
	[CallsUnknownMethods(Count = 43)]
	public PocoJsonSerializerStrategy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected virtual string MapClrMemberNameToJsonFieldName(string clrPropertyName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetContructor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	internal virtual ReflectionUtils.ConstructorDelegate ContructorDelegateFactory(Type key)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 14)]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetGetMethod")]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetGetMethod")]
	[CallsUnknownMethods(Count = 31)]
	internal virtual IDictionary<string, ReflectionUtils.GetDelegate> GetterValueFactory(Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 19)]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetSetMethod")]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetSetMethod")]
	[CallsUnknownMethods(Count = 31)]
	internal virtual IDictionary<string, KeyValuePair<Type, ReflectionUtils.SetDelegate>> SetterValueFactory(Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public virtual bool TrySerializeNonPrimitiveObject(object input, out object output)
	{
		output = null;
		return default(bool);
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(DateTime), Member = "ParseExact")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionUtils), Member = "ToNullableType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsUnknownMethods(Count = 88)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetGenericListElementType")]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsAssignableFrom")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsTypeGenericeCollectionInterface")]
	[Calls(Type = typeof(Type), Member = "get_IsArray")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsTypeDictionary")]
	[Calls(Type = typeof(DateTimeOffset), Member = "ParseExact")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Guid), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType")]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType")]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType")]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType")]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 18)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType")]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Uri), Member = "IsWellFormedUriString")]
	[Calls(Type = typeof(TimeSpan), Member = "Parse")]
	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType")]
	[Calls(Type = typeof(Uri), Member = "TryCreate")]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType")]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsNullableType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public virtual object DeserializeObject(object value, Type type)
	{
		return null;
	}

	[Calls(Type = typeof(Convert), Member = "ToDouble")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual object SerializeEnum(Enum p)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(DateTime), Member = "ToString")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "ConvertTimeToUtc")]
	[Calls(Type = typeof(DateTimeOffset), Member = "ToString")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(TimeZoneInfo), Member = "get_Local")]
	[Calls(Type = typeof(DateTimeOffset), Member = "get_UtcDateTime")]
	[Calls(Type = typeof(TimeSpan), Member = "ToString")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTimeOffset), Member = ".ctor")]
	protected virtual bool TrySerializeKnownTypes(object input, out object output)
	{
		output = null;
		return default(bool);
	}

	[CallsUnknownMethods(Count = 21)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(JsonObject), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	protected virtual bool TrySerializeUnknownTypes(object input, out object output)
	{
		output = null;
		return default(bool);
	}
}
