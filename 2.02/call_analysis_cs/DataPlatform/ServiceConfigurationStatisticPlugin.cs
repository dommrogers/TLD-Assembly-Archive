using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;

namespace DataPlatform;

public class ServiceConfigurationStatisticPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr ServiceConfigurationStatistic_Id(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint ServiceConfigurationStatistic_Length(IntPtr self);

	[PreserveSig]
	[CalledBy(Type = typeof(ServiceConfigurationStatistic), Member = "get_Item")]
	[CalledBy(TypeFullName = "DataPlatform.ServiceConfigurationStatistic.<GetEnumerator>d__3", Member = "MoveNext")]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr ServiceConfigurationStatistic_GetAt(IntPtr self, uint idx);

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	public ServiceConfigurationStatisticPlugin()
	{
	}
}
