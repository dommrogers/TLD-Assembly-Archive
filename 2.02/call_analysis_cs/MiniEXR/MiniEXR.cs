using System;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace MiniEXR;

public static class MiniEXR
{
	private static byte[] kHeader;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	public static void MiniEXRWrite(string _filePath, uint _width, uint _height, Color[] _colorArray)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CalledBy(Type = typeof(ThreadedImageWriter), Member = "ImageWriter")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CallsUnknownMethods(Count = 17)]
	public static byte[] MiniEXRWrite(uint _width, uint _height, Color[] _colorArray)
	{
		return null;
	}

	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[Calls(Type = typeof(File), Member = "WriteAllBytes")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public static void MiniEXRWrite_Depth(string _filePath, uint _width, uint _height, Color[] _colorArray, float _farClip)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "IsZero")]
	[Calls(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CalledBy(Type = typeof(ThreadedImageWriter), Member = "ImageWriter")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CallsUnknownMethods(Count = 11)]
	public static byte[] MiniEXRWrite_Depth(uint _width, uint _height, Color[] _colorArray, float farClip)
	{
		return null;
	}

	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[CallsUnknownMethods(Count = 51)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Copy")]
	public static byte[] BuildEXRHeader(uint _width, uint _height, out int bufI)
	{
		System.Runtime.CompilerServices.Unsafe.As<int, @null>(ref bufI) = null;
		return null;
	}

	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite")]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	[CallsUnknownMethods(Count = 39)]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy")]
	[Calls(Type = typeof(MiniEXR), Member = "BuildEXRHeader")]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	[CallerCount(Count = 1)]
	public static byte[] MiniEXRWrite(uint _width, uint _height, uint _channels, float[] _rgbaArray)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(MiniEXR), Member = "MiniEXRWrite_Depth")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(Array), Member = "Copy")]
	[Calls(Type = typeof(HalfHelper), Member = "SingleToHalf")]
	[Calls(Type = typeof(Buffer), Member = "BlockCopy")]
	[Calls(Type = typeof(MiniEXR), Member = "BuildEXRHeader")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	public static byte[] MiniEXRWrite_Depth(uint _width, uint _height, float[] _rArray)
	{
		return null;
	}
}
