using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.StateMachines;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using ParadoxNotion.Serialization;
using ParadoxNotion.Serialization.FullSerializer;
using ParadoxNotion.Serialization.FullSerializer.Internal;
using ParadoxNotion.Services;

namespace ParadoxNotion;

public static class ReflectionTools
{
	public enum MethodType
	{
		Normal,
		PropertyAccessor,
		Event,
		Operator
	}

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public string typeName;

		public Func<string, bool> _003C_003E9__0;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		internal bool _003CTryResolveDeserializeFromAttribute_003Eb__0(string n)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public bool includeObsolete;

		public Func<Type, bool> _003C_003E9__2;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		internal bool _003CGetAllTypes_003Eb__2(Type t)
		{
			return default(bool);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Type, string> _003C_003E9__14_0;

		public static Func<Type, string> _003C_003E9__14_1;

		public static Func<ParameterInfo, Type> _003C_003E9__83_0;

		public static Func<ParameterInfo, Type> _003C_003E9__90_0;

		public static Func<ConstructorInfo, bool> _003C_003E9__105_0;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		internal string _003CGetAllTypes_003Eb__14_0(Type t)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal string _003CGetAllTypes_003Eb__14_1(Type t)
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal Type _003CRTCreateDelegate_003Eb__83_0(ParameterInfo p)
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal Type _003CGetBaseDefinition_003Eb__90_0(ParameterInfo p)
		{
			return null;
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		internal bool _003CIsAllowedByGenericArgument_003Eb__105_0(ConstructorInfo info)
		{
			return default(bool);
		}
	}

	public const BindingFlags FLAGS_ALL = (BindingFlags)124;

	public const BindingFlags FLAGS_ALL_DECLARED = (BindingFlags)62;

	private static Assembly[] _loadedAssemblies;

	private static Dictionary<string, Type> typeMap;

	private static Type[] _allTypes;

	private static Dictionary<Type, Type[]> _subTypesMap;

	private static object[] _tempArgs;

	public static readonly Dictionary<string, string> op_FriendlyNamesLong;

	public static readonly Dictionary<string, string> op_FriendlyNamesShort;

	public static readonly Dictionary<string, string> op_CSharpAliases;

	public const string METHOD_SPECIAL_NAME_GET = "get_";

	public const string METHOD_SPECIAL_NAME_SET = "set_";

	public const string METHOD_SPECIAL_NAME_ADD = "add_";

	public const string METHOD_SPECIAL_NAME_REMOVE = "remove_";

	public const string METHOD_SPECIAL_NAME_OP = "op_";

	private static Dictionary<MethodBase, string> cacheSignatures;

	private static Dictionary<Type, ConstructorInfo[]> _typeConstructors;

	private static Dictionary<Type, MethodInfo[]> _typeMethods;

	private static Dictionary<Type, FieldInfo[]> _typeFields;

	private static Dictionary<Type, PropertyInfo[]> _typeProperties;

	private static Dictionary<Type, EventInfo[]> _typeEvents;

	private static Dictionary<Type, object[]> _typeAttributes;

	private static Dictionary<MemberInfo, object[]> _memberAttributes;

	private static Dictionary<Type, MethodInfo[]> _typeExtensions;

	private static Assembly[] loadedAssemblies
	{
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(ReflectionTools), Member = "GetTypeDirect")]
		[CalledBy(Type = typeof(ReflectionTools), Member = "GetTypeDirect")]
		[CalledBy(Type = typeof(ReflectionTools), Member = "GetAllTypes")]
		[CalledBy(Type = typeof(ReflectionTools), Member = "GetAllTypes")]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "TryResolveGenericType")]
	public static Type GetType(string typeFullName)
	{
		return null;
	}

	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
	[CallerCount(Count = 3)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
	public static Type GetType(string typeFullName, Type fallbackAssignable)
	{
		return null;
	}

	[CalledBy(Type = typeof(SerializedConstructorInfo), Member = "OnAfterDeserialize")]
	[CalledBy(Type = typeof(SerializedTypeInfo), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CalledBy(Type = typeof(SerializedMethodInfo._003C_003Ec), Member = "<OnAfterDeserialize>b__6_3")]
	[CalledBy(Type = typeof(SerializedMethodInfo._003C_003Ec), Member = "<OnAfterDeserialize>b__6_0")]
	[CalledBy(Type = typeof(SerializedMethodInfo), Member = "OnAfterDeserialize")]
	[CalledBy(Type = typeof(SerializedMethodInfo), Member = "OnAfterDeserialize")]
	[CalledBy(Type = typeof(SerializedFieldInfo), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CalledBy(Type = typeof(SerializedEventInfo), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CalledBy(Type = typeof(SerializedConstructorInfo._003C_003Ec), Member = "<OnAfterDeserialize>b__5_0")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "TryResolveGenericType")]
	[CalledBy(Type = typeof(fsTypeConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(Variable<>), Member = "InitializePropertyBinding")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ReflectionTools), Member = "TryResolveWithoutNamespace")]
	[Calls(Type = typeof(ReflectionTools), Member = "TryResolveDeserializeFromAttribute")]
	[Calls(Type = typeof(ReflectionTools), Member = "TryResolveGenericType")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetTypeDirect")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetType")]
	[CallsUnknownMethods(Count = 10)]
	public static Type GetType(string typeFullName, bool fallbackNoNamespace = false, Type fallbackAssignable = null)
	{
		return null;
	}

	[Calls(Type = typeof(ReflectionTools), Member = "get_loadedAssemblies")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ReflectionTools), Member = "get_loadedAssemblies")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(Type), Member = "GetType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetType")]
	private static Type GetTypeDirect(string typeFullName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 34)]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(Logger), Member = "LogException")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	private static Type TryResolveGenericType(string typeFullName, bool fallbackNoNamespace = false, Type fallbackAssignable = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 18)]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetAllTypes")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	private static Type TryResolveDeserializeFromAttribute(string typeName)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetAllTypes")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetType")]
	[CallsUnknownMethods(Count = 22)]
	private static Type TryResolveWithoutNamespace(string typeName, Type fallbackAssignable = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 62)]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetExtensionMethods")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetImplementationsOf")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "TryResolveWithoutNamespace")]
	[Calls(Type = typeof(ReflectionTools), Member = "get_loadedAssemblies")]
	[Calls(Type = typeof(ReflectionTools), Member = "get_loadedAssemblies")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(ReflectionTools), Member = "TryResolveDeserializeFromAttribute")]
	public static Type[] GetAllTypes(bool includeObsolete)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(ReflectionTools), Member = "GetAllTypes")]
	[CalledBy(Type = typeof(fsSerializer), Member = ".cctor")]
	[CallsUnknownMethods(Count = 16)]
	public static Type[] GetImplementationsOf(Type baseType)
	{
		return null;
	}

	[CalledBy(Type = typeof(SetProperty_Multiplatform), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CalledBy(Type = typeof(FSM._003C_003Ec__DisplayClass50_0), Member = "<GatherDelegates>b__2")]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(FSM._003C_003Ec__DisplayClass50_0), Member = "<GatherDelegates>b__0")]
	[CalledBy(Type = typeof(Variable<>._003C_003Ec__DisplayClass22_1), Member = "<InitializePropertyBinding>b__2")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(FSM._003C_003Ec__DisplayClass50_0), Member = "<GatherDelegates>b__1")]
	public static object[] SingleTempArgsArray(object arg)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	public static MethodType GetMethodSpecialType(this MethodBase method)
	{
		return default(MethodType);
	}

	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 35)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string FriendlyName(this Type t, bool compileSafe = false)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Node), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	public static string FriendlyName(this MemberInfo info)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	public static string FriendlyName(this MethodBase method)
	{
		return null;
	}

	[Calls(Type = typeof(StringUtils), Member = "CapitalizeFirst")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "SignatureName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StringUtils), Member = "CapitalizeFirst")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	public static string FriendlyName(this MethodBase method, out MethodType specialNameType)
	{
		System.Runtime.CompilerServices.Unsafe.As<MethodType, @null>(ref specialNameType) = null;
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReflectionTools), Member = "IsParams")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsUnknownMethods(Count = 10)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	public static string SignatureName(this MethodBase method)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 31)]
	public static Type RTReflectedOrDeclaredType(this MemberInfo member)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsAssignableFrom(this Type type, Type other)
	{
		return default(bool);
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetAttribute")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetAttribute")]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsAssignableTo(this Type type, Type other)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static bool RTIsAbstract(this Type type)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsValueType(this Type type)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsArray(this Type type)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface")]
	[DeduplicatedMethod]
	public static bool RTIsInterface(this Type type)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsSubclassOf(this Type type, Type other)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsGenericParameter(this Type type)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsGenericType(this Type type)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public static MethodInfo RTGetGetMethod(this PropertyInfo prop)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static MethodInfo RTGetSetMethod(this PropertyInfo prop)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static MethodInfo RTGetDelegateMethodInfo(this Delegate del)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static Type RTMakeGenericType(this Type type, Type[] typeArgs)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Type[] RTGetGenericArguments(this Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Type[] RTGetEmptyTypes()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static Type RTGetElementType(this Type type)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static bool RTIsByRef(this Type type)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static object CreateObject(this Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(FormatterServices), Member = "GetUninitializedObject")]
	public static object CreateObjectUninitialized(this Type type)
	{
		return null;
	}

	[Calls(Type = typeof(ReflectionTools), Member = "RTGetConstructors")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static ConstructorInfo RTGetDefaultConstructor(this Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetConstructors")]
	[CalledBy(Type = typeof(SerializedConstructorInfo), Member = "OnAfterDeserialize")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static ConstructorInfo RTGetConstructor(this Type type, Type[] paramTypes)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethods")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CalledBy(Type = typeof(CheckCSharpEvent), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckCSharpEvent<>), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckCSharpEventValue<>), Member = "OnInit")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetDelegateTypeParameters")]
	[CallsUnknownMethods(Count = 6)]
	public static MethodInfo RTGetMethod(this Type type, string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SerializedMethodInfo), Member = "OnAfterDeserialize")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTCreateDelegate")]
	[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
	[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethods")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
	public static MethodInfo RTGetMethod(this Type type, string name, Type[] paramTypes)
	{
		return null;
	}

	[CalledBy(Type = typeof(CheckUnityEventValue<>), Member = "OnInit")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(SerializedFieldInfo), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "IsAutoProperty")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetBaseDefinition")]
	[CalledBy(Type = typeof(SetField), Member = "OnInit")]
	[CalledBy(Type = typeof(GetField), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckUnityEvent<>), Member = "OnInit")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetFields")]
	[CalledBy(Type = typeof(CheckField), Member = "OnInit")]
	[CalledBy(Type = typeof(Variable<>), Member = "InitializePropertyBinding")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(CheckUnityEvent), Member = "OnInit")]
	public static FieldInfo RTGetField(this Type type, string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetAccessorProperty")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "IsObsolete")]
	[CalledBy(Type = typeof(Variable<>), Member = "InitializePropertyBinding")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public static PropertyInfo RTGetProperty(this Type type, string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(CheckCSharpEventValue<>), Member = "OnInit")]
	[CalledBy(Type = typeof(SerializedEventInfo), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CalledBy(Type = typeof(CheckStaticCSharpEvent<>), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckStaticCSharpEvent), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckCSharpEvent<>), Member = "OnInit")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(CheckCSharpEvent), Member = "OnInit")]
	public static EventInfo RTGetEvent(this Type type, string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(fsMetaType), Member = "HasDefaultConstructor")]
	[CalledBy(Type = typeof(SerializedConstructorInfo), Member = "OnAfterDeserialize")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "IsAllowedByGenericArgument")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetDefaultConstructor")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetConstructor")]
	public static ConstructorInfo[] RTGetConstructors(this Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(SerializedMethodInfo), Member = "OnAfterDeserialize")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetExtensionMethods")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[CalledBy(Type = typeof(SerializedMethodInfo), Member = "OnAfterDeserialize")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	public static MethodInfo[] RTGetMethods(this Type type)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Task), Member = "InitializeAttributes")]
	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[CalledBy(Type = typeof(BBParameter), Member = "GetObjectBBParameters")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetField")]
	[CallsUnknownMethods(Count = 3)]
	public static FieldInfo[] RTGetFields(this Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public static PropertyInfo[] RTGetProperties(this Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	public static EventInfo[] RTGetEvents(this Type type)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsDefined<T>(this Type type, bool inherited) where T : Attribute
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public static bool RTIsDefined(this Type type, Type attributeType, bool inherited)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsDefined<T>(this MemberInfo member, bool inherited) where T : Attribute
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsDefined(this MemberInfo member, Type attributeType, bool inherited)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTIsAssignableTo")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[DeduplicatedMethod]
	[CallerCount(Count = 11)]
	public static T RTGetAttribute<T>(this Type type, bool inherited) where T : Attribute
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTIsAssignableTo")]
	[CallsUnknownMethods(Count = 12)]
	public static T RTGetAttribute<T>(this MemberInfo member, bool inherited) where T : Attribute
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 10)]
	public static T[] RTGetAttributesRecursive<T>(this Type type) where T : Attribute
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static ParameterInfo[] RTGetDelegateTypeParameters(this Type delegateType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTCreateDelegate")]
	public static T RTCreateDelegate<T>(this MethodInfo method, object instance)
	{
		return (T)null;
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "RTCreateDelegate")]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(CheckCSharpEventValue<>), Member = "OnInit")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(CheckCSharpEvent<>), Member = "OnInit")]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CalledBy(Type = typeof(CheckCSharpEvent), Member = "OnInit")]
	public static Delegate RTCreateDelegate(this MethodInfo method, Type type, object instance)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate")]
	[CallsUnknownMethods(Count = 1)]
	public static Delegate ConvertDelegate(Delegate originalDelegate, Type targetDelegateType)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool IsReadOnly(this FieldInfo field)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(Variable<>), Member = "InitializePropertyBinding")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsConstant(this FieldInfo field)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsStatic(this EventInfo info)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "SignatureName")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static bool IsParams(this ParameterInfo parameter, ParameterInfo[] parameters)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ReflectionTools), Member = "IsPropertyAccessor")]
	[Calls(Type = typeof(ReflectionTools), Member = "IsPropertyAccessor")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetProperty")]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsObsolete(this MemberInfo member, bool inherited = true)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(Type), Member = "GetProperty")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	public static PropertyInfo GetBaseDefinition(this PropertyInfo propertyInfo)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetField")]
	[CallsUnknownMethods(Count = 1)]
	public static FieldInfo GetBaseDefinition(this FieldInfo fieldInfo)
	{
		return null;
	}

	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethods")]
	[Calls(Type = typeof(ReflectionTools), Member = "IsExtensionMethod")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetAllTypes")]
	[CallsUnknownMethods(Count = 24)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 12)]
	public static MethodInfo[] GetExtensionMethods(this Type targetType)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetExtensionMethods")]
	public static bool IsExtensionMethod(this MethodInfo method)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetAccessorProperty")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "IsObsolete")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "IsObsolete")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	public static bool IsPropertyAccessor(this MethodInfo method)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool IsIndexerProperty(this PropertyInfo property)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetField")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsAutoProperty(this PropertyInfo property)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetProperty")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	[Calls(Type = typeof(ReflectionTools), Member = "IsPropertyAccessor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public static PropertyInfo GetAccessorProperty(this MethodInfo method)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsEnumerableCollection(this Type type)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 2)]
	public static Type GetEnumerableElementType(this Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	public static Type GetFirstGenericParameterConstraintType(this Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 2)]
	public static Type GetFirstGenericParameterConstraintType(this MethodInfo method)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(ReflectionTools), Member = "IsAllowedByGenericArgument")]
	public static bool CanBeMadeGenericWith(this Type def, Type type)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static bool CanBeMadeGenericWith(this MethodInfo def, Type type)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetConstructors")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "CanBeMadeGenericWith")]
	[CallsUnknownMethods(Count = 12)]
	public static bool IsAllowedByGenericArgument(this Type type, Type genericArgument)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "CreateInstance")]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static Array Resize(this Array array, int newSize)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Expression), Member = "Parameter")]
	[Calls(Type = typeof(Expression), Member = "Convert")]
	public static bool CanConvert(Type fromType, Type toType, out UnaryExpression exp)
	{
		exp = null;
		return default(bool);
	}
}
