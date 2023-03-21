using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Serialization.FullSerializer;

namespace ParadoxNotion.Serialization;

public class fsRecoveryProcessor<TCanProcess, TMissing> : fsObjectProcessor where TMissing : TCanProcess, IMissingRecoverable
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public Dictionary<string, fsData> json;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003COnBeforeDeserialize_003Eb__0(KeyValuePair<string, fsData> kvp)
		{
			return default(bool);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<KeyValuePair<string, fsData>, string> _003C_003E9__3_1;

		public static Func<KeyValuePair<string, fsData>, fsData> _003C_003E9__3_2;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal string _003COnBeforeDeserialize_003Eb__3_1(KeyValuePair<string, fsData> c)
		{
			return null;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal fsData _003COnBeforeDeserialize_003Eb__3_2(KeyValuePair<string, fsData> c)
		{
			return null;
		}
	}

	private const string FIELD_NAME_TYPE = "_missingType";

	private const string FIELD_NAME_STATE = "_recoveryState";

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override bool CanProcess(Type type)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[Calls(Type = typeof(fsData), Member = "get_AsDictionary")]
	[Calls(Type = typeof(fsJsonParser), Member = "Parse")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(fsData), Member = "get_AsString")]
	[Calls(Type = typeof(ReflectionTools), Member = "GetType")]
	[Calls(Type = typeof(fsData), Member = "get_IsDictionary")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public override void OnBeforeDeserialize(Type storageType, ref fsData data)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public override void OnAfterDeserialize(Type storageType, object instance)
	{
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public fsRecoveryProcessor()
	{
	}
}
