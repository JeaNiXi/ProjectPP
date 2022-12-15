using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SO_LevelGrid))]
public class GameBoardEditor : Editor
{
    private int width;
    private int height;

    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        SO_LevelGrid soLevelGrid = (SO_LevelGrid)target;

        if (GUILayout.Button("Generate Grid"))
        {
            width = soLevelGrid.Width;
            height = soLevelGrid.Height;
            soLevelGrid.GridData = new bool[width, height];
            Debug.Log(width + height);
        }
        EditorGUILayout.BeginHorizontal();
        for(int i = 0; i < width; i++)
        {
            EditorGUILayout.BeginVertical();
            for (int j = 0; j < height; j++)
            {
                soLevelGrid.GridData[i, j] = EditorGUILayout.Toggle(soLevelGrid.GridData[i, j]);
            }
            EditorGUILayout.EndVertical();
        }
        EditorGUILayout.EndHorizontal();
    }

}
