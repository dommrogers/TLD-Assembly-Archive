using System;
using Cpp2ILInjected.CallAnalysis;

namespace AmplifyBloom;

[Serializable]
public class VersionInfo
{
	public const byte Major = 1;

	public const byte Minor = 0;

	public const byte Release = 8;

	private static string StageSuffix;

	private int m_major;

	private int m_minor;

	private int m_release;

	public int Number
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static string StaticToString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	private VersionInfo()
	{
	}

	[CallerCount(Count = 0)]
	private VersionInfo(byte major, byte minor, byte release)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public static VersionInfo Current()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static bool Matches(VersionInfo version)
	{
		return default(bool);
	}
}
