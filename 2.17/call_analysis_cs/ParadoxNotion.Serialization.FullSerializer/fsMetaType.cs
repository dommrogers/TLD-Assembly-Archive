using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Serialization.FullSerializer.Internal;

namespace ParadoxNotion.Serialization.FullSerializer;

public class fsMetaType
{
	private delegate object ObjectGenerator();

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public FieldInfo field;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CCollectProperties_003Eb__0(Type t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public FieldInfo field;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CCanSerializeField_003Eb__0(Type t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public Type reflectedType;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Exception), Member = ".ctor")]
		[CallsUnknownMethods(Count = 8)]
		internal object _003CGetGenerator_003Eb__0()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal object _003CGetGenerator_003Eb__1()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Array), Member = "CreateInstance")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal object _003CGetGenerator_003Eb__2()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(FormatterServices), Member = "GetSafeUninitializedObject")]
		internal object _003CGetGenerator_003Eb__4()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Activator), Member = "CreateInstance")]
		internal object _003CGetGenerator_003Eb__5()
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static ObjectGenerator _003C_003E9__16_3;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		internal object _003CGetGenerator_003Eb__16_3()
		{
			return null;
		}
	}

	private static Dictionary<fsConfig, Dictionary<Type, fsMetaType>> _configMetaTypes;

	private ObjectGenerator generator;

	private Type _003CreflectedType_003Ek__BackingField;

	private fsMetaProperty[] _003CProperties_003Ek__BackingField;

	public Type reflectedType
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 86)]
		private set
		{
		}
	}

	public fsMetaProperty[] Properties
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 57)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(fsArrayConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "GetProperty")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsListConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "CreateInstance")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(fsMetaType), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static fsMetaType Get(fsConfig config, Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void ClearCache()
	{
	}

	[CalledBy(Type = typeof(fsMetaType), Member = "Get")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsMetaType), Member = "GetGenerator")]
	[Calls(Type = typeof(fsMetaType), Member = "CollectProperties")]
	[Calls(Type = typeof(List<>), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private fsMetaType(fsConfig config, Type reflectedType)
	{
	}

	[CalledBy(Type = typeof(fsMetaType), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Any")]
	[Calls(Type = typeof(fsMetaType), Member = "CanSerializeField")]
	[Calls(Type = typeof(fsMetaProperty), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 3)]
	private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, Type reflectedType)
	{
	}

	[CalledBy(Type = typeof(fsMetaType), Member = "CollectProperties")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Enumerable), Member = "Any")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	private static bool CanSerializeField(fsConfig config, FieldInfo field)
	{
		return false;
	}

	[CalledBy(Type = typeof(fsMetaType), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsMetaType), Member = "HasDefaultConstructor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	private static ObjectGenerator GetGenerator(Type reflectedType)
	{
		return null;
	}

	[CalledBy(Type = typeof(fsMetaType), Member = "GetGenerator")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetConstructors")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static bool HasDefaultConstructor(Type reflectedType)
	{
		return false;
	}

	[CalledBy(Type = typeof(fsArrayConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsListConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "CreateInstance")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 38)]
	public object CreateInstance()
	{
		return null;
	}
}
