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

	[CallsUnknownMethods(Count = 6)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 0)]
	public void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Time), Member = "set_captureFramerate")]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Path), Member = "InsecureGetFullPath")]
	[Calls(Type = typeof(System.IO.FileSystem), Member = "RemoveDirectoryInternal")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(FrameDumper), Member = "CreateHelpers")]
	[CallsUnknownMethods(Count = 2)]
	public static void StartDumpingToDirectory(string directoryName)
	{
	}

	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(FrameDumper), Member = "DestroyHelpers")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(FrameDumper), Member = "CreateHelpers")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[CalledBy(Type = typeof(ConsoleManager), Member = "CONSOLE_capture_toggle")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	[Calls(Type = typeof(Time), Member = "set_captureFramerate")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 2)]
	public static void Toggle()
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(FrameDumper), Member = "GetImageFilename")]
	[Calls(Type = typeof(FrameDumper), Member = "MaybeStartDumpingAnimation")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(PlayerPrefs), Member = "SetInt")]
	[CallerCount(Count = 0)]
	public static void SetCaptureMode(int mode)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 7)]
	[CalledBy(Type = typeof(FrameDumper), Member = "StartDumpingToDirectory")]
	[CalledBy(Type = typeof(FrameDumper), Member = "Toggle")]
	[CallsUnknownMethods(Count = 6)]
	private void CreateHelpers()
	{
	}

	[CalledBy(Type = typeof(FrameDumper), Member = "Toggle")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Camera), Member = "set_clearFlags")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	private void DestroyHelpers()
	{
	}

	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(ImageConversion), Member = "EncodeToPNG")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(ThreadedImageWriter), Member = "AddWriteRequest")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(FrameDumpHelper), Member = "OnRenderImage")]
	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(Screen), Member = "get_height")]
	[Calls(Type = typeof(Screen), Member = "get_width")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(ThreadedImageWriter), Member = "AddWriteRequest")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 17)]
	[Calls(Type = typeof(FrameDumper), Member = "GetImageFilename")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Texture2D), Member = ".ctor")]
	[Calls(Type = typeof(Texture2D), Member = "ReadPixels")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Texture2D), Member = "GetPixels")]
	[Calls(Type = typeof(ThreadedImageWriter), Member = "AddWriteRequest")]
	public void DumpFrame(RenderTexture image, RenderTexture depth, RenderTexture norm)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(FrameDumper), Member = "GetImageFilename")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 1)]
	private void DumpFrameSimple()
	{
	}

	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrameSimple")]
	[CalledBy(Type = typeof(FrameDumper), Member = "DumpFrame")]
	[CalledBy(Type = typeof(FrameDumper), Member = "Update")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Concat")]
	private static string GetImageFilename()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	private static string GetShotDirectory()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Directory), Member = "Exists")]
	[Calls(Type = typeof(Directory), Member = "CreateDirectory")]
	[Calls(Type = typeof(DirectoryInfo), Member = ".ctor")]
	[CalledBy(Type = typeof(FrameDumper), Member = "Update")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(File), Member = "Delete")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(DirectoryInfo), Member = "GetFiles")]
	[Calls(Type = typeof(AnimatorClipInfo), Member = "get_clip")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(Time), Member = "set_captureFramerate")]
	[Calls(Type = typeof(Directory), Member = "InsecureGetCurrentDirectory")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Animator), Member = "GetCurrentAnimatorClipInfo")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(string), Member = "ToLower")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(AnimatorClipInfo), Member = "get_clip")]
	private static void MaybeStartDumpingAnimation()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public FrameDumper()
	{
	}
}
