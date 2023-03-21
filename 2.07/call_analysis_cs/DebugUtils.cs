using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DebugUtils
{
	public enum TransformColor
	{
		RGB,
		CMY,
		BGW
	}

	private static Dictionary<string, bool> s_ErrorTrack;

	private static bool s_PreviousPauseState;

	private static int s_ErrorMessageCount;

	private static string s_Filename;

	private static string s_LineNumber;

	private static string s_UserReportMessage;

	private static float[,] s_HermitePatchCurveHeights;

	private static Dictionary<LoggingFilter, string> s_LoggingFilterDisplayNames;

	private static DateTime simpleTimerStartTime;

	[CalledBy(Type = typeof(DebugUtils), Member = "Log")]
	[CalledBy(Type = typeof(DebugUtils), Member = "Log")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogWarning")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogWarning")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogWarningFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogWarningFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static string GetLoggingFilterName(LoggingFilter filter)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static string MaybeTruncateErrorMessage(string value, int maxLength)
	{
		return null;
	}

	[CalledBy(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 33)]
	private static void OnUserReportComplete(string messageType, string message)
	{
	}

	[CalledBy(Type = typeof(DebugUtils), Member = "Assert")]
	[CalledBy(Type = typeof(DebugUtils), Member = "Assert")]
	[CalledBy(Type = typeof(DebugUtils), Member = "Assert")]
	[CalledBy(Type = typeof(DebugUtils), Member = "Assert")]
	[CalledBy(Type = typeof(DebugUtils), Member = "AssertFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "AssertFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(StackFrame), Member = ".ctor")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(InternalUserReport), Member = "Send")]
	[Calls(Type = typeof(DebugUtils), Member = "OnUserReportComplete")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private static void MaybeShowMessagePanel(string messageType, string message)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "IsPanelEnabled")]
	public static void ResumeGameAfterError()
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void Unimplemented()
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void Unimplemented(LoggingFilter filter)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	public static void Assert(bool condition)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	public static void Assert(bool condition, UnityEngine.Object context)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	public static void Assert(bool condition, string output)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	public static void Assert(bool condition, string output, UnityEngine.Object context)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	public static void AssertFormat(bool condition, string output, object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	public static void AssertFormat(bool condition, UnityEngine.Object context, string output, object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public static void Log(string message)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsUnknownMethods(Count = 9)]
	public static void Log(LoggingFilter filter, string message)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public static void Log(string message, UnityEngine.Object context)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsUnknownMethods(Count = 13)]
	public static void Log(LoggingFilter filter, string message, UnityEngine.Object context)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	public static void LogFormat(string message, object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	public static void LogFormat(LoggingFilter filter, string message, object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	public static void LogFormat(UnityEngine.Object context, string message, object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	public static void LogFormat(LoggingFilter filter, UnityEngine.Object context, string message, object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public static void LogWarning(string message)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsUnknownMethods(Count = 9)]
	public static void LogWarning(LoggingFilter filter, string message)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public static void LogWarning(string message, UnityEngine.Object context)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsUnknownMethods(Count = 9)]
	public static void LogWarning(LoggingFilter filter, UnityEngine.Object context, string message)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	public static void LogWarningFormat(string message, object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	public static void LogWarningFormat(LoggingFilter filter, string message, object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	public static void LogWarningFormat(UnityEngine.Object context, string message, object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	public static void LogWarningFormat(LoggingFilter filter, UnityEngine.Object context, string message, object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static void LogError(string message)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 9)]
	public static void LogError(LoggingFilter filter, string message)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static void LogError(string message, UnityEngine.Object context)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 9)]
	public static void LogError(LoggingFilter filter, string message, UnityEngine.Object context)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	public static void LogErrorFormat(string message, object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	public static void LogErrorFormat(LoggingFilter filter, string message, object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	public static void LogErrorFormat(UnityEngine.Object context, string message, object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	public static void LogErrorFormat(LoggingFilter filter, UnityEngine.Object context, string message, object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void Watch(LoggingFilter filter, string name, string value)
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void Watch(LoggingFilter filter, string name, float value, string format = "N3")
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format")]
	public static void Watch(LoggingFilter filter, string name, Vector3 value, string format = "N3")
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void ShowPoint(Vector3 pos)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 3)]
	public static void ShowPoint(Vector3 pos, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void ShowTransform(Transform trans)
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void ShowTransform(Transform trans, TransformColor colourSet, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void ShowTransform(Matrix4x4 mat, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void ShowTransform(Matrix4x4 mat, TransformColor colourSet, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void ShowTransform(Vector3 pos, Quaternion rot, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	public static void ShowTransform(Vector3 pos, Quaternion rot, TransformColor colourSet, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void ShowTransform(Vector3 pos, Matrix4x4 mat, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	public static void ShowTransform(Vector3 pos, Matrix4x4 mat, TransformColor colourSet, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void ShowBounds(Bounds bounds, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public static void ShowBounds(Transform transform, Vector3 size, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void ShowBox(Transform transform, Vector3 size, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallsUnknownMethods(Count = 9)]
	public static void ShowBox(Matrix4x4 mat, Vector3 size, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void ShowSphere(Vector3 pos, Quaternion rot, float radius, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void ShowSphere(Transform t, float radius, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[CallsUnknownMethods(Count = 2)]
	public static void ShowSphere(Matrix4x4 mat, float radius, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "Plane3Intersect")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 8)]
	public static void ShowFrustum(Plane[] planes, Color col)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public static void ShowHermitePatch(Transform transform, Vector3[] hermiteCoefficients, Vector3 minPos, Vector3 maxPos, int subDivs, float yOffset, float duration = 0f)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	public static void SimpleTimerStart()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	public static float SimpleTimerGetElapsed()
	{
		return 0f;
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "LogRequestIgnored")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	public static string GetGameObjectPath(GameObject go)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public DebugUtils()
	{
	}
}
