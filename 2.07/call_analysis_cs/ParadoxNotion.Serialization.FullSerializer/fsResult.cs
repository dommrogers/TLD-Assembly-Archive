using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using ParadoxNotion.Serialization.FullSerializer.Internal;

namespace ParadoxNotion.Serialization.FullSerializer;

public struct fsResult
{
	private static readonly string[] EmptyStringArray;

	private bool _success;

	private List<string> _messages;

	public static fsResult Success;

	public bool Failed
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool Succeeded
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public bool HasWarnings
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public Exception AsException
	{
		[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
		[CallsUnknownMethods(Count = 7)]
		[CalledBy(Type = typeof(fsResult), Member = "AssertSuccessWithoutWarnings")]
		[CalledBy(Type = typeof(fsResult), Member = "AssertSuccess")]
		[CalledBy(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(JSONSerializer), Member = "Serialize")]
		[Calls(Type = typeof(Exception), Member = ".ctor")]
		[Calls(Type = typeof(Exception), Member = ".ctor")]
		[Calls(Type = typeof(fsResult), Member = "get_FormattedMessages")]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
	}

	public IEnumerable<string> RawMessages
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public string FormattedMessages
	{
		[CalledBy(Type = typeof(fsResult), Member = "get_AsException")]
		[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
		[CallsUnknownMethods(Count = 11)]
		[Calls(Type = typeof(string), Member = "JoinCore")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(fsUnityObjectConverter), Member = "TryDeserialize")]
	public static fsResult Warn(string warning)
	{
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsEnumConverter), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(fsTypeConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "GetProperty")]
	[CalledBy(Type = typeof(fsEnumConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "DeserializeMember")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckKey")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "FailExpectedType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 15)]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	public static fsResult Fail(string warning)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void AddMessage(string message)
	{
	}

	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "TrySerialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TrySerialize")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TryDeserialize")]
	public void AddMessages(fsResult result)
	{
	}

	[CallerCount(Count = 118)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private fsResult Merge(fsResult other)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsResult), Member = "Merge")]
	public static fsResult operator +(fsResult a, fsResult b)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[CallsUnknownMethods(Count = 2)]
	public fsResult AssertSuccess()
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[CallsUnknownMethods(Count = 3)]
	public fsResult AssertSuccessWithoutWarnings()
	{
		return default(fsResult);
	}
}
