using System;
using System.Linq;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization;

[Serializable]
public class SerializedConstructorInfo : SerializedMethodBaseInfo
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<ParameterInfo, string> _003C_003E9__4_0;

		public static Func<string, Type> _003C_003E9__5_0;

		public static Func<Type, bool> _003C_003E9__5_1;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal string _003COnBeforeSerialize_003Eb__4_0(ParameterInfo p)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
		internal Type _003COnAfterDeserialize_003Eb__5_0(string n)
		{
			return null;
		}

		[CallerCount(Count = 0)]
		internal bool _003COnAfterDeserialize_003Eb__5_1(Type t)
		{
			return default(bool);
		}
	}

	private string _baseInfo;

	private string _paramsInfo;

	[NonSerialized]
	private ConstructorInfo _constructor;

	[NonSerialized]
	private bool _hasChanged;

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "JoinCore")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTReflectedOrDeclaredType")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public override void OnBeforeSerialize()
	{
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetConstructors")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetConstructors")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	public override void OnAfterDeserialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public SerializedConstructorInfo()
	{
	}

	[CallerCount(Count = 0)]
	public SerializedConstructorInfo(ConstructorInfo constructor)
	{
	}

	[CallerCount(Count = 27)]
	[DeduplicatedMethod]
	public ConstructorInfo Get()
	{
		return null;
	}

	[CallerCount(Count = 27)]
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
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 1)]
	public override string GetMethodString()
	{
		return null;
	}
}
