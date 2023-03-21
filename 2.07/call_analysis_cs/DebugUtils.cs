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

	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogWarningFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogWarningFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogWarning")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogFormat")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "Log")]
	[CalledBy(Type = typeof(DebugUtils), Member = "Log")]
	[Calls(Type = typeof(Enum), Member = "ToString")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogWarning")]
	private static string GetLoggingFilterName(LoggingFilter filter)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	private static string MaybeTruncateErrorMessage(string value, int maxLength)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[CalledBy(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[CallsUnknownMethods(Count = 33)]
	private static void OnUserReportComplete(string messageType, string message)
	{
	}

	[CalledBy(Type = typeof(DebugUtils), Member = "AssertFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "AssertFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "Assert")]
	[CalledBy(Type = typeof(DebugUtils), Member = "Assert")]
	[CalledBy(Type = typeof(DebugUtils), Member = "Assert")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(StackFrame), Member = ".ctor")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InternalUserReport), Member = "Send")]
	[Calls(Type = typeof(DebugUtils), Member = "OnUserReportComplete")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CalledBy(Type = typeof(DebugUtils), Member = "Assert")]
	private static void MaybeShowMessagePanel(string messageType, string message)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ResumeGameAfterError()
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void Unimplemented()
	{
	}

	[CallerCount(Count = 6)]
	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	public static void Unimplemented(LoggingFilter filter)
	{
	}

	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Conditional("__DEBUG")]
	[Calls(Type = typeof(string), Member = "Format")]
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

	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public static void Log(string message)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
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

	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
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

	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	public static void LogFormat(LoggingFilter filter, UnityEngine.Object context, string message, object[] args)
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public static void LogWarning(string message)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[CallsUnknownMethods(Count = 9)]
	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
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

	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
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

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
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

	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
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

	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
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

	[Calls(Type = typeof(string), Member = "Format")]
	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	[Conditional("__DEBUG")]
	public static void ShowTransform(Matrix4x4 mat, float duration = 0f)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	[Conditional("__DEBUG")]
	public static void ShowTransform(Matrix4x4 mat, TransformColor colourSet, float duration = 0f)
	{
	}

	[CallerCount(Count = 6)]
	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
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

	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	public static void ShowTransform(Vector3 pos, Matrix4x4 mat, TransformColor colourSet, float duration = 0f)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	public static void ShowBounds(Bounds bounds, Color colour, float duration = 0f)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	public static void ShowBounds(Transform transform, Vector3 size, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void ShowBox(Transform transform, Vector3 size, Color colour, float duration = 0f)
	{
	}

	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[CallsUnknownMethods(Count = 9)]
	public static void ShowBox(Matrix4x4 mat, Vector3 size, Color colour, float duration = 0f)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	public static void ShowSphere(Vector3 pos, Quaternion rot, float radius, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public static void ShowSphere(Transform t, float radius, Color colour, float duration = 0f)
	{
	}

	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	public static void ShowSphere(Matrix4x4 mat, float radius, Color colour, float duration = 0f)
	{
	}

	[Conditional("__DEBUG")]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Utils), Member = "Plane3Intersect")]
	[Calls(Type = typeof(Utils), Member = "Plane3Intersect")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	public static void ShowFrustum(Plane[] planes, Color col)
	{
	}

	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Conditional("__DEBUG")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
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
		return default(float);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(NPCVoice), Member = "LogRequestIgnored")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
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
