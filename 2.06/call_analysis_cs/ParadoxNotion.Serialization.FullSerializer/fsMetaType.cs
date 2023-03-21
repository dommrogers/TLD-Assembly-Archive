using System;
using System.Collections.Generic;
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
			return default(bool);
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

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		internal bool _003CCanSerializeField_003Eb__0(Type t)
		{
			return default(bool);
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

		[Calls(Type = typeof(Array), Member = "CreateInstance")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallerCount(Count = 44)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 85)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public fsMetaProperty[] Properties
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 51)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(fsReflectedConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "CreateInstance")]
	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "CreateInstance")]
	[Calls(Type = typeof(fsMetaType), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "GetProperty")]
	public static fsMetaType Get(fsConfig config, Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static void ClearCache()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(fsMetaType), Member = "GetGenerator")]
	[Calls(Type = typeof(fsMetaType), Member = "CollectProperties")]
	[CalledBy(Type = typeof(fsMetaType), Member = "Get")]
	[CallsUnknownMethods(Count = 6)]
	private fsMetaType(fsConfig config, Type reflectedType)
	{
	}

	[CallsUnknownMethods(Count = 17)]
	[CalledBy(Type = typeof(fsMetaType), Member = ".ctor")]
	[Calls(Type = typeof(fsMetaProperty), Member = ".ctor")]
	[Calls(Type = typeof(fsMetaType), Member = "CanSerializeField")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, Type reflectedType)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(fsMetaType), Member = "CollectProperties")]
	[CallsUnknownMethods(Count = 12)]
	private static bool CanSerializeField(fsConfig config, FieldInfo field)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 36)]
	[Calls(Type = typeof(fsMetaType), Member = "HasDefaultConstructor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(fsMetaType), Member = ".ctor")]
	private static ObjectGenerator GetGenerator(Type reflectedType)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetConstructors")]
	[CalledBy(Type = typeof(fsMetaType), Member = "GetGenerator")]
	[CallsUnknownMethods(Count = 2)]
	private static bool HasDefaultConstructor(Type reflectedType)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsListConverter), Member = "CreateInstance")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "CreateInstance")]
	[CallsUnknownMethods(Count = 35)]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public object CreateInstance()
	{
		return null;
	}
}
