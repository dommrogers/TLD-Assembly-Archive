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
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal string _003COnBeforeSerialize_003Eb__5_0(ParameterInfo p)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal string _003COnBeforeSerialize_003Eb__5_1(Type a)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
		internal Type _003COnAfterDeserialize_003Eb__6_0(string n)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		internal bool _003COnAfterDeserialize_003Eb__6_1(Type t)
		{
			return default(bool);
		}

		[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
		[CallerCount(Count = 0)]
		internal Type _003COnAfterDeserialize_003Eb__6_3(string x)
		{
			return null;
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		internal Type _003COnAfterDeserialize_003Eb__6_5(ParameterInfo p)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public string name;

		public Type[] parameterTypes;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
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
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass6_1()
		{
		}

		[CallsUnknownMethods(Count = 7)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 7)]
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

	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(string), Member = "Join")]
	[Calls(Type = typeof(string), Member = "Join")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public override void OnBeforeSerialize()
	{
	}

	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethods")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethod")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetMethods")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Split")]
	public override void OnAfterDeserialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SerializedMethodInfo()
	{
	}

	[CallerCount(Count = 0)]
	public SerializedMethodInfo(MethodInfo method)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 58)]
	public MethodInfo Get()
	{
		return null;
	}

	[CallerCount(Count = 58)]
	[DeduplicatedMethod]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsUnknownMethods(Count = 1)]
	public override string GetMethodString()
	{
		return null;
	}
}
