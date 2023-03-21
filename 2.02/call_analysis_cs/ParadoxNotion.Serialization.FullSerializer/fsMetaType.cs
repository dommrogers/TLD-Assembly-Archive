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

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CCanSerializeField_003Eb__0(Type t)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public Type reflectedType;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(Exception), Member = ".ctor")]
		internal object _003CGetGenerator_003Eb__0()
		{
			return null;
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		internal object _003CGetGenerator_003Eb__1()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Array), Member = "CreateInstance")]
		[CallsUnknownMethods(Count = 1)]
		internal object _003CGetGenerator_003Eb__2()
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		[CompilerGenerated]
		private set
		{
		}
	}

	public fsMetaProperty[] Properties
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 41)]
		private set
		{
		}
	}

	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsListConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "GetProperty")]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "CreateInstance")]
	[Calls(Type = typeof(fsMetaType), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 8)]
	public static fsMetaType Get(fsConfig config, Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public static void ClearCache()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(fsMetaType), Member = "GetGenerator")]
	[Calls(Type = typeof(fsMetaType), Member = "CollectProperties")]
	[CalledBy(Type = typeof(fsMetaType), Member = "Get")]
	[CallsUnknownMethods(Count = 8)]
	private fsMetaType(fsConfig config, Type reflectedType)
	{
	}

	[CalledBy(Type = typeof(fsMetaType), Member = ".ctor")]
	[CallsUnknownMethods(Count = 28)]
	[Calls(Type = typeof(fsMetaProperty), Member = ".ctor")]
	[Calls(Type = typeof(fsMetaType), Member = "CanSerializeField")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, Type reflectedType)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(fsMetaType), Member = "CollectProperties")]
	[CallsUnknownMethods(Count = 22)]
	private static bool CanSerializeField(fsConfig config, FieldInfo field)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 54)]
	[Calls(Type = typeof(fsMetaType), Member = "HasDefaultConstructor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(fsMetaType), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	private static ObjectGenerator GetGenerator(Type reflectedType)
	{
		return null;
	}

	[CalledBy(Type = typeof(fsMetaType), Member = "GetGenerator")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetConstructors")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	private static bool HasDefaultConstructor(Type reflectedType)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(fsArrayConverter), Member = "CreateInstance")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "CreateInstance")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public object CreateInstance()
	{
		return null;
	}
}
