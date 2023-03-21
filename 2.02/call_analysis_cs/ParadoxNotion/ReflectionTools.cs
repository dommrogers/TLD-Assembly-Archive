using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
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
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		internal bool _003CTryResolveDeserializeFromAttribute_003Eb__0(string n)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public bool includeObsolete;

		public Func<Type, bool> _003C_003E9__2;

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectionTools), Member = "RTIsDefined")]
		[CallsDeduplicatedMethods(Count = 1)]
		internal bool _003CGetAllTypes_003Eb__2(Type t)
		{
			return false;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 7)]
		public _003C_003Ec()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[CallsDeduplicatedMethods(Count = 1)]
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

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CIsAllowedByGenericArgument_003Eb__105_0(ConstructorInfo info)
		{
			return false;
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
		[CalledBy(Type = typeof(ReflectionTools), Member = "GetTypeDirect")]
		[CalledBy(Type = typeof(ReflectionTools), Member = "GetAllTypes")]
		[CallerCount(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 9)]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "TryResolveGenericType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static Type GetType(string typeFullName)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(fsRecoveryProcessor<, >), Member = "OnBeforeDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CallerCount(Count = 3)]
	public static Type GetType(string typeFullName, Type fallbackAssignable)
	{
		return null;
	}

	[CalledBy(Type = typeof(Variable<>), Member = "InitializePropertyBinding")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetType")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "TryResolveGenericType")]
	[CalledBy(Type = typeof(SerializedConstructorInfo), Member = "OnAfterDeserialize")]
	[CalledBy(TypeFullName = "ParadoxNotion.Serialization.SerializedConstructorInfo.<>c", Member = "<OnAfterDeserialize>b__5_0")]
	[CalledBy(Type = typeof(SerializedEventInfo), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CalledBy(Type = typeof(SerializedFieldInfo), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CalledBy(Type = typeof(SerializedMethodInfo), Member = "OnAfterDeserialize")]
	[CalledBy(TypeFullName = "ParadoxNotion.Serialization.SerializedMethodInfo.<>c", Member = "<OnAfterDeserialize>b__6_0")]
	[CalledBy(TypeFullName = "ParadoxNotion.Serialization.SerializedMethodInfo.<>c", Member = "<OnAfterDeserialize>b__6_3")]
	[CalledBy(Type = typeof(SerializedTypeInfo), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CalledBy(Type = typeof(fsTypeConverter), Member = "TryDeserialize")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetTypeDirect")]
	[Calls(Type = typeof(ReflectionTools), Member = "TryResolveGenericType")]
	[Calls(Type = typeof(ReflectionTools), Member = "TryResolveDeserializeFromAttribute")]
	[Calls(Type = typeof(ReflectionTools), Member = "TryResolveWithoutNamespace")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	public static Type GetType(string typeFullName, bool fallbackNoNamespace = false, Type fallbackAssignable = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "GetType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetType")]
	[Calls(Type = typeof(ReflectionTools), Member = "get_loadedAssemblies")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	private static Type GetTypeDirect(string typeFullName)
	{
		return null;
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "GetType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(Logger), Member = "LogException")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 34)]
	private static Type TryResolveGenericType(string typeFullName, bool fallbackNoNamespace = false, Type fallbackAssignable = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "GetType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectionTools), Member = "GetAllTypes")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetAttribute")]
	[Calls(Type = typeof(Enumerable), Member = "Any")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 18)]
	private static Type TryResolveDeserializeFromAttribute(string typeName)
	{
		return null;
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "GetType")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetAllTypes")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 22)]
	private static Type TryResolveWithoutNamespace(string typeName, Type fallbackAssignable = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "TryResolveDeserializeFromAttribute")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "TryResolveWithoutNamespace")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetImplementationsOf")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetExtensionMethods")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(ReflectionTools), Member = "get_loadedAssemblies")]
	[Calls(Type = typeof(Enumerable), Member = "Where")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 62)]
	public static Type[] GetAllTypes(bool includeObsolete)
	{
		return null;
	}

	[CalledBy(Type = typeof(fsSerializer), Member = ".cctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetAllTypes")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 16)]
	public static Type[] GetImplementationsOf(Type baseType)
	{
		return null;
	}

	[CalledBy(TypeFullName = "NodeCanvas.Framework.Variable`1.<>c__DisplayClass22_1", Member = "<InitializePropertyBinding>b__2")]
	[CalledBy(TypeFullName = "NodeCanvas.StateMachines.FSM.<>c__DisplayClass50_0", Member = "<GatherDelegates>b__0")]
	[CalledBy(TypeFullName = "NodeCanvas.StateMachines.FSM.<>c__DisplayClass50_0", Member = "<GatherDelegates>b__1")]
	[CalledBy(TypeFullName = "NodeCanvas.StateMachines.FSM.<>c__DisplayClass50_0", Member = "<GatherDelegates>b__2")]
	[CalledBy(Type = typeof(SetProperty_Multiplatform), Member = "OnExecute")]
	[CalledBy(Type = typeof(MessageRouter), Member = "Dispatch")]
	[CallerCount(Count = 6)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static object[] SingleTempArgsArray(object arg)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static MethodType GetMethodSpecialType(this MethodBase method)
	{
		return default(MethodType);
	}

	[CallerCount(Count = 35)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 5)]
	public static string FriendlyName(this Type t, bool compileSafe = false)
	{
		return null;
	}

	[CalledBy(Type = typeof(Node), Member = "ToString")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static string FriendlyName(this MemberInfo info)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string FriendlyName(this MethodBase method)
	{
		return null;
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "SignatureName")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StringUtils), Member = "CapitalizeFirst")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	public static string FriendlyName(this MethodBase method, out MethodType specialNameType)
	{
		specialNameType = default(MethodType);
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ReflectionTools), Member = "IsParams")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallsUnknownMethods(Count = 10)]
	public static string SignatureName(this MethodBase method)
	{
		return null;
	}

	[CallerCount(Count = 31)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
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
		return false;
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetAttribute")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetAttribute")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsAssignableTo(this Type type, Type other)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsAbstract(this Type type)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsValueType(this Type type)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsArray(this Type type)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface")]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsInterface(this Type type)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsSubclassOf(this Type type, Type other)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsGenericParameter(this Type type)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsGenericType(this Type type)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool RTIsByRef(this Type type)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static object CreateObject(this Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FormatterServices), Member = "GetUninitializedObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static object CreateObjectUninitialized(this Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetConstructors")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static ConstructorInfo RTGetDefaultConstructor(this Type type)
	{
		return null;
	}

	[CalledBy(Type = typeof(SerializedConstructorInfo), Member = "OnAfterDeserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetConstructors")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 11)]
	public static ConstructorInfo RTGetConstructor(this Type type, Type[] paramTypes)
	{
		return null;
	}

	[CalledBy(Type = typeof(CheckCSharpEvent), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckCSharpEvent<>), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckCSharpEventValue<>), Member = "OnInit")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetDelegateTypeParameters")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethods")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static MethodInfo RTGetMethod(this Type type, string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTCreateDelegate")]
	[CalledBy(Type = typeof(SerializedMethodInfo), Member = "OnAfterDeserialize")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethods")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 11)]
	public static MethodInfo RTGetMethod(this Type type, string name, Type[] paramTypes)
	{
		return null;
	}

	[CalledBy(Type = typeof(Variable<>), Member = "InitializePropertyBinding")]
	[CalledBy(Type = typeof(CheckField), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckUnityEvent), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckUnityEvent<>), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckUnityEventValue<>), Member = "OnInit")]
	[CalledBy(Type = typeof(GetField), Member = "OnInit")]
	[CalledBy(Type = typeof(SetField), Member = "OnInit")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetBaseDefinition")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "IsAutoProperty")]
	[CalledBy(Type = typeof(SerializedFieldInfo), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetFields")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public static FieldInfo RTGetField(this Type type, string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(Variable<>), Member = "InitializePropertyBinding")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "IsObsolete")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetAccessorProperty")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public static PropertyInfo RTGetProperty(this Type type, string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(CheckCSharpEvent), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckCSharpEvent<>), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckCSharpEventValue<>), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckStaticCSharpEvent), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckStaticCSharpEvent<>), Member = "OnInit")]
	[CalledBy(Type = typeof(SerializedEventInfo), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 9)]
	public static EventInfo RTGetEvent(this Type type, string name)
	{
		return null;
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetDefaultConstructor")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetConstructor")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "IsAllowedByGenericArgument")]
	[CalledBy(Type = typeof(SerializedConstructorInfo), Member = "OnAfterDeserialize")]
	[CalledBy(Type = typeof(fsMetaType), Member = "HasDefaultConstructor")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static ConstructorInfo[] RTGetConstructors(this Type type)
	{
		return null;
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetExtensionMethods")]
	[CalledBy(Type = typeof(SerializedMethodInfo), Member = "OnAfterDeserialize")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static MethodInfo[] RTGetMethods(this Type type)
	{
		return null;
	}

	[CalledBy(Type = typeof(Task), Member = "InitializeAttributes")]
	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[CalledBy(Type = typeof(BBParameter), Member = "GetObjectBBParameters")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTGetField")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static FieldInfo[] RTGetFields(this Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static PropertyInfo[] RTGetProperties(this Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static EventInfo[] RTGetEvents(this Type type)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Graph), Member = "RemoveNode")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetExtensionMethods")]
	[CalledBy(Type = typeof(_003C_003Ec__DisplayClass14_0), Member = "<GetAllTypes>b__2")]
	[CalledBy(Type = typeof(StringUtils), Member = "ToStringAdvanced")]
	[CalledBy(Type = typeof(fsEnumConverter), Member = "TrySerialize")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsDefined<T>(this Type type, bool inherited) where T : Attribute
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsDefined(this Type type, Type attributeType, bool inherited)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Task), Member = "InitializeAttributes")]
	[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "IsObsolete")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "IsExtensionMethod")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsDefined<T>(this MemberInfo member, bool inherited) where T : Attribute
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool RTIsDefined(this MemberInfo member, Type attributeType, bool inherited)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(Node), Member = "get_name")]
	[CalledBy(Type = typeof(Node), Member = "get_description")]
	[CalledBy(Type = typeof(Node), Member = "get_priority")]
	[CalledBy(Type = typeof(Task), Member = "get_obsolete")]
	[CalledBy(Type = typeof(Task), Member = "get_name")]
	[CalledBy(Type = typeof(Task), Member = "get_description")]
	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "TryResolveDeserializeFromAttribute")]
	[CalledBy(Type = typeof(fsSerializer), Member = "GetProcessors")]
	[CalledBy(Type = typeof(fsSerializer), Member = "GetConverter")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTIsAssignableTo")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	public static T RTGetAttribute<T>(this Type type, bool inherited) where T : Attribute
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(fsMetaProperty), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTIsAssignableTo")]
	[CallsDeduplicatedMethods(Count = 4)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static ParameterInfo[] RTGetDelegateTypeParameters(this Type delegateType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(ReflectedAction), Member = "Init")]
	[CalledBy(Type = typeof(FSM), Member = "GatherDelegates")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTCreateDelegate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	public static T RTCreateDelegate<T>(this MethodInfo method, object instance)
	{
		return default(T);
	}

	[CalledBy(Type = typeof(CheckCSharpEvent), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckCSharpEvent<>), Member = "OnInit")]
	[CalledBy(Type = typeof(CheckCSharpEventValue<>), Member = "OnInit")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "RTCreateDelegate")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Enumerable), Member = "Select")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public static Delegate RTCreateDelegate(this MethodInfo method, Type type, object instance)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "CreateDelegate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static Delegate ConvertDelegate(Delegate originalDelegate, Type targetDelegateType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsReadOnly(this FieldInfo field)
	{
		return false;
	}

	[CalledBy(Type = typeof(Variable<>), Member = "InitializePropertyBinding")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsConstant(this FieldInfo field)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsStatic(this EventInfo info)
	{
		return false;
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "SignatureName")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsParams(this ParameterInfo parameter, ParameterInfo[] parameters)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "IsPropertyAccessor")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTIsDefined")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetProperty")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsObsolete(this MemberInfo member, bool inherited = true)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(Enumerable), Member = "Select")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray")]
	[Calls(Type = typeof(Type), Member = "GetProperty")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 11)]
	public static PropertyInfo GetBaseDefinition(this PropertyInfo propertyInfo)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetField")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public static FieldInfo GetBaseDefinition(this FieldInfo fieldInfo)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetAllTypes")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTIsDefined")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethods")]
	[Calls(Type = typeof(ReflectionTools), Member = "IsExtensionMethod")]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 24)]
	public static MethodInfo[] GetExtensionMethods(this Type targetType)
	{
		return null;
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "GetExtensionMethods")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTIsDefined")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static bool IsExtensionMethod(this MethodInfo method)
	{
		return false;
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "IsObsolete")]
	[CalledBy(Type = typeof(ReflectionTools), Member = "GetAccessorProperty")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public static bool IsPropertyAccessor(this MethodInfo method)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsIndexerProperty(this PropertyInfo property)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetField")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsAutoProperty(this PropertyInfo property)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "IsPropertyAccessor")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetProperty")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public static PropertyInfo GetAccessorProperty(this MethodInfo method)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static bool IsEnumerableCollection(this Type type)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	public static Type GetEnumerableElementType(this Type type)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "AddNode")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "First")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static Type GetFirstGenericParameterConstraintType(this Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "First")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	public static Type GetFirstGenericParameterConstraintType(this MethodInfo method)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault")]
	[Calls(Type = typeof(ReflectionTools), Member = "IsAllowedByGenericArgument")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	public static bool CanBeMadeGenericWith(this Type def, Type type)
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static bool CanBeMadeGenericWith(this MethodInfo def, Type type)
	{
		return false;
	}

	[CalledBy(Type = typeof(ReflectionTools), Member = "CanBeMadeGenericWith")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetConstructors")]
	[Calls(Type = typeof(Enumerable), Member = "FirstOrDefault")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 12)]
	public static bool IsAllowedByGenericArgument(this Type type, Type genericArgument)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "get_Length")]
	[Calls(Type = typeof(Array), Member = "CreateInstance")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static Array Resize(this Array array, int newSize)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Expression), Member = "Parameter")]
	[Calls(Type = typeof(Expression), Member = "Convert")]
	[CallsDeduplicatedMethods(Count = 2)]
	public static bool CanConvert(Type fromType, Type toType, out UnaryExpression exp)
	{
		exp = null;
		return false;
	}
}
