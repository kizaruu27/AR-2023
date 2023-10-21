using UnityEngine;

[CreateAssetMenu(menuName = "Object Info", fileName = "Info")]
public class ObjectInfo : ScriptableObject
{
    [SerializeField] private string kabupatenKota;
    [SerializeField] private float score;
    [SerializeField] private string indexUML;
    [SerializeField] private string indexTertibUkur;
    [SerializeField] private string indexPemahamanMasyarakatTerhadapMetrologiLegal;
    [SerializeField] private float inovasiPelayanan;
    [SerializeField] private string judulInovasiPelayanan;

    public string GetKabupatenKota()
    {
        return kabupatenKota;
    }

    public float GetScore()
    {
        return score;
    }

    public string GetIndexUML()
    {
        return indexUML;
    }

    public string GetIndexTertibUkur()
    {
        return indexTertibUkur;
    }

    public string GetIndexPemahaman()
    {
        return indexPemahamanMasyarakatTerhadapMetrologiLegal;
    }

    public float GetInovasiPelayanan()
    {
        return inovasiPelayanan;
    }

    public string GetJudulInovasiPelayanan()
    {
        return judulInovasiPelayanan;
    }
}
