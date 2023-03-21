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
			return false;
		}
	}

	public bool Succeeded
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool HasWarnings
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enumerable), Member = "Any")]
		get
		{
			return false;
		}
	}

	public Exception AsException
	{
		[CalledBy(Type = typeof(JSONSerializer), Member = "Serialize")]
		[CalledBy(Type = typeof(JSONSerializer), Member = "Internal_Deserialize")]
		[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
		[CalledBy(Type = typeof(fsResult), Member = "AssertSuccess")]
		[CalledBy(Type = typeof(fsResult), Member = "AssertSuccessWithoutWarnings")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(Enumerable), Member = "Any")]
		[Calls(Type = typeof(fsResult), Member = "get_FormattedMessages")]
		[Calls(Type = typeof(Exception), Member = ".ctor")]
		[CallsUnknownMethods(Count = 12)]
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
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Enumerable), Member = "ToArray")]
		[Calls(Type = typeof(string), Member = "Join")]
		get
		{
			return null;
		}
	}

	[CalledBy(Type = typeof(fsUnityObjectConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Serialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static fsResult Warn(string warning)
	{
		return default(fsResult);
	}

	[CalledBy(Type = typeof(fsBaseConverter), Member = "FailExpectedType")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckType")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "CheckKey")]
	[CalledBy(Type = typeof(fsBaseConverter), Member = "DeserializeMember")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "MakeFailure")]
	[CalledBy(Type = typeof(fsJsonParser), Member = "Parse")]
	[CalledBy(Type = typeof(fsSerializer), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsSerializer), Member = "Internal_Deserialize")]
	[CalledBy(Type = typeof(fsEnumConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsForwardConverter), Member = "GetProperty")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsPrimitiveConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsTypeConverter), Member = "TryDeserialize")]
	[CallerCount(Count = 15)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static fsResult Fail(string warning)
	{
		return default(fsResult);
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public void AddMessage(string message)
	{
	}

	[CalledBy(Type = typeof(fsArrayConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsArrayConverter), Member = "TryDeserialize")]
	[CalledBy(Type = typeof(fsListConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TrySerialize")]
	[CalledBy(Type = typeof(fsReflectedConverter), Member = "TryDeserialize")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 6)]
	public void AddMessages(fsResult result)
	{
	}

	[CallerCount(Count = 118)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
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
	[Calls(Type = typeof(Enumerable), Member = "Any")]
	[Calls(Type = typeof(fsResult), Member = "get_AsException")]
	[CallsUnknownMethods(Count = 2)]
	public fsResult AssertSuccessWithoutWarnings()
	{
		return default(fsResult);
	}
}
