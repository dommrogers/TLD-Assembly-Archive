using System;
using Cpp2ILInjected.CallAnalysis;

namespace ParadoxNotion.Serialization.FullSerializer;

public class fsConfig
{
	public Type[] SerializeAttributes;

	public Type[] IgnoreSerializeAttributes;

	public string CustomDateTimeFormatString;

	public bool Serialize64BitIntegerAsString;

	public bool SerializeEnumsAsInteger;

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 17)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(fsSerializer), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public fsConfig()
	{
	}
}
