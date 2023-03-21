using System;
using System.Collections.Generic;
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
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	public Exception AsException
	{
		[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
		[CalledBy(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsResult), Member = "AssertSuccessWithoutWarnings")]
		[CalledBy(Type = typeof(fsResult), Member = "AssertSuccess")]
		[CalledBy(Type = typeof(JSONSerializer), Member = "Serialize")]
		[CallsUnknownMethods(Count = 9)]
		[Calls(Type = typeof(Exception), Member = ".ctor")]
		[Calls(Type = typeof(fsResult), Member = "get_FormattedMessages")]
		[Calls(Type = typeof(fsResult), Member = "get_RawMessages")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Exception), Member = ".ctor")]
		get
		{
			return null;
		}
	}

	public IEnumerable<string> RawMessages
	{
		[CalledBy(Type = typeof(fsResult), Member = "get_FormattedMessages")]
		[CalledBy(Type = typeof(fsResult), Member = "get_AsException")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(fsResult), Member = "AssertSuccessWithoutWarnings")]
		[CallerCount(Count = 3)]
		get
		{
			return null;
		}
	}

	public string FormattedMessages
	{
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(fsResult), Member = "get_RawMessages")]
		[Calls(Type = typeof(string), Member = "Join")]
		[CalledBy(Type = typeof(fsResult), Member = "get_AsException")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(fsUnityObjectConverter), Member = "TryDeserialize")]
	public static fsResult Warn(string warning)
	{
		return default(fsResult);
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(fsTypeConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "GetProperty")]
	[CalledBy(Type = typeof(fsEnumConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsEnumConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CallerCount(Count = 17)]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "FailExpectedType")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "DeserializeMember")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckKey")]
	public static fsResult Fail(string warning)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
	public void AddMessage(string message)
	{
	}

	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(fsListConverter), Member = "TrySerialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TrySerialize")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TryDeserialize")]
	public void AddMessages(fsResult result)
	{
	}

	[CallerCount(Count = 118)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 8)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[CallsUnknownMethods(Count = 1)]
	public fsResult AssertSuccess()
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(fsResult), Member = "get_RawMessages")]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[CallsUnknownMethods(Count = 1)]
	public fsResult AssertSuccessWithoutWarnings()
	{
		return default(fsResult);
	}
}
