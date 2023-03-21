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

		[DeduplicatedMethod]
		[CallerCount(Count = 224)]
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
		[CallerCount(Count = 98)]
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

	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[CallsUnknownMethods(Count = 85)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ExtractFilenameFromPath")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ClearTextFile")]
	[CallsDeduplicatedMethods(Count = 27)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ExtractFilenameFromPath")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ExtractFilenameFromPath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ExtractFilenameFromPath")]
	public static string Save(vp_ComponentPreset savePreset, string fullPath, bool isDifference = false)
	{
		return null;
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "InitFromComponent")]
	[CallsUnknownMethods(Count = 54)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 10)]
	public static string SaveDifference(vp_ComponentPreset initialStatePreset, Component modifiedComponent, string fullPath, vp_ComponentPreset diskPreset)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CalledBy(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 12)]
	public void InitFromComponent(Component component)
	{
	}

	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallerCount(Count = 0)]
	public static vp_ComponentPreset CreateFromComponent(Component component)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileType")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 4)]
	public bool LoadTextStream(string fullPath)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	public static bool Load(Component component, string fullPath)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CallerCount(Count = 2)]
	[CallAnalysisFailed]
	public bool LoadFromResources(string resourcePath)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	public static vp_ComponentPreset LoadFromResources(Component component, string resourcePath)
	{
		return null;
	}

	[Calls(Type = typeof(TextAsset), Member = "DecodeString")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileTypeFromAsset")]
	[CalledBy(Type = typeof(vp_StateManager), Member = ".ctor")]
	[CallsUnknownMethods(Count = 9)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[CallerCount(Count = 4)]
	public bool LoadFromTextAsset(TextAsset file)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	public static vp_ComponentPreset LoadFromTextAsset(Component component, TextAsset file)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	private static void Append(string str)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	private static void ClearTextFile()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "RemoveComments")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Parse")]
	private void ParseLines(List<string> lines)
	{
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	private bool Parse(string line)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetErrorLocation")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[CalledBy(Type = typeof(vp_Component), Member = "ApplyPreset")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Load")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetErrorLocation")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetErrorLocation")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetErrorLocation")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(vp_StateManager), Member = "CombineStates")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CallsUnknownMethods(Count = 26)]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	public static bool Apply(Component component, vp_ComponentPreset preset)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	public static Type GetFileType(string fullPath)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CallsUnknownMethods(Count = 6)]
	public static Type GetFileTypeFromAsset(TextAsset asset)
	{
		return null;
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToFloat")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Parse")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector4")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector3")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector2")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToInt")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToBool")]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowIndexOutOfRangeException")]
	private static string RemoveComments(string str)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	private static Vector4 ArgsToVector4(string[] args)
	{
		return default(Vector4);
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallAnalysisFailed]
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

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	private static float ArgsToFloat(string[] args)
	{
		return default(float);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 4)]
	private static int ArgsToInt(string[] args)
	{
		return default(int);
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	private static bool ArgsToBool(string[] args)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	private static string ArgsToString(string[] args)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	public Type GetFieldType(string fieldName)
	{
		return null;
	}

	[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToDefaultPosition")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToDefaultPosition")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AnimateToDefaultPosition")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AnimateToDefaultPosition")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "get_DefaultRotation")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "get_DefaultPosition")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[CalledBy(Type = typeof(vp_FPSCamera), Member = "SetWeapon")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 4)]
	public object GetFieldValue(string fieldName)
	{
		return null;
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "LastIndexOf")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(string), Member = "Substring")]
	public static string ExtractFilenameFromPath(string path)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 25)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Parse")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Parse")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToInt")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToBool")]
	private static void PresetError(string message)
	{
	}

	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ClearTextFile")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	private static void Error(string message)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(StackTrace), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 4)]
	private static string GetErrorLocation()
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileType")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(vp_StateManager), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileTypeFromAsset")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "CreateFromComponent")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CalledBy(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	public vp_ComponentPreset()
	{
	}
}
