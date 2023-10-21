using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class SetDescriptionUI : MonoBehaviour
{
    [SerializeField] private ObjectDescription objectDescription;
    [SerializeField] private ObjectInfo objectInfo;

    public void ShowInfo()
    {
        objectDescription.gameObject.SetActive(true);
        
        objectDescription.kabupatenKotaText.text = objectInfo.GetKabupatenKota();
        objectDescription.scoreText.text = "Skor: " + objectInfo.GetScore();
        objectDescription.indexUMLText.text = "Indeks UML: " + objectInfo.GetIndexUML();
        objectDescription.indexTertibUkurText.text = "Indeks Tertib Ukur: " + objectInfo.GetIndexTertibUkur();
        objectDescription.indexPemahamanText.text = "Indeks Pemahaman Masyarakat Terhadap Metrologi Legal: " + objectInfo.GetIndexPemahaman();
        objectDescription.inovasiPelayananText.text = "Inovasi Pelayanan: " + objectInfo.GetInovasiPelayanan() + "%";
        objectDescription.judulInovasiPelayananText.text = "Judul Inovasi Pelayanan: " + objectInfo.GetJudulInovasiPelayanan();
    }

    public void UnshowInfo()
    {
        objectDescription.gameObject.SetActive(false);
    }
}
