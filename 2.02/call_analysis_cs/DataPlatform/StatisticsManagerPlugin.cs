using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected.CallAnalysis;
using UnityAOT;

namespace DataPlatform;

public class StatisticsManagerPlugin
{
	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool StatisticsManager_GetSingleUserStatisticsAsyncMultipleStats(int userId, string xboxUserId, string serviceConfigurationId, [In] string[] statisticNames, int numStatNames, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool StatisticsManager_GetSingleUserStatisticsAsync(int userId, string xboxUserId, string serviceConfigurationId, string statisticName, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 2)]
	public static extern bool StatisticsManager_GetMultipleUserStatisticsAsync(int userId, [In] string[] xboxUserIds, int numUserIds, string serviceConfigurationId, [In] string[] statisticNames, int numStatNames, ObjectResultCallback callback, IntPtr userData);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void StatisticsManager_MuliUserStatisticsResult_Dispose(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static extern uint StatisticsManager_MuliUserStatisticsResult_Size(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr StatisticsManager_MuliUserStatisticsResult_GetAt(IntPtr self, uint idx);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern void StatisticsManager_UserStatisticsResult_Dispose(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern IntPtr StatisticsManager_UserStatisticsResult_XboxUserId(IntPtr self);

	[PreserveSig]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static extern uint StatisticsManager_UserStatisticsResult_ServiceConfigurationStatistics_Length(IntPtr self);

	[PreserveSig]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UserStatisticsResult), Member = "get_Item")]
	[CalledBy(Type = typeof(UserStatisticsResult._003CGetEnumerator_003Ed__3), Member = "MoveNext")]
	public static extern IntPtr StatisticsManager_UserStatisticsResult_ServiceConfigurationStatistics_GetAt(IntPtr self, uint idx);

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public StatisticsManagerPlugin()
	{
	}
}
