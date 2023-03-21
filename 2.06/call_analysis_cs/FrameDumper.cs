using System;
using System.IO;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FrameDumper : MonoBehaviour
{
	public Material m_CopyImageMaterial;

	public Material m_CopyDepthMaterial;

	public Material m_CopyNormalsMaterial;

	public static int m_CaptureMode;

	public static FrameDumper m_Instance;

	public static string m_AnimToCaptureNext;

	private static string m_ShotDirectory;

	private static bool m_Dumping;

	private static int m_CurrentImageIndex;

	private static int m_CaptureFramerate;

	private static float m_CaptureFarClip;

	private static FrameDumpHelper m_CaptureHelper;

	private static ThreadedImageWriter m_ImageWriter;

	private static Camera m_WeaponCamera;

	private static CameraClearFlags m_WeaponCameraClearFlags;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 6)]
	public void Start()
	{
	}

	[Calls(Type = typeof(System.IO.FileSystem), Member = "RemoveDirectoryInternal")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(FrameDumper), Member = "CreateHelpers")]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	[Calls(Type = typeof(Time), Member = "set_captureFramerate")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	public static void StartDumpingToDirectory(string directoryName)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(FrameDumper), Member = "CreateHelpers")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_toggle")]
	[Calls(Type = typeof(FrameDumper), Member = "DestroyHelpers")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	[Calls(Type = typeof(Time), Member = "set_captureFramerate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	public static void Toggle()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(FrameDumper), Member = "MaybeStartDumpingAnimation")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FrameDumper), Member = "GetImageFilename")]
	private void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	public static void SetCaptureFramerate(int fps)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetFloat")]
	public static void SetCaptureFarClip(float farClip)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	public static void SetCaptureMode(int mode)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(FrameDumper), Member = "StartDumpingToDirectory")]
	[CalledBy(Type = typeof(FrameDumper), Member = "Toggle")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	private void CreateHelpers()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(FrameDumper), Member = "Toggle")]
	[CallsUnknownMethods(Count = 2)]
	private void DestroyHelpers()
	{
	}

	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 33)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(ThreadedImageWriter), Member = "AddWriteRequest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CalledBy(Type = typeof(FrameDumpHelper), Member = "OnRenderImage")]
	[Calls(Type = typeof(ImageConversion), Member = "EncodeToPNG")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(ThreadedImageWriter), Member = "AddWriteRequest")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(ThreadedImageWriter), Member = "AddWriteRequest")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(FrameDumper), Member = "GetImageFilename")]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	public void DumpFrame(RenderTexture image, RenderTexture depth, RenderTexture norm)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FrameDumper), Member = "GetImageFilename")]
	private void DumpFrameSimple()
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CalledBy(Type = typeof(FrameDumper), Member = "Update")]
	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrameSimple")]
	private static string GetImageFilename()
	{
		return null;
	}

	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	[Calls(Type = typeof(int), Member = "ToString")]
	private static string GetShotDirectory()
	{
		return null;
	}

	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[CalledBy(Type = typeof(FrameDumper), Member = "Update")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AnimatorClipInfo), Member = "get_clip")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Time), Member = "set_captureFramerate")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(AnimatorClipInfo), Member = "get_clip")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorClipInfo")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	private static void MaybeStartDumpingAnimation()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public FrameDumper()
	{
	}
}
