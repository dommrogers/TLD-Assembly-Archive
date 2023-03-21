using Cpp2ILInjected.CallAnalysis;
using Unity.Cloud.UserReporting.Client;

namespace Unity.Cloud.UserReporting.Plugin;

public static class UnityUserReporting
{
	private static UserReportingClient currentClient;

	public static UserReportingClient CurrentClient
	{
		[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
		[CallerCount(Count = 26)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		private set
		{
		}
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UserReportingScript), Member = "Start")]
	[Calls(Type = typeof(UserReportingClient), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	public static void Configure(string endpoint, string projectIdentifier, IUserReportingPlatform platform, UserReportingClientConfiguration configuration)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityUserReporting), Member = "GetPlatform")]
	[Calls(Type = typeof(UserReportingClient), Member = ".ctor")]
	public static void Configure(string endpoint, string projectIdentifier, UserReportingClientConfiguration configuration)
	{
	}

	[Calls(Type = typeof(UnityUserReporting), Member = "GetPlatform")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	public static void Configure(string projectIdentifier, UserReportingClientConfiguration configuration)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityUserReporting), Member = "GetPlatform")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallsUnknownMethods(Count = 7)]
	public static void Configure(string projectIdentifier)
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "get_CurrentClient")]
	[CalledBy(Type = typeof(UserReportingMonitor), Member = "Start")]
	[CalledBy(Type = typeof(UserReportingConfigureOnly), Member = "Start")]
	[CalledBy(Type = typeof(UserReportingScriptNoPanel), Member = "Awake")]
	[Calls(Type = typeof(UnityUserReporting), Member = "GetPlatform")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	public static void Configure()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityUserReporting), Member = "GetPlatform")]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	public static void Configure(UserReportingClientConfiguration configuration)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	public static void Configure(string projectIdentifier, IUserReportingPlatform platform, UserReportingClientConfiguration configuration)
	{
	}

	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public static void Configure(IUserReportingPlatform platform, UserReportingClientConfiguration configuration)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CallsUnknownMethods(Count = 8)]
	public static void Configure(IUserReportingPlatform platform)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UnityUserReporting), Member = "Configure")]
	[CalledBy(Type = typeof(UserReportingScript), Member = "Start")]
	[Calls(Type = typeof(UnityUserReportingPlatform), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 6)]
	private static IUserReportingPlatform GetPlatform()
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Use(UserReportingClient client)
	{
	}
}
