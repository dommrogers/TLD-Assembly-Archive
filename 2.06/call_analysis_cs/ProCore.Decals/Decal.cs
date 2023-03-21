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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 33)]
	public override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "TrimWhiteSpaceHelper")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(Decal), Member = "Vec3WithString")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Decal), Member = "Vec4WithString")]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(Type = typeof(bool), Member = "TryParse")]
	[CallsUnknownMethods(Count = 7)]
	public static bool Deserialize(string txt, out Decal decal)
	{
		decal = null;
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(Vector3), Member = "ToString")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 127)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(Decal), Member = "Deserialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[CallsUnknownMethods(Count = 2)]
	private static bool Vec3WithString(string str, ref Vector3 vec3)
	{
		return false;
	}

	[CalledBy(Type = typeof(Decal), Member = "Deserialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Replace")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[CallsUnknownMethods(Count = 2)]
	private static bool Vec4WithString(string str, ref Vector4 vec4)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static Rect Vec4ToRect(Vector4 v)
	{
		return default(Rect);
	}
}
