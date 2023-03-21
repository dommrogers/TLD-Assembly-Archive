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

	[CallsUnknownMethods(Count = 17)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CalledBy(Type = typeof(fsSerializer), Member = ".ctor")]
	public fsConfig()
	{
	}
}
