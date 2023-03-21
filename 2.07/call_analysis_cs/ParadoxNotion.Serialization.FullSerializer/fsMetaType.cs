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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Array), Member = "CreateInstance")]
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

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
		[CallerCount(Count = 79)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	public fsMetaProperty[] Properties
	{
		[CallerCount(Count = 27)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CompilerGenerated]
		[CallerCount(Count = 55)]
		private set
		{
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "CreateInstance")]
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
	[CallsUnknownMethods(Count = 1)]
	public static void ClearCache()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(fsMetaType), Member = "CollectProperties")]
	[CalledBy(Type = typeof(fsMetaType), Member = "Get")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(fsMetaType), Member = "GetGenerator")]
	private fsMetaType(fsConfig config, Type reflectedType)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(fsMetaType), Member = "CanSerializeField")]
	[Calls(Type = typeof(fsMetaProperty), Member = ".ctor")]
	[CalledBy(Type = typeof(fsMetaType), Member = ".ctor")]
	[CallsUnknownMethods(Count = 4)]
	private static void CollectProperties(fsConfig config, List<fsMetaProperty> properties, Type reflectedType)
	{
	}

	[CalledBy(Type = typeof(fsMetaType), Member = "CollectProperties")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static bool CanSerializeField(fsConfig config, FieldInfo field)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsMetaType), Member = "HasDefaultConstructor")]
	[CalledBy(Type = typeof(fsMetaType), Member = ".ctor")]
	[CallsUnknownMethods(Count = 2)]
	private static ObjectGenerator GetGenerator(Type reflectedType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(fsMetaType), Member = "GetGenerator")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetConstructors")]
	private static bool HasDefaultConstructor(Type reflectedType)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 38)]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsDictionaryConverter), Member = "CreateInstance")]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "CreateInstance")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Exception), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor")]
	public object CreateInstance()
	{
		return null;
	}
}
