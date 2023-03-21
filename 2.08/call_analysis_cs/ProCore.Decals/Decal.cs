using System;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace ProCore.Decals;

[Serializable]
public class Decal
{
	private static Vector3 DefaultRotation;

	private static Vector3 DefaultScale;

	public string name;

	public string id;

	public bool isPacked;

	public string materialId;

	public Vector3 rotation;

	public Vector3 scale;

	public Rect atlasRect;

	public int orgGroup;

	public int orgIndex;

	public int atlasGroup;

	public int atlasIndex;

	public Placement rotationPlacement;

	public Placement scalePlacement;

	public Texture2D texture;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Decal()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CallsUnknownMethods(Count = 1)]
	public Decal(Texture2D img)
	{
	}

	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 0)]
	public override string ToString()
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Decal), Member = "Vec3WithString")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Decal), Member = "Vec3WithString")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Decal), Member = "Vec4WithString")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	public static bool Deserialize(string txt, out Decal decal)
	{
		decal = null;
		return default(bool);
	}

	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CallsUnknownMethods(Count = 127)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(Decal), Member = "Deserialize")]
	[CalledBy(Type = typeof(Decal), Member = "Deserialize")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	private static bool Vec3WithString(string str, ref Vector3 vec3)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Decal), Member = "Deserialize")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "Replace")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	private static bool Vec4WithString(string str, ref Vector4 vec4)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static Rect Vec4ToRect(Vector4 v)
	{
		return default(Rect);
	}
}
