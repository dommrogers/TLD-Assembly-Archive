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
		[CallerCount(Count = 234)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 92)]
		get
		{
			return null;
		}
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static string Save(Component component, string fullPath)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ExtractFilenameFromPath")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ClearTextFile")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 97)]
	public static string Save(vp_ComponentPreset savePreset, string fullPath, bool isDifference = false)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "InitFromComponent")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 19)]
	public static string SaveDifference(vp_ComponentPreset initialStatePreset, Component modifiedComponent, string fullPath, vp_ComponentPreset diskPreset)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 3)]
	public void InitFromComponent(Component component)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 3)]
	public static vp_ComponentPreset CreateFromComponent(Component component)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileType")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public bool LoadTextStream(string fullPath)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CallsUnknownMethods(Count = 1)]
	public static bool Load(Component component, string fullPath)
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(TextAsset), Member = "DecodeString")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public bool LoadFromResources(string resourcePath)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CallsUnknownMethods(Count = 1)]
	public static vp_ComponentPreset LoadFromResources(Component component, string resourcePath)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileTypeFromAsset")]
	[CalledBy(Type = typeof(vp_StateManager), Member = ".ctor")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(TextAsset), Member = "DecodeString")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public bool LoadFromTextAsset(TextAsset file)
	{
		return false;
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
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static void Append(string str)
	{
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private static void ClearTextFile()
	{
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "RemoveComments")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Parse")]
	[CallsUnknownMethods(Count = 2)]
	private void ParseLines(List<string> lines)
	{
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 33)]
	private bool Parse(string line)
	{
		return false;
	}

	[CalledBy(Type = typeof(vp_Component), Member = "ApplyPreset")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CalledBy(Type = typeof(vp_StateManager), Member = "CombineStates")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetErrorLocation")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 36)]
	public static bool Apply(Component component, vp_ComponentPreset preset)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[CallsUnknownMethods(Count = 1)]
	public static Type GetFileType(string fullPath)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CallsUnknownMethods(Count = 1)]
	public static Type GetFileTypeFromAsset(TextAsset asset)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Parse")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToBool")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToInt")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector2")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector3")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector4")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToFloat")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 2)]
	private static object TokensToObject(FieldInfo field, string[] tokens)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowIndexOutOfRangeException")]
	[CallsUnknownMethods(Count = 2)]
	private static string RemoveComments(string str)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "Parse")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 42)]
	private static Vector4 ArgsToVector4(string[] args)
	{
		return default(Vector4);
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "Parse")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 33)]
	private static Vector3 ArgsToVector3(string[] args)
	{
		return default(Vector3);
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "Parse")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 24)]
	private static Vector2 ArgsToVector2(string[] args)
	{
		return default(Vector2);
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(float), Member = "Parse")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[CallsUnknownMethods(Count = 3)]
	private static float ArgsToFloat(string[] args)
	{
		return 0f;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[CallsUnknownMethods(Count = 3)]
	private static int ArgsToInt(string[] args)
	{
		return 0;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[CallsUnknownMethods(Count = 2)]
	private static bool ArgsToBool(string[] args)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	private static string ArgsToString(string[] args)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public Type GetFieldType(string fieldName)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "get_DefaultPosition")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "get_DefaultRotation")]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "AnimateToDefaultPosition")]
	[CalledBy(Type = typeof(FirstPersonItem), Member = "AnimateFPSMeshToDefaultPosition")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public object GetFieldValue(string fieldName)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CallerCount(Count = 4)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "LastIndexOf")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallsUnknownMethods(Count = 1)]
	public static string ExtractFilenameFromPath(string path)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Parse")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector4")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector3")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector2")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToFloat")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToInt")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToBool")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 25)]
	private static void PresetError(string message)
	{
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ClearTextFile")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private static void Error(string message)
	{
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StackTrace), Member = ".ctor")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 1)]
	private static string GetErrorLocation()
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "CreateFromComponent")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileType")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileTypeFromAsset")]
	[CalledBy(Type = typeof(vp_StateManager), Member = ".ctor")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public vp_ComponentPreset()
	{
	}
}
