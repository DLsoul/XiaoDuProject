using Sirenix.OdinInspector.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class testmogoudemo : OdinEditorWindow
{
	[MenuItem("mygame/testmogoudemo")]
	private static void OpenWindow()
	{
		GetWindow<testmogoudemo>().Show();
	}

}
