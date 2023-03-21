using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public sealed class vp_ComponentPreset
{
	private enum ReadMode
	{
		Normal,
		LineComment,
		BlockComment
	}

	private class Field
	{
		public FieldInfo m_FieldInfo;

		public object Args;

		[CallerCount(Count = 263)]
		[DeduplicatedMethod]
		public Field(FieldInfo fieldInfo, object args)
		{
		}
	}

	private static string m_FullPath;

	private static int m_LineNumber;

	private static Type m_Type;

	public static bool LogErrors;

	private static ReadMode m_ReadMode;

	private Type m_ComponentType;

	private List<Field> m_Fields;

	public Type ComponentType
	{
		[CallerCount(Count = 80)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public static string Save(Component component, string fullPath)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ExtractFilenameFromPath")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CallsUnknownMethods(Count = 98)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 15)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ExtractFilenameFromPath")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ExtractFilenameFromPath")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ExtractFilenameFromPath")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ClearTextFile")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "Exists")]
	public static string Save(vp_ComponentPreset savePreset, string fullPath, bool isDifference = false)
	{
		return null;
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "InitFromComponent")]
	[CallsUnknownMethods(Count = 22)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	public static string SaveDifference(vp_ComponentPreset initialStatePreset, Component modifiedComponent, string fullPath, vp_ComponentPreset diskPreset)
	{
		return null;
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CalledBy(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	public void InitFromComponent(Component component)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	public static vp_ComponentPreset CreateFromComponent(Component component)
	{
		return null;
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileType")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Load")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	public bool LoadTextStream(string fullPath)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CallsUnknownMethods(Count = 1)]
	public static bool Load(Component component, string fullPath)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(TextAsset), Member = "DecodeString")]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	public bool LoadFromResources(string resourcePath)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CallsUnknownMethods(Count = 1)]
	public static vp_ComponentPreset LoadFromResources(Component component, string resourcePath)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TextAsset), Member = "DecodeString")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileTypeFromAsset")]
	[CalledBy(Type = typeof(vp_StateManager), Member = ".ctor")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CallerCount(Count = 4)]
	public bool LoadFromTextAsset(TextAsset file)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CallsUnknownMethods(Count = 1)]
	public static vp_ComponentPreset LoadFromTextAsset(Component component, TextAsset file)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	private static void Append(string str)
	{
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CallsUnknownMethods(Count = 1)]
	private static void ClearTextFile()
	{
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Parse")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "RemoveComments")]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CallsUnknownMethods(Count = 3)]
	private void ParseLines(List<string> lines)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[CallerCount(Count = 1)]
	private bool Parse(string line)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[CallsUnknownMethods(Count = 37)]
	[CalledBy(Type = typeof(vp_StateManager), Member = "CombineStates")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Load")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_Component), Member = "ApplyPreset")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetErrorLocation")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetErrorLocation")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetErrorLocation")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetErrorLocation")]
	public static bool Apply(Component component, vp_ComponentPreset preset)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[CallsUnknownMethods(Count = 1)]
	public static Type GetFileType(string fullPath)
	{
		return null;
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	public static Type GetFileTypeFromAsset(TextAsset asset)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToBool")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToInt")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector2")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector3")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector4")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToFloat")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Parse")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static object TokensToObject(FieldInfo field, string[] tokens)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	private static string RemoveComments(string str)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallerCount(Count = 1)]
	private static Vector4 ArgsToVector4(string[] args)
	{
		return default(Vector4);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	private static Vector3 ArgsToVector3(string[] args)
	{
		return default(Vector3);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	private static Vector2 ArgsToVector2(string[] args)
	{
		return default(Vector2);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallAnalysisFailed]
	private static float ArgsToFloat(string[] args)
	{
		return default(float);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	private static int ArgsToInt(string[] args)
	{
		return default(int);
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallsUnknownMethods(Count = 2)]
	private static bool ArgsToBool(string[] args)
	{
		return default(bool);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	private static string ArgsToString(string[] args)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	public Type GetFieldType(string fieldName)
	{
		return null;
	}

	[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToDefaultPosition")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "get_DefaultPosition")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "get_DefaultRotation")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AnimateToDefaultPosition")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AnimateToDefaultPosition")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToDefaultPosition")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 6)]
	public object GetFieldValue(string fieldName)
	{
		return null;
	}

	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CallsUnknownMethods(Count = 1)]
	public static string ExtractFilenameFromPath(string path)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Parse")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Parse")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToInt")]
	[CallsUnknownMethods(Count = 25)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToBool")]
	[CallerCount(Count = 4)]
	private static void PresetError(string message)
	{
	}

	[CallerCount(Count = 6)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ClearTextFile")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	private static void Error(string message)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(StackTrace), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 11)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CallerCount(Count = 4)]
	private static string GetErrorLocation()
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileType")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileTypeFromAsset")]
	[CalledBy(Type = typeof(vp_StateManager), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "CreateFromComponent")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	public vp_ComponentPreset()
	{
	}
}
