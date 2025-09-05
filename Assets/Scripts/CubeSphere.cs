using UnityEngine;
using UnityEditor;

public class CubeSphere : MonoBehaviour
{
    public float size = 1f;
    public GameObject[] cubes;
    public GameObject[] spheres;

    private bool cubesDisabled = false;
    private bool spheresDisabled = false;

    private void OnValidate()
    {
        foreach (GameObject cube in cubes)
        {
            cube.transform.localScale = Vector3.one * size;
        }
        foreach (GameObject sphere in spheres)
        {
            sphere.transform.localScale = Vector3.one * size;
        }
    }

    public void SelectCubes()
    {
        Selection.objects = cubes;
    }
    public void SelectSpheres()
    {
        Selection.objects = spheres;
    }

    public void ClearSelection()
    {
        Selection.objects = new Object[0];
    }

    public void EnableDisableCubes()
    {
        cubesDisabled = !cubesDisabled;

        foreach (GameObject cube in cubes)
        {
            cube.SetActive(!cubesDisabled);
        }
    }
    public void EnableDisableSpheres()
    {
        spheresDisabled = !spheresDisabled;

        foreach (GameObject sphere in spheres)
        {
            sphere.SetActive(!spheresDisabled);
        }
    }
}
