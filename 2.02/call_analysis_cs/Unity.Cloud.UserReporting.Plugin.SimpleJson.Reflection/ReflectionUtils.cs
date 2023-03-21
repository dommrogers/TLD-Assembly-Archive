using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected.CallAnalysis;

namespace Unity.Cloud.UserReporting.Plugin.SimpleJson.Reflection;

internal class ReflectionUtils
{
	public delegate object GetDelegate(object source);

	public delegate void SetDelegate(object source, object value);

	public delegate object ConstructorDelegate(object[] args);

	public delegate TValue ThreadSafeDictionaryValueFactory<TKey, TValue>(TKey key);

	public sealed class ThreadSafeDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
	{
		private Dictionary<TKey, TValue> _dictionary;

		private readonly object _lock;

		private readonly ThreadSafeDictionaryValueFactory<TKey, TValue> _valueFactory;

		public int Count
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return default(int);
			}
		}

		public bool IsReadOnly
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
			[CallsUnknownMethods(Count = 3)]
			get
			{
				return default(bool);
			}
		}

		public TValue Item
		{
			[CallsUnknownMethods(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return (TValue)null;
			}
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
			[CallsUnknownMethods(Count = 3)]
			set
			{
			}
		}

		public ICollection<TKey> Keys
		{
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			get
			{
				return null;
			}
		}

		public ICollection<TValue> Values
		{
			[CallsUnknownMethods(Count = 1)]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			get
			{
				return null;
			}
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 7)]
		public ThreadSafeDictionary(ThreadSafeDictionaryValueFactory<TKey, TValue> valueFactory)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		public void Add(TKey key, TValue value)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		public void Add(KeyValuePair<TKey, TValue> item)
		{
		}

		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 23)]
		[Calls(Type = typeof(Monitor), Member = "ReliableEnterTimeout")]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private TValue AddValue(TKey key)
		{
			return (TValue)null;
		}

		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		public void Clear()
		{
		}

		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		[CallsDeduplicatedMethods(Count = 3)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		private TValue Get(TKey key)
		{
			return (TValue)null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallsUnknownMethods(Count = 3)]
		public bool Remove(TKey key)
		{
			return default(bool);
		}

		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return default(bool);
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public bool TryGetValue(TKey key, out TValue value)
		{
			System.Runtime.CompilerServices.Unsafe.As<TValue, @null>(ref value) = null;
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public ConstructorInfo constructorInfo;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ConstructorInfo), Member = "Invoke")]
		[CallsUnknownMethods(Count = 1)]
		internal object _003CGetConstructorByReflection_003Eb__0(object[] args)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public MethodInfo methodInfo;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass29_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		internal object _003CGetGetMethodByReflection_003Eb__0(object source)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public FieldInfo fieldInfo;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass30_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal object _003CGetGetMethodByReflection_003Eb__0(object source)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public MethodInfo methodInfo;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass33_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 6)]
		internal void _003CGetSetMethodByReflection_003Eb__0(object source, object value)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public FieldInfo fieldInfo;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass34_0()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal void _003CGetSetMethodByReflection_003Eb__0(object source, object value)
		{
		}
	}

	private static readonly object[] EmptyObjects;

	[DeduplicatedMethod]
	[CallerCount(Count = 1949)]
	public static Type GetTypeInfo(Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Attribute), Member = "IsDefined")]
	[Calls(Type = typeof(Attribute), Member = "GetCustomAttribute")]
	public static Attribute GetAttribute(MemberInfo info, Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 16)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsTypeGeneric")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "DeserializeObject")]
	public static Type GetGenericListElementType(Type type)
	{
		return null;
	}

	[Calls(Type = typeof(Attribute), Member = "GetCustomAttribute")]
	[Calls(Type = typeof(Attribute), Member = "IsDefined")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static Attribute GetAttribute(Type objectType, Type attributeType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Type[] GetGenericTypeArguments(Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetGenericListElementType")]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "IsTypeGenericeCollectionInterface")]
	public static bool IsTypeGeneric(Type type)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "DeserializeObject")]
	[Calls(Type = typeof(ReflectionUtils), Member = "IsTypeGeneric")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static bool IsTypeGenericeCollectionInterface(Type type)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SimpleJson), Member = "DeserializeObject")]
	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsAssignableFrom(Type type1, Type type2)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "DeserializeObject")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public static bool IsTypeDictionary(Type type)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "DeserializeObject")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "DeserializeObject")]
	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "DeserializeObject")]
	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "DeserializeObject")]
	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "DeserializeObject")]
	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "DeserializeObject")]
	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "DeserializeObject")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsNullableType(Type type)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Convert), Member = "ChangeType")]
	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "DeserializeObject")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Nullable), Member = "GetUnderlyingType")]
	[CallerCount(Count = 1)]
	public static object ToNullableType(object obj, Type nullableType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsValueType(Type type)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<ConstructorInfo> GetConstructors(Type type)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetConstructorByReflection")]
	[CallsUnknownMethods(Count = 17)]
	public static ConstructorInfo GetConstructorInfo(Type type, Type[] argsType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static IEnumerable<PropertyInfo> GetProperties(Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static IEnumerable<FieldInfo> GetFields(Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static MethodInfo GetGetterMethodInfo(PropertyInfo propertyInfo)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static MethodInfo GetSetterMethodInfo(PropertyInfo propertyInfo)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetConstructorByReflection")]
	public static ConstructorDelegate GetContructor(ConstructorInfo constructorInfo)
	{
		return null;
	}

	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "ContructorDelegateFactory")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	public static ConstructorDelegate GetContructor(Type type, Type[] argsType)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetContructor")]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetConstructorByReflection")]
	[CallsUnknownMethods(Count = 15)]
	public static ConstructorDelegate GetConstructorByReflection(ConstructorInfo constructorInfo)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetConstructorInfo")]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetConstructorByReflection")]
	public static ConstructorDelegate GetConstructorByReflection(Type type, Type[] argsType)
	{
		return null;
	}

	[Calls(Type = typeof(ReflectionUtils), Member = "GetGetMethodByReflection")]
	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "GetterValueFactory")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static GetDelegate GetGetMethod(PropertyInfo propertyInfo)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetGetMethodByReflection")]
	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "GetterValueFactory")]
	public static GetDelegate GetGetMethod(FieldInfo fieldInfo)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetGetMethod")]
	[CallsUnknownMethods(Count = 16)]
	public static GetDelegate GetGetMethodByReflection(PropertyInfo propertyInfo)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetGetMethod")]
	[CallsUnknownMethods(Count = 15)]
	public static GetDelegate GetGetMethodByReflection(FieldInfo fieldInfo)
	{
		return null;
	}

	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "SetterValueFactory")]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetSetMethodByReflection")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SetDelegate GetSetMethod(PropertyInfo propertyInfo)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReflectionUtils), Member = "GetSetMethodByReflection")]
	[CalledBy(Type = typeof(PocoJsonSerializerStrategy), Member = "SetterValueFactory")]
	public static SetDelegate GetSetMethod(FieldInfo fieldInfo)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetSetMethod")]
	[CallsUnknownMethods(Count = 16)]
	public static SetDelegate GetSetMethodByReflection(PropertyInfo propertyInfo)
	{
		return null;
	}

	[CalledBy(Type = typeof(ReflectionUtils), Member = "GetSetMethod")]
	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static SetDelegate GetSetMethodByReflection(FieldInfo fieldInfo)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public ReflectionUtils()
	{
	}
}
