using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Serialization.FullSerializer.Internal;
using ParadoxNotion.Serialization.FullSerializer.Internal.DirectConverters;

namespace ParadoxNotion.Serialization.FullSerializer;

public abstract class fsBaseConverter
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<fsDataType, string> _003C_003E9__6_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		internal string _003CFailExpectedType_003Eb__6_0(fsDataType t)
		{
			return null;
		}
	}

	public fsSerializer Serializer;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 30)]
	public virtual object CreateInstance(fsData data, Type storageType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool RequestCycleSupport(Type storageType)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool RequestInheritanceSupport(Type storageType)
	{
		return false;
	}

	public abstract fsResult TrySerialize(object instance, out fsData serialized, Type storageType);

	public abstract fsResult TryDeserialize(fsData data, ref object instance, Type storageType);

	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Select")]
	[Calls(TypeFullName = "System.Linq.Buffer`1", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "JoinCore")]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(TypeFullName = "System.Linq.Error", Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 38)]
	protected fsResult FailExpectedType(fsData data, fsDataType[] types)
	{
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsDirectConverter<>), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TryDeserialize")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(fsData), Member = "get_Type")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 29)]
	protected fsResult CheckType(fsData data, fsDataType type)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsData), Member = "Cast")]
	[Calls(Type = typeof(fsBaseConverter), Member = "CheckKey")]
	[CallsUnknownMethods(Count = 1)]
	protected fsResult CheckKey(fsData data, string key, out fsData subitem)
	{
		subitem = null;
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckKey")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "TryDeserialize")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 21)]
	protected fsResult CheckKey(Dictionary<string, fsData> data, string key, out fsData subitem)
	{
		subitem = null;
		return default(fsResult);
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(AnimationCurve_DirectConverter), Member = "DoSerialize")]
	[CalledBy(Type = typeof(Gradient_DirectConverter), Member = "DoSerialize")]
	[CalledBy(Type = typeof(GUIStyleState_DirectConverter), Member = "DoSerialize")]
	[CalledBy(Type = typeof(GUIStyle_DirectConverter), Member = "DoSerialize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsSerializer), Member = "TrySerialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	protected fsResult SerializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, T value)
	{
		return default(fsResult);
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(AnimationCurve_DirectConverter), Member = "DoDeserialize")]
	[CalledBy(Type = typeof(Bounds_DirectConverter), Member = "DoDeserialize")]
	[CalledBy(Type = typeof(Gradient_DirectConverter), Member = "DoDeserialize")]
	[CalledBy(Type = typeof(GUIStyleState_DirectConverter), Member = "DoDeserialize")]
	[CalledBy(Type = typeof(GUIStyle_DirectConverter), Member = "DoDeserialize")]
	[CalledBy(Type = typeof(Keyframe_DirectConverter), Member = "DoDeserialize")]
	[CalledBy(Type = typeof(LayerMask_DirectConverter), Member = "DoDeserialize")]
	[CalledBy(Type = typeof(RectOffset_DirectConverter), Member = "DoDeserialize")]
	[CalledBy(Type = typeof(Rect_DirectConverter), Member = "DoDeserialize")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(fsResult), Member = "Fail")]
	[CallsUnknownMethods(Count = 3)]
	protected fsResult DeserializeMember<T>(Dictionary<string, fsData> data, Type overrideConverterType, string name, out T value)
	{
		value = default(T);
		return default(fsResult);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected fsBaseConverter()
	{
	}
}
