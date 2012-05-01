/* DrawRopeEditor.cs - Eddie Cameron
 * ----------------------------
 * Will redraw the rope when any parameters are changed or rope object is selected
 * ----------------------------
 */ 
using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor( typeof(DrawRope) )]
public class DrawRopeEditor : Editor 
{	
	public override void OnInspectorGUI ()
	{	
		base.OnInspectorGUI ();
		if ( GUI.changed )
			Redraw();
	}
	
	void OnEnable()
	{
		Redraw();
	}
	
	void Redraw()
	{
		((DrawRope)target ).RedrawRope();
	}
}
