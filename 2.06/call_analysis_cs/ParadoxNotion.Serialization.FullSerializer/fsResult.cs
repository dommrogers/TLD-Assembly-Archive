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
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public Exception AsException
	{
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(fsResult), Member = "get_FormattedMessages")]
		[Calls(Type = typeof(Exception), Member = ".ctor")]
		[Calls(Type = typeof(Exception), Member = ".ctor")]
		[CalledBy(Type = typeof(JSONSerializer), Member = "Serialize")]
		[CalledBy(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
		[CalledBy(Type = typeof(fsResult), Member = "AssertSuccess")]
		[CalledBy(Type = typeof(fsResult), Member = "AssertSuccessWithoutWarnings")]
		[CallsUnknownMethods(Count = 13)]
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
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(fsResult), Member = "get_AsException")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "Join")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(fsUnityObjectConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CallsUnknownMethods(Count = 7)]
	public static fsResult Warn(string warning)
	{
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "GetProperty")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsEnumConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsTypeConverter), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsEnumConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "DeserializeMember")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckKey")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "FailExpectedType")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 15)]
	public static fsResult Fail(string warning)
	{
		return default(fsResult);
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	[CallerCount(Count = 0)]
	public void AddMessage(string message)
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TryDeserialize")]
	[CallsUnknownMethods(Count = 6)]
	public void AddMessages(fsResult result)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 118)]
	[CallsUnknownMethods(Count = 6)]
	private fsResult Merge(fsResult other)
	{
		return default(fsResult);
	}

	[Calls(Type = typeof(fsResult), Member = "Merge")]
	[CallerCount(Count = 0)]
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

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[CallerCount(Count = 0)]
	public fsResult AssertSuccessWithoutWarnings()
	{
		return default(fsResult);
	}
}
