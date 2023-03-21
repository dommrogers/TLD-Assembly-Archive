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

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogWarningFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogWarningFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "Log")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogWarning")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogWarning")]
	private static string GetLoggingFilterName(LoggingFilter filter)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static string MaybeTruncateErrorMessage(string value, int maxLength)
	{
		return null;
	}

	[Calls(Type = typeof(Panel_Confirmation), Member = "AddConfirmation")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 41)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static void OnUserReportComplete(string messageType, string message)
	{
	}

	[CalledBy(Type = typeof(DebugUtils), Member = "Assert")]
	[CalledBy(Type = typeof(DebugUtils), Member = "AssertFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "AssertFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "Assert")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogError")]
	[CalledBy(Type = typeof(DebugUtils), Member = "Assert")]
	[CalledBy(Type = typeof(DebugUtils), Member = "LogErrorFormat")]
	[Calls(Type = typeof(DebugUtils), Member = "OnUserReportComplete")]
	[CallerCount(Count = 14)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "GetInstance")]
	[Calls(Type = typeof(WebUtils.SteamCloudManager), Member = "IsOperationPending")]
	[Calls(Type = typeof(StackFrame), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(InternalUserReport), Member = "Instance")]
	[Calls(Type = typeof(InternalUserReport), Member = "Send")]
	[Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension")]
	[CalledBy(Type = typeof(DebugUtils), Member = "Assert")]
	private static void MaybeShowMessagePanel(string messageType, string message)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public static void ResumeGameAfterError()
	{
	}

	[CallerCount(Count = 2)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	public static void Unimplemented()
	{
	}

	[CallerCount(Count = 2)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	public static void Unimplemented(LoggingFilter filter)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	public static void Assert(bool condition)
	{
	}

	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Assert(bool condition, UnityEngine.Object context)
	{
	}

	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	public static void Assert(bool condition, string output)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	public static void Assert(bool condition, string output, UnityEngine.Object context)
	{
	}

	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void AssertFormat(bool condition, string output, object[] args)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	public static void AssertFormat(bool condition, UnityEngine.Object context, string output, object[] args)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public static void Log(string message)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void Log(LoggingFilter filter, string message)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	public static void Log(string message, UnityEngine.Object context)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsUnknownMethods(Count = 13)]
	public static void Log(LoggingFilter filter, string message, UnityEngine.Object context)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	public static void LogFormat(string message, object[] args)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	public static void LogFormat(LoggingFilter filter, string message, object[] args)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogFormat(UnityEngine.Object context, string message, object[] args)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogFormat")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	public static void LogFormat(LoggingFilter filter, UnityEngine.Object context, string message, object[] args)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public static void LogWarning(string message)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	public static void LogWarning(LoggingFilter filter, string message)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public static void LogWarning(string message, UnityEngine.Object context)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsUnknownMethods(Count = 9)]
	public static void LogWarning(LoggingFilter filter, UnityEngine.Object context, string message)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	public static void LogWarningFormat(string message, object[] args)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	public static void LogWarningFormat(LoggingFilter filter, string message, object[] args)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	public static void LogWarningFormat(UnityEngine.Object context, string message, object[] args)
	{
	}

	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogWarningFormat")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	public static void LogWarningFormat(LoggingFilter filter, UnityEngine.Object context, string message, object[] args)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static void LogError(string message)
	{
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogError(LoggingFilter filter, string message)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public static void LogError(string message, UnityEngine.Object context)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[CallsUnknownMethods(Count = 9)]
	public static void LogError(LoggingFilter filter, string message, UnityEngine.Object context)
	{
	}

	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogErrorFormat(string message, object[] args)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	public static void LogErrorFormat(LoggingFilter filter, string message, object[] args)
	{
	}

	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void LogErrorFormat(UnityEngine.Object context, string message, object[] args)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(DebugUtils), Member = "MaybeShowMessagePanel")]
	[Calls(Type = typeof(DebugUtils), Member = "GetLoggingFilterName")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogErrorFormat")]
	public static void LogErrorFormat(LoggingFilter filter, UnityEngine.Object context, string message, object[] args)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Conditional(/*Could not decode attribute arguments.*/)]
	public static void Watch(LoggingFilter filter, string name, string value)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void Watch(LoggingFilter filter, string name, float value, string format = "N3")
	{
	}

	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	public static void Watch(LoggingFilter filter, string name, Vector3 value, string format = "N3")
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void ShowPoint(Vector3 pos)
	{
	}

	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	public static void ShowPoint(Vector3 pos, Color colour, float duration = 0f)
	{
	}

	[CallerCount(Count = 2)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	public static void ShowTransform(Transform trans)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	public static void ShowTransform(Transform trans, TransformColor colourSet, float duration = 0f)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Conditional(/*Could not decode attribute arguments.*/)]
	public static void ShowTransform(Matrix4x4 mat, float duration = 0f)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void ShowTransform(Matrix4x4 mat, TransformColor colourSet, float duration = 0f)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void ShowTransform(Vector3 pos, Quaternion rot, float duration = 0f)
	{
	}

	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Matrix4x4), Member = "set_Item")]
	[Calls(Type = typeof(Quaternion), Member = "op_Multiply")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[Calls(Type = typeof(Matrix4x4), Member = "get_identity")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	public static void ShowTransform(Vector3 pos, Quaternion rot, TransformColor colourSet, float duration = 0f)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void ShowTransform(Vector3 pos, Matrix4x4 mat, float duration = 0f)
	{
	}

	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn")]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn")]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn")]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(Debug), Member = "DrawRay")]
	public static void ShowTransform(Vector3 pos, Matrix4x4 mat, TransformColor colourSet, float duration = 0f)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[CallsUnknownMethods(Count = 1)]
	public static void ShowBounds(Bounds bounds, Color colour, float duration = 0f)
	{
	}

	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 4)]
	public static void ShowBounds(Transform transform, Vector3 size, Color colour, float duration = 0f)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void ShowBox(Transform transform, Vector3 size, Color colour, float duration = 0f)
	{
	}

	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	[Calls(Type = typeof(Matrix4x4), Member = "MultiplyPoint")]
	public static void ShowBox(Matrix4x4 mat, Vector3 size, Color colour, float duration = 0f)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Quaternion), Member = "get_identity")]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallsDeduplicatedMethods(Count = 3)]
	public static void ShowSphere(Vector3 pos, Quaternion rot, float radius, Color colour, float duration = 0f)
	{
	}

	[Conditional(/*Could not decode attribute arguments.*/)]
	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public static void ShowSphere(Transform t, float radius, Color colour, float duration = 0f)
	{
	}

	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn")]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Matrix4x4), Member = "GetColumn")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void ShowSphere(Matrix4x4 mat, float radius, Color colour, float duration = 0f)
	{
	}

	[CallsUnknownMethods(Count = 39)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Utils), Member = "Plane3Intersect")]
	[Calls(Type = typeof(Utils), Member = "Plane3Intersect")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	[Calls(Type = typeof(Time), Member = "get_deltaTime")]
	public static void ShowFrustum(Plane[] planes, Color col)
	{
	}

	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[CallsUnknownMethods(Count = 35)]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Debug), Member = "DrawLine")]
	[Calls(Type = typeof(Mathf), Member = "Lerp")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Transform), Member = "get_right")]
	[Calls(Type = typeof(Utils), Member = "CalcHermite")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Vector3), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "get_right")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	public static void ShowHermitePatch(Transform transform, Vector3[] hermiteCoefficients, Vector3 minPos, Vector3 maxPos, int subDivs, float yOffset, float duration = 0f)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	public static void SimpleTimerStart()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(DateTime), Member = "get_Now")]
	[CallerCount(Count = 0)]
	public static float SimpleTimerGetElapsed()
	{
		return default(float);
	}

	[CalledBy(Type = typeof(NPCVoice), Member = "LogRequestIgnored")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(AkGameObj), Member = "LogAudioBucket")]
	[CallsUnknownMethods(Count = 10)]
	public static string GetGameObjectPath(GameObject go)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public DebugUtils()
	{
	}
}
