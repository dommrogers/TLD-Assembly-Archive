using System;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization;

[Serializable]
public class SerializedMethodInfo : SerializedMethodBaseInfo
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ParameterInfo, string> _003C_003E9__5_0;

		public static Func<Type, string> _003C_003E9__5_1;

		public static Func<string, Type> _003C_003E9__6_0;

		public static Func<Type, bool> _003C_003E9__6_1;

		public static Func<string, Type> _003C_003E9__6_3;

		public static Func<ParameterInfo, Type> _003C_003E9__6_5;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		internal string _003COnBeforeSerialize_003Eb__5_0(ParameterInfo p)
		{
			return null;
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		internal string _003COnBeforeSerialize_003Eb__5_1(Type a)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
		internal Type _003COnAfterDeserialize_003Eb__6_0(string n)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		internal bool _003COnAfterDeserialize_003Eb__6_1(Type t)
		{
			return default(bool);
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
		internal Type _003COnAfterDeserialize_003Eb__6_3(string x)
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal Type _003COnAfterDeserialize_003Eb__6_5(ParameterInfo p)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public string name;

		public Type[] parameterTypes;

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003COnAfterDeserialize_003Eb__2(MethodInfo m)
		{
			return default(bool);
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_1
	{
		public Type[] genericArgumentTypes;

		public _003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals1;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public _003C_003Ec__DisplayClass6_1()
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 8)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[CallsUnknownMethods(Count = 15)]
		internal bool _003COnAfterDeserialize_003Eb__4(MethodInfo m)
		{
			return default(bool);
		}
	}

	private string _baseInfo;

	private string _paramsInfo;

	private string _genericArgumentsInfo;

	[NonSerialized]
	private MethodInfo _method;

	[NonSerialized]
	private bool _hasChanged;

	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(string), Member = "Join")]
	[Calls(Type = typeof(string), Member = "Join")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	public override void OnBeforeSerialize()
	{
	}

	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethods")]
	[CallsUnknownMethods(Count = 90)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[CallsDeduplicatedMethods(Count = 16)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethods")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	public override void OnAfterDeserialize()
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public SerializedMethodInfo()
	{
	}

	[CallerCount(Count = 0)]
	public SerializedMethodInfo(MethodInfo method)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public MethodInfo Get()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public override MethodBase GetBase()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public override bool HasChanged()
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	public override string GetMethodString()
	{
		return null;
	}
}
