using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ImageWriteRequest
{
	public enum Type
	{
		PNG,
		EXR,
		EXR_Depth
	}

	internal string filename;

	internal Color[] imageColors;

	internal byte[] imageBytes;

	internal uint width;

	internal uint height;

	internal Type type;

	internal float farClip;

	[CallerCount(Count = 0)]
	internal ImageWriteRequest(string _filename, Color[] _image, uint _width, uint _height, Type _type, float _farClip)
	{
	}

	[CallerCount(Count = 0)]
	internal ImageWriteRequest(string _filename, Color[] _image, uint _width, uint _height, Type _type)
	{
	}

	[CallerCount(Count = 0)]
	internal ImageWriteRequest(string _filename, byte[] _image, uint _width, uint _height, Type _type)
	{
	}
}
