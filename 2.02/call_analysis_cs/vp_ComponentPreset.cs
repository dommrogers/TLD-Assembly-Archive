using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
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
		[CallerCount(Count = 83)]
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
		[CallerCount(Count = 52)]
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
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(string), Member = "op_Inequality")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ExtractFilenameFromPath")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CallsUnknownMethods(Count = 87)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ExtractFilenameFromPath")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ExtractFilenameFromPath")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ExtractFilenameFromPath")]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ClearTextFile")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static string Save(vp_ComponentPreset savePreset, string fullPath, bool isDifference = false)
	{
		return null;
	}

	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsUnknownMethods(Count = 45)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "InitFromComponent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 11)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	public static string SaveDifference(vp_ComponentPreset initialStatePreset, Component modifiedComponent, string fullPath, vp_ComponentPreset diskPreset)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CalledBy(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 2)]
	public void InitFromComponent(Component component)
	{
	}

	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 13)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	public static vp_ComponentPreset CreateFromComponent(Component component)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileType")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(File), Member = "Exists")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[Calls(Type = typeof(StreamReader), Member = ".ctor")]
	public bool LoadTextStream(string fullPath)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[CallsUnknownMethods(Count = 8)]
	public static bool Load(Component component, string fullPath)
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Resources), Member = "Load")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public bool LoadFromResources(string resourcePath)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	public static vp_ComponentPreset LoadFromResources(Component component, string resourcePath)
	{
		return null;
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileTypeFromAsset")]
	[CallsUnknownMethods(Count = 20)]
	[CalledBy(Type = typeof(vp_StateManager), Member = ".ctor")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	public bool LoadFromTextAsset(TextAsset file)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(vp_Component), Member = "Load")]
	public static vp_ComponentPreset LoadFromTextAsset(Component component, TextAsset file)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Environment), Member = "get_NewLine")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CallsUnknownMethods(Count = 9)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	private static void Append(string str)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(StreamWriter), Member = ".ctor")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	private static void ClearTextFile()
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "Parse")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "RemoveComments")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void ParseLines(List<string> lines)
	{
	}

	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetType")]
	[Calls(Type = typeof(Type), Member = "GetType")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[CallsUnknownMethods(Count = 59)]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "TrimHelper")]
	[CallerCount(Count = 1)]
	private bool Parse(string line)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "Error")]
	[CallsUnknownMethods(Count = 27)]
	[CalledBy(Type = typeof(vp_StateManager), Member = "CombineStates")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Load")]
	[CalledBy(Type = typeof(vp_Component), Member = "ApplyPreset")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetErrorLocation")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetErrorLocation")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetErrorLocation")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "GetErrorLocation")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Concat")]
	public static bool Apply(Component component, vp_ComponentPreset preset)
	{
		return default(bool);
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	public static Type GetFileType(string fullPath)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(vp_ComponentPreset), Member = ".ctor")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	public static Type GetFileTypeFromAsset(TextAsset asset)
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToInt")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToBool")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector2")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector3")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector4")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "ArgsToFloat")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Parse")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private static object TokensToObject(FieldInfo field, string[] tokens)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[Calls(Type = typeof(string), Member = "get_Chars")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ParseLines")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static string RemoveComments(string str)
	{
		return null;
	}

	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[Calls(Type = typeof(Vector4), Member = "get_zero")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallsUnknownMethods(Count = 38)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static Vector4 ArgsToVector4(string[] args)
	{
		return default(Vector4);
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallsUnknownMethods(Count = 30)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	private static Vector3 ArgsToVector3(string[] args)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[CallsUnknownMethods(Count = 22)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(Vector2), Member = "get_zero")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	private static Vector2 ArgsToVector2(string[] args)
	{
		return default(Vector2);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "ParseSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint")]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance")]
	[CallerCount(Count = 1)]
	private static float ArgsToFloat(string[] args)
	{
		return default(float);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Convert), Member = "ToInt32")]
	private static int ArgsToInt(string[] args)
	{
		return default(int);
	}

	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(vp_ComponentPreset), Member = "PresetError")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "TokensToObject")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static bool ArgsToBool(string[] args)
	{
		return default(bool);
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 3)]
	[CallerCount(Count = 0)]
	private static string ArgsToString(string[] args)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 4)]
	[CallerCount(Count = 0)]
	public Type GetFieldType(string fieldName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "get_DefaultPosition")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(vp_FPSWeapon), Member = "get_DefaultRotation")]
	public object GetFieldValue(string fieldName)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Substring")]
	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[Calls(Type = typeof(string), Member = "LastIndexOf")]
	public static string ExtractFilenameFromPath(string path)
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector3")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector4")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector4")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector3")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector2")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToVector2")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToFloat")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToInt")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ArgsToBool")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Parse")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Parse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private static void PresetError(string message)
	{
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "ClearTextFile")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Append")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadTextStream")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void Error(string message)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Apply")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(StackTrace), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 12)]
	private static string GetErrorLocation()
	{
		return null;
	}

	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileTypeFromAsset")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "CreateFromComponent")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Load")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "SaveDifference")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromResources")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "LoadFromTextAsset")]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "GetFileType")]
	[CalledBy(Type = typeof(vp_StateManager), Member = ".ctor")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(vp_ComponentPreset), Member = "Save")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(vp_Component), Member = "RefreshDefaultState")]
	public vp_ComponentPreset()
	{
	}
}
